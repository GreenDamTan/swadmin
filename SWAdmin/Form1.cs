using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using FastMember;
using SWAdmin.TableStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static SWAdmin.TableStruct.TBItemServer;

namespace SWAdmin
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        private bool _reChecksumOnUpdate = false; 
        Dictionary<string, BaseStruct> _supportedFiles;
        Dictionary<string, DataTable> _dataTable;
        private string _currentResPath;
        private List<string> lsRes;
        public WorkerTypeEnum _currentWork;
        public List<DXPopupMenu> _gridMenu;
        public List<string> _lsEditUnsupported = new List<string>();
        public Form1()
        {
            InitializeComponent();
            _dataTable = new Dictionary<string, DataTable>();
            tabFormControl1.SelectedPage = tabFormPage1;
            tabFormControl1.SelectedContainer = tabFormContentContainer1;
        }

        private void CreateGridMenu()
        {
            if (_gridMenu == null || _gridMenu.Count <= 0)
            {
                _gridMenu = new List<DXPopupMenu>();
                DXPopupMenu _exportMenu = new DXPopupMenu();
                _exportMenu.Caption = "Export data";
                DXMenuItem toCsv = new DXMenuItem("-> to CSV");
                DXMenuItem toTxtPlain = new DXMenuItem("-> to plain text");
                DXMenuItem toTxtTrans = new DXMenuItem("-> to text for HQTranslation");
                string FileName = lbRes.SelectedItem.ToString();
                toCsv.Click += (o, args) =>
                {
                    this.xtraSaveFileDialog.FileName = FileName + ".csv";
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToCSV(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                toTxtPlain.Click += (o, args) =>
                {
                    this.xtraSaveFileDialog.FileName = FileName + ".txt";
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToTxtPlain(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                toTxtTrans.Click += (o, args) =>
                {
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToTxtTrans(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                DXPopupMenu _importMenu = new DXPopupMenu();
                _importMenu.Caption = "Import data";
                DXMenuItem fromCsv = new DXMenuItem("-> from CSV");
                DXMenuItem fromTxtTrans = new DXMenuItem("-> from text for HQTranslation");
                DXMenuItem fromRes = new DXMenuItem("-> from other res (Pls use same struct)");
                fromCsv.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromCsv(filename);
                            XtraMessageBox.Show("Data imported");
                        } finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                    }
                };
                fromTxtTrans.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromTxtTrans(filename, this.splashScreenManager);
                            XtraMessageBox.Show("Data imported");
                        }
                        finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                    }
                };
                fromRes.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            int cIndex = -1;
                            try
                            {
                                int.Parse(XtraInputBox.Show("Do you want to specify import column? (-1 for import all)", "Info", "-1"));
                            }
                            catch (Exception) { }
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromRes(this.ReadResFile(filename, false), cIndex, this.splashScreenManager);
                            XtraMessageBox.Show("Data imported");
                        } finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                }
                };
                _exportMenu.Items.Add(toCsv);
                _exportMenu.Items.Add(toTxtPlain);
                _exportMenu.Items.Add(toTxtTrans);
                _importMenu.Items.Add(fromCsv);
                _importMenu.Items.Add(fromTxtTrans);
                _importMenu.Items.Add(fromRes);
                _gridMenu.Add(_exportMenu);
                _gridMenu.Add(_importMenu);
            }
        }

        private void InitServerSupportedFiles()
        {
            _supportedFiles = new Dictionary<string, BaseStruct>();
            _supportedFiles.Add("tb_item.res", new TBItemServer());
            _supportedFiles.Add("tb_shop.res", new TBShopServer());
            _supportedFiles.Add("tb_cashshop.res", new TBCashShopServer());
            _supportedFiles.Add("tb_cashshop_tab.res", new TBCashShopTabServer());
            _supportedFiles.Add("tb_cashbilling_info.res", new TBCashBillingInfoServer());
            _supportedFiles.Add("tb_skill.res", new TBSKILLServer());
            _supportedFiles.Add("tb_item_classify.res", new TBItemClassifyServer());
            _supportedFiles.Add("tb_equalizer_info.res", new TBEqualizerInfoServer());
            _supportedFiles.Add("tb_achievement.res", new TBAchievementServer());
            _supportedFiles.Add("tb_character_info.res", new TBCharacterInfoServer());
            _supportedFiles.Add("tb_chattingcommand.res", new TBChattingCommandServer());
            _supportedFiles.Add("tb_serverinfo.res", new TBServerInfoServer());
            _supportedFiles.Add("tb_specialmaze_open.res", new TBSpecialMazeOpenServer());
            _supportedFiles.Add("tb_maze_opencontrol.res", new TBMazeOpenControlServer());
            _supportedFiles.Add(ToLow("tb_Common.res"), new tb_Common_Server());
            _supportedFiles.Add(ToLow("tb_Quest_Episode.res"), new tb_Quest_Episode_Server());
            _supportedFiles.Add("tb_daily_mission.res", new TBDailyMissionServer());
            _supportedFiles.Add("tb_week_day.res", new TBWeekDayServer());
            _supportedFiles.Add("tb_photo_item.res", new TBPhotoItemServer());
            _supportedFiles.Add("tb_monster.res", new TBMonsterServer());
            _supportedFiles.Add("tb_drop.res", new TBDropServer());
            _supportedFiles.Add("tb_maze_info.res", new TBMazeInfoServer());
            _supportedFiles.Add("tb_mazereward_item.res", new TBMazeRewardItemServer());
            _supportedFiles.Add("tb_item_evolution.res", new TBItemEvolutionServer());
            _supportedFiles.Add("tb_reinforce.res", new TBReinforceServer());
            _supportedFiles.Add("tb_drop_group.res", new TBDropGroupServer());
            _supportedFiles.Add("tb_drop_group_character.res", new TBDropGroupCharacterServer());
            _supportedFiles.Add("tb_maze_open_group.res", new TBMazeOpenGroupServer());
            _supportedFiles.Add("tb_npc.res", new TBNPCServer());
            _supportedFiles.Add("tb_akashic_make.res", new TBAkashicMakeServer());
            _supportedFiles.Add("tb_akashic_records.res", new TBAkashicRecordsServer());
        }
        private void InitClientSupportedFiles()
        {
            _supportedFiles = new Dictionary<string, BaseStruct>();

            _supportedFiles.Add(ToLow("tb_Achievement.res"), new tb_Achievement_Client());
            _supportedFiles.Add(ToLow("tb_Achievement_begin.res"), new tb_Achievement_begin_Client());
            _supportedFiles.Add(ToLow("tb_Achievement_Emblem.res"), new tb_Achievement_Emblem_Client());
            _supportedFiles.Add(ToLow("tb_Achievement_Script.res"), new tb_Achievement_Script_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Combination.res"), new tb_Akashic_Combination_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Disassemble.res"), new tb_Akashic_Disassemble_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Make.res"), new tb_Akashic_Make_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Parts.res"), new tb_Akashic_Parts_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Records.res"), new tb_Akashic_Records_Client());
            _supportedFiles.Add(ToLow("tb_Akashic_Slot_Extend.res"), new tb_Akashic_Slot_Extend_Client());
            _supportedFiles.Add(ToLow("tb_Appearance.res"), new tb_Appearance_Client());
            _supportedFiles.Add(ToLow("tb_Aura.res"), new tb_Aura_Client());
            _supportedFiles.Add(ToLow("tb_Bank_Slot_Extend.res"), new tb_Bank_Slot_Extend_Client());
            _supportedFiles.Add(ToLow("tb_Battle_Arena_Info.res"), new tb_Battle_Arena_Info_Client());
            _supportedFiles.Add(ToLow("tb_Booster.res"), new tb_Booster_Client());
            _supportedFiles.Add(ToLow("tb_Booster_Script.res"), new tb_Booster_Script_Client());
            _supportedFiles.Add(ToLow("Tb_Broach_Set.res"), new Tb_Broach_Set_Client());
            _supportedFiles.Add(ToLow("Tb_Broach_set_book.res"), new Tb_Broach_set_book_Client());
            _supportedFiles.Add(ToLow("tb_broach_Simulator.res"), new tb_broach_Simulator_Client());
            _supportedFiles.Add(ToLow("TB_BroachData.res"), new TB_BroachData_Client());
            _supportedFiles.Add(ToLow("tb_Buff.res"), new tb_Buff_Client());
            _supportedFiles.Add(ToLow("tb_Buff_Script.res"), new tb_Buff_Script_Client());
            _supportedFiles.Add(ToLow("tb_CashBilling_Info.res"), new tb_CashBilling_Info_Client());
            _supportedFiles.Add(ToLow("tb_CashShop.res"), new tb_CashShop_Client());
            _supportedFiles.Add(ToLow("tb_Change_Mob_ID.res"), new tb_Change_Mob_ID_Client());
            _supportedFiles.Add(ToLow("tb_change_tab.res"), new tb_change_tab_Client());
            _supportedFiles.Add(ToLow("tb_Character_Background.res"), new tb_Character_Background_Client());
            _supportedFiles.Add(ToLow("tb_Character_Info.res"), new tb_Character_Info_Client());
            _supportedFiles.Add(ToLow("tb_Character_Parts.res"), new tb_Character_Parts_Client());
            _supportedFiles.Add(ToLow("tb_ChattingFilter.res"), new tb_ChattingFilter_Client());
            _supportedFiles.Add(ToLow("tb_Check_Access_Reward.res"), new tb_Check_Access_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Check_Attendance_Info.res"), new tb_Check_Attendance_Info_Client());
            _supportedFiles.Add(ToLow("tb_Check_Attendance_Reward.res"), new tb_Check_Attendance_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Check_Attendance_Streak.res"), new tb_Check_Attendance_Streak_Client());
            _supportedFiles.Add(ToLow("tb_Cinema_String.res"), new tb_Cinema_String_Client());
            _supportedFiles.Add(ToLow("tb_Class_form.res"), new tb_Class_form_Client());
            _supportedFiles.Add(ToLow("tb_Class_Speech.res"), new tb_Class_Speech_Client());
            _supportedFiles.Add(ToLow("tb_ClassBattle_Role.res"), new tb_ClassBattle_Role_Client());
            _supportedFiles.Add(ToLow("tb_ClassSelect_Info.res"), new tb_ClassSelect_Info_Client());
            _supportedFiles.Add(ToLow("tb_Color.res"), new tb_Color_Client());
            _supportedFiles.Add(ToLow("tb_Combo_Buff.res"), new tb_Combo_Buff_Client());
            _supportedFiles.Add(ToLow("tb_Common.res"), new tb_Common_Client());
            _supportedFiles.Add(ToLow("tb_ControlKeyInfo.res"), new tb_ControlKeyInfo_Client());
            _supportedFiles.Add(ToLow("tb_Costume_Socket.res"), new tb_Costume_Socket_Client());
            _supportedFiles.Add(ToLow("tb_Create_Cloth.res"), new tb_Create_Cloth_Client());
            _supportedFiles.Add(ToLow("tb_CreateOption.res"), new tb_CreateOption_Client());
            _supportedFiles.Add(ToLow("tb_Credit_Raise.res"), new tb_Credit_Raise_Client());
            _supportedFiles.Add(ToLow("tb_Cultivation.res"), new tb_Cultivation_Client());
            _supportedFiles.Add(ToLow("tb_Customer_Benefit.res"), new tb_Customer_Benefit_Client());
            _supportedFiles.Add(ToLow("tb_Customer_Grade.res"), new tb_Customer_Grade_Client());
            _supportedFiles.Add(ToLow("tb_Customize_Eyes.res"), new tb_Customize_Eyes_Client());
            _supportedFiles.Add(ToLow("tb_Customize_Hair.res"), new tb_Customize_Hair_Client());
            _supportedFiles.Add(ToLow("tb_Customize_Info.res"), new tb_Customize_Info_Client());
            _supportedFiles.Add(ToLow("tb_Customize_Skin.res"), new tb_Customize_Skin_Client());
            _supportedFiles.Add(ToLow("tb_Customize_View_Ani.res"), new tb_Customize_View_Ani_Client());
            _supportedFiles.Add(ToLow("tb_Customize_View_Costume.res"), new tb_Customize_View_Costume_Client());
            _supportedFiles.Add(ToLow("tb_Customize_View_Sound.res"), new tb_Customize_View_Sound_Client());
            _supportedFiles.Add(ToLow("tb_Customize_View_Weapon.res"), new tb_Customize_View_Weapon_Client());
            _supportedFiles.Add(ToLow("tb_Cutscene_String.res"), new tb_Cutscene_String_Client());
            _supportedFiles.Add(ToLow("tb_Daily_Mission.res"), new tb_Daily_Mission_Client());
            _supportedFiles.Add(ToLow("tb_DailyMaze_Portal.res"), new tb_DailyMaze_Portal_Client());
            _supportedFiles.Add(ToLow("tb_Deck_Bonus.res"), new tb_Deck_Bonus_Client());
            _supportedFiles.Add(ToLow("tb_Def_Attack.res"), new tb_Def_Attack_Client());
            _supportedFiles.Add(ToLow("tb_Defensive_Weapon.res"), new tb_Defensive_Weapon_Client());
            _supportedFiles.Add(ToLow("tb_Disassemble.res"), new tb_Disassemble_Client());
            _supportedFiles.Add(ToLow("tb_district.res"), new tb_district_Client());
            _supportedFiles.Add(ToLow("tb_District_Transport.res"), new tb_District_Transport_Client());
            _supportedFiles.Add(ToLow("tb_Divergence.res"), new tb_Divergence_Client());
            _supportedFiles.Add(ToLow("Tb_Drop_Symbol.res"), new Tb_Drop_Symbol_Client());
            _supportedFiles.Add(ToLow("tb_DS_Point.res"), new tb_DS_Point_Client());
            _supportedFiles.Add(ToLow("tb_Dye.res"), new tb_Dye_Client());
            _supportedFiles.Add(ToLow("tb_Dye_Info.res"), new tb_Dye_Info_Client());
            _supportedFiles.Add(ToLow("tb_Echelon.res"), new tb_Echelon_Client());
            _supportedFiles.Add(ToLow("tb_Equalizer_Info.res"), new tb_Equalizer_Info_Client());
            _supportedFiles.Add(ToLow("tb_Equalizer_Summon.res"), new tb_Equalizer_Summon_Client());
            _supportedFiles.Add(ToLow("tb_Event_Condition.res"), new tb_Event_Condition_Client());
            _supportedFiles.Add(ToLow("tb_Faction.res"), new tb_Faction_Client());
            _supportedFiles.Add(ToLow("tb_Fragment_Exchange.res"), new tb_Fragment_Exchange_Client());
            _supportedFiles.Add(ToLow("tb_Fragment_Extraction.res"), new tb_Fragment_Extraction_Client());
            _supportedFiles.Add(ToLow("tb_FX_BattleMaterial_Link.res"), new tb_FX_BattleMaterial_Link_Client());
            _supportedFiles.Add(ToLow("tb_Gesture.res"), new tb_Gesture_Client());
            _supportedFiles.Add(ToLow("tb_Help.res"), new tb_Help_Client());
            _supportedFiles.Add(ToLow("tb_Help_PopUp.res"), new tb_Help_PopUp_Client());
            _supportedFiles.Add(ToLow("tb_Helper.res"), new tb_Helper_Client());
            _supportedFiles.Add(ToLow("tb_Helper_Reward.res"), new tb_Helper_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Hidden_Event.res"), new tb_Hidden_Event_Client());
            _supportedFiles.Add(ToLow("tb_HitVFX.res"), new tb_HitVFX_Client());
            _supportedFiles.Add(ToLow("tb_Infinite_Tower.res"), new tb_Infinite_Tower_Client());
            _supportedFiles.Add(ToLow("tb_Infinite_Tower_Monster.res"), new tb_Infinite_Tower_Monster_Client());
            _supportedFiles.Add(ToLow("tb_Interaction_Item.res"), new tb_Interaction_Item_Client());
            _supportedFiles.Add(ToLow("tb_Interaction_Object.res"), new tb_Interaction_Object_Client());
            _supportedFiles.Add(ToLow("tb_Inven_Slot_Extend.res"), new tb_Inven_Slot_Extend_Client());
            _supportedFiles.Add(ToLow("tb_Item.res"), new tb_Item_Client());
            _supportedFiles.Add(ToLow("tb_Item_Classify.res"), new tb_Item_Classify_Client());
            _supportedFiles.Add(ToLow("tb_Item_Classreward_Link.res"), new tb_Item_Classreward_Link_Client());
            _supportedFiles.Add(ToLow("tb_Item_CostumeSet.res"), new tb_Item_CostumeSet_Client());
            _supportedFiles.Add(ToLow("tb_Item_CountBox.res"), new tb_Item_CountBox_Client());
            _supportedFiles.Add(ToLow("tb_Item_CountBox_Group.res"), new tb_Item_CountBox_Group_Client());
            _supportedFiles.Add(ToLow("tb_Item_Evolution.res"), new tb_Item_Evolution_Client());
            _supportedFiles.Add(ToLow("tb_item_extraction.res"), new tb_item_extraction_Client());
            _supportedFiles.Add(ToLow("tb_item_information.res"), new tb_item_information_Client());
            _supportedFiles.Add(ToLow("tb_item_model.res"), new tb_item_model_Client());
            _supportedFiles.Add(ToLow("tb_Item_Package.res"), new tb_Item_Package_Client());
            _supportedFiles.Add(ToLow("tb_Item_RandomBox.res"), new tb_Item_RandomBox_Client());
            _supportedFiles.Add(ToLow("tb_Item_Repair.res"), new tb_Item_Repair_Client());
            _supportedFiles.Add(ToLow("tb_item_script.res"), new tb_item_script_Client());
            _supportedFiles.Add(ToLow("tb_Item_SetItem.res"), new tb_Item_SetItem_Client());
            _supportedFiles.Add(ToLow("tb_item_SimilarGroup.res"), new tb_item_SimilarGroup_Client());
            _supportedFiles.Add(ToLow("tb_Item_SubModel.res"), new tb_Item_SubModel_Client());
            _supportedFiles.Add(ToLow("tb_item_title.res"), new tb_item_title_Client());
            _supportedFiles.Add(ToLow("tb_Item_Title_Change.res"), new tb_Item_Title_Change_Client());
            _supportedFiles.Add(ToLow("tb_item_Title_Group.res"), new tb_item_Title_Group_Client());
            _supportedFiles.Add(ToLow("tb_item_Title_Value.res"), new tb_item_Title_Value_Client());
            _supportedFiles.Add(ToLow("tb_League_Attendance.res"), new tb_League_Attendance_Client());
            _supportedFiles.Add(ToLow("tb_League_Info.res"), new tb_League_Info_Client());
            _supportedFiles.Add(ToLow("tb_League_Mark.res"), new tb_League_Mark_Client());
            _supportedFiles.Add(ToLow("tb_League_Raid.res"), new tb_League_Raid_Client());
            _supportedFiles.Add(ToLow("tb_League_Skill.res"), new tb_League_Skill_Client());
            _supportedFiles.Add(ToLow("tb_LeagueSkill_Script.res"), new tb_LeagueSkill_Script_Client());
            _supportedFiles.Add(ToLow("tb_Levelup_Point.res"), new tb_Levelup_Point_Client());
            _supportedFiles.Add(ToLow("tb_Loading.res"), new tb_Loading_Client());
            _supportedFiles.Add(ToLow("tb_Loading_Img.res"), new tb_Loading_Img_Client());
            _supportedFiles.Add(ToLow("tb_Loading_String.res"), new tb_Loading_String_Client());
            _supportedFiles.Add(ToLow("tb_Make.res"), new tb_Make_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Enter_Count_Group.res"), new tb_Maze_Enter_Count_Group_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Info.res"), new tb_Maze_Info_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Open_Group.res"), new tb_Maze_Open_Group_Client());
            _supportedFiles.Add(ToLow("tb_Maze_OpenControl.res"), new tb_Maze_OpenControl_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Portal.res"), new tb_Maze_Portal_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Select.res"), new tb_Maze_Select_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_Difficulty.res"), new tb_MazeReward_Difficulty_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_GoldDirect.res"), new tb_MazeReward_GoldDirect_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_Level.res"), new tb_MazeReward_Level_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_Normal.res"), new tb_MazeReward_Normal_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_PartyValue.res"), new tb_MazeReward_PartyValue_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_Rank.res"), new tb_MazeReward_Rank_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_SoulVaper.res"), new tb_MazeReward_SoulVaper_Client());
            _supportedFiles.Add(ToLow("tb_MazeReward_Time.res"), new tb_MazeReward_Time_Client());
            _supportedFiles.Add(ToLow("tb_MessageNotifyer.res"), new tb_MessageNotifyer_Client());
            _supportedFiles.Add(ToLow("tb_Mileage.res"), new tb_Mileage_Client());
            _supportedFiles.Add(ToLow("tb_Mode_BI_Sector_Info.res"), new tb_Mode_BI_Sector_Info_Client());
            _supportedFiles.Add(ToLow("tb_Mode_BI_Skill_Edit.res"), new tb_Mode_BI_Skill_Edit_Client());
            _supportedFiles.Add(ToLow("tb_Mode_BI_Upgrade.res"), new tb_Mode_BI_Upgrade_Client());
            _supportedFiles.Add(ToLow("tb_Mode_CardMatch_Card.res"), new tb_Mode_CardMatch_Card_Client());
            _supportedFiles.Add(ToLow("tb_Mode_CardMatch_Faction.res"), new tb_Mode_CardMatch_Faction_Client());
            _supportedFiles.Add(ToLow("tb_Mode_CardMatch_Rule.res"), new tb_Mode_CardMatch_Rule_Client());
            _supportedFiles.Add(ToLow("tb_Mode_District6.res"), new tb_Mode_District6_Client());
            _supportedFiles.Add(ToLow("tb_Mode_District6_Date.res"), new tb_Mode_District6_Date_Client());
            _supportedFiles.Add(ToLow("tb_Mode_Operation.res"), new tb_Mode_Operation_Client());
            _supportedFiles.Add(ToLow("tb_Mode_Resources.res"), new tb_Mode_Resources_Client());
            _supportedFiles.Add(ToLow("tb_Monster.res"), new tb_Monster_Client());
            _supportedFiles.Add(ToLow("tb_Monster_Broken_Parts.res"), new tb_Monster_Broken_Parts_Client());
            _supportedFiles.Add(ToLow("tb_Monster_Parts.res"), new tb_Monster_Parts_Client());
            _supportedFiles.Add(ToLow("tb_Monster_RimLight.res"), new tb_Monster_RimLight_Client());
            _supportedFiles.Add(ToLow("tb_Monster_script.res"), new tb_Monster_script_Client());
            _supportedFiles.Add(ToLow("tb_Monster_Weapon.res"), new tb_Monster_Weapon_Client());
            _supportedFiles.Add(ToLow("tb_Myroom_Furniture.res"), new tb_Myroom_Furniture_Client());
            _supportedFiles.Add(ToLow("tb_Myroom_Greed.res"), new tb_Myroom_Greed_Client());
            _supportedFiles.Add(ToLow("tb_Myroom_Info.res"), new tb_Myroom_Info_Client());
            _supportedFiles.Add(ToLow("tb_NameFilter.res"), new tb_NameFilter_Client());
            _supportedFiles.Add(ToLow("tb_Navigation_Warpmap.res"), new tb_Navigation_Warpmap_Client());
            _supportedFiles.Add(ToLow("tb_Notice.res"), new tb_Notice_Client());
            _supportedFiles.Add(ToLow("tb_NPC.res"), new tb_NPC_Client());
            _supportedFiles.Add(ToLow("tb_NPC_Parts.res"), new tb_NPC_Parts_Client());
            _supportedFiles.Add(ToLow("tb_NPC_Script.res"), new tb_NPC_Script_Client());
            _supportedFiles.Add(ToLow("tb_Operation_Info.res"), new tb_Operation_Info_Client());
            _supportedFiles.Add(ToLow("tb_Option_String.res"), new tb_Option_String_Client());
            _supportedFiles.Add(ToLow("tb_PartyRevise.res"), new tb_PartyRevise_Client());
            _supportedFiles.Add(ToLow("tb_Pass_Info.res"), new tb_Pass_Info_Client());
            _supportedFiles.Add(ToLow("tb_Pass_Reward.res"), new tb_Pass_Reward_Client());
            _supportedFiles.Add(ToLow("tb_PC_Akashic.res"), new tb_PC_Akashic_Client());
            _supportedFiles.Add(ToLow("tb_PC_Costume.res"), new tb_PC_Costume_Client());
            _supportedFiles.Add(ToLow("tb_PC_Reward_System.res"), new tb_PC_Reward_System_Client());
            _supportedFiles.Add(ToLow("tb_PC_Reward_System_Month.res"), new tb_PC_Reward_System_Month_Client());
            _supportedFiles.Add(ToLow("tb_Photo_Item.res"), new tb_Photo_Item_Client());
            _supportedFiles.Add(ToLow("tb_Pollen.res"), new tb_Pollen_Client());
            _supportedFiles.Add(ToLow("tb_PreSet.res"), new tb_PreSet_Client());
            _supportedFiles.Add(ToLow("tb_PvP_levelup_Point.res"), new tb_PvP_levelup_Point_Client());
            _supportedFiles.Add(ToLow("tb_PvP_Limit.res"), new tb_PvP_Limit_Client());
            _supportedFiles.Add(ToLow("tb_PVP_Revise.res"), new tb_PVP_Revise_Client());
            _supportedFiles.Add(ToLow("tb_PVP_Revise_NI.res"), new tb_PVP_Revise_NI_Client());
            _supportedFiles.Add(ToLow("tb_PvP_Role.res"), new tb_PvP_Role_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Chapter.res"), new tb_Quest_Chapter_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Condition.res"), new tb_Quest_Condition_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Episode.res"), new tb_Quest_Episode_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Reward.res"), new tb_Quest_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Script.res"), new tb_Quest_Script_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Season.res"), new tb_Quest_Season_Client());
            _supportedFiles.Add(ToLow("tb_Random_Change.res"), new tb_Random_Change_Client());
            _supportedFiles.Add(ToLow("tb_Random_Get.res"), new tb_Random_Get_Client());
            _supportedFiles.Add(ToLow("tb_Random_Get_Group.res"), new tb_Random_Get_Group_Client());
            _supportedFiles.Add(ToLow("tb_Random_Option.res"), new tb_Random_Option_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Category_Group.res"), new tb_Rank_Category_Group_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Change.res"), new tb_Rank_Change_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Info.res"), new tb_Rank_Info_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Reward.res"), new tb_Rank_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Reward_Totalpoint.res"), new tb_Rank_Reward_Totalpoint_Client());
            _supportedFiles.Add(ToLow("tb_Rank_Tier.res"), new tb_Rank_Tier_Client());
            _supportedFiles.Add(ToLow("tb_Reinforce.res"), new tb_Reinforce_Client());
            _supportedFiles.Add(ToLow("tb_Reinforce_Exchange.res"), new tb_Reinforce_Exchange_Client());
            _supportedFiles.Add(ToLow("tb_Reinforce_Option.res"), new tb_Reinforce_Option_Client());
            _supportedFiles.Add(ToLow("tb_RepackageCostume.res"), new tb_RepackageCostume_Client());
            _supportedFiles.Add(ToLow("tb_ResVFX.res"), new tb_ResVFX_Client());
            _supportedFiles.Add(ToLow("tb_RoomRank_Reward.res"), new tb_RoomRank_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Select_Item.res"), new tb_Select_Item_Client());
            _supportedFiles.Add(ToLow("tb_SFX_BattleMaterial.res"), new tb_SFX_BattleMaterial_Client());
            _supportedFiles.Add(ToLow("tb_SFX_GroundMaterial.res"), new tb_SFX_GroundMaterial_Client());
            _supportedFiles.Add(ToLow("tb_Shop.res"), new tb_Shop_Client());
            _supportedFiles.Add(ToLow("tb_Shop_String.res"), new tb_Shop_String_Client());
            _supportedFiles.Add(ToLow("tb_Skill.res"), new tb_Skill_Client());
            _supportedFiles.Add(ToLow("tb_Skill_Action.res"), new tb_Skill_Action_Client());
            _supportedFiles.Add(ToLow("tb_Skill_Divide.res"), new tb_Skill_Divide_Client());
            _supportedFiles.Add(ToLow("tb_Skill_Option.res"), new tb_Skill_Option_Client());
            _supportedFiles.Add(ToLow("tb_Skill_Script.res"), new tb_Skill_Script_Client());
            _supportedFiles.Add(ToLow("tb_Skill_Slot_Extend.res"), new tb_Skill_Slot_Extend_Client());
            _supportedFiles.Add(ToLow("tb_Social_Item.res"), new tb_Social_Item_Client());
            _supportedFiles.Add(ToLow("tb_Social_Motion.res"), new tb_Social_Motion_Client());
            _supportedFiles.Add(ToLow("tb_Socket.res"), new tb_Socket_Client());
            _supportedFiles.Add(ToLow("tb_Soul_Guage.res"), new tb_Soul_Guage_Client());
            _supportedFiles.Add(ToLow("tb_soul_metry.res"), new tb_soul_metry_Client());
            _supportedFiles.Add(ToLow("tb_soul_metry_string.res"), new tb_soul_metry_string_Client());
            _supportedFiles.Add(ToLow("tb_SoulStone_LevelUp.res"), new tb_SoulStone_LevelUp_Client());
            _supportedFiles.Add(ToLow("tb_SpecialMaze_Open.res"), new tb_SpecialMaze_Open_Client());
            _supportedFiles.Add(ToLow("tb_Speech.res"), new tb_Speech_Client());
            _supportedFiles.Add(ToLow("tb_Speech_String.res"), new tb_Speech_String_Client());
            _supportedFiles.Add(ToLow("tb_Speech_tag.res"), new tb_Speech_tag_Client());
            _supportedFiles.Add(ToLow("tb_Status.res"), new tb_Status_Client());
            _supportedFiles.Add(ToLow("tb_SubWeapon.res"), new tb_SubWeapon_Client());
            _supportedFiles.Add(ToLow("tb_SystemMail.res"), new tb_SystemMail_Client());
            _supportedFiles.Add(ToLow("tb_Talk.res"), new tb_Talk_Client());
            _supportedFiles.Add(ToLow("tb_Talk_List.res"), new tb_Talk_List_Client());
            _supportedFiles.Add(ToLow("tb_Talk_String.res"), new tb_Talk_String_Client());
            _supportedFiles.Add(ToLow("tb_Time.res"), new tb_Time_Client());
            _supportedFiles.Add(ToLow("tb_Title_Info.res"), new tb_Title_Info_Client());
            _supportedFiles.Add(ToLow("tb_Title_Reward.res"), new tb_Title_Reward_Client());
            _supportedFiles.Add(ToLow("tb_Title_String.res"), new tb_Title_String_Client());
            _supportedFiles.Add(ToLow("tb_Tooltip_String.res"), new tb_Tooltip_String_Client());
            _supportedFiles.Add(ToLow("tb_Transport_Info.res"), new tb_Transport_Info_Client());
            _supportedFiles.Add(ToLow("tb_Transport_NPC_Pos.res"), new tb_Transport_NPC_Pos_Client());
            _supportedFiles.Add(ToLow("tb_UI_Img.res"), new tb_UI_Img_Client());
            _supportedFiles.Add(ToLow("tb_UI_PopUp.res"), new tb_UI_PopUp_Client());
            _supportedFiles.Add(ToLow("tb_UI_String.res"), new tb_UI_String_Client());
            _supportedFiles.Add(ToLow("tb_Unity_Event.res"), new tb_Unity_Event_Client());
            _supportedFiles.Add(ToLow("tb_VFX_BattleMaterial.res"), new tb_VFX_BattleMaterial_Client());
            _supportedFiles.Add(ToLow("tb_VFX_GroundMaterial.res"), new tb_VFX_GroundMaterial_Client());
            _supportedFiles.Add(ToLow("tb_Warlord_GUI.res"), new tb_Warlord_GUI_Client());
            _supportedFiles.Add(ToLow("tb_Week_Day.res"), new tb_Week_Day_Client());
            _supportedFiles.Add(ToLow("tb_Week_Group.res"), new tb_Week_Group_Client());
            _supportedFiles.Add(ToLow("tb_Week_Mission.res"), new tb_Week_Mission_Client());
            _supportedFiles.Add(ToLow("tb_world_event.res"), new tb_world_event_Client());
            _supportedFiles.Add(ToLow("tb_world_event_reward.res"), new tb_world_event_reward_Client());

        }
        string ToLow(string input) {
           return input.ToString().ToLower();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void btnLoadServerRes_Click(object sender, EventArgs e)
        {
            this.lbRes.DataSource = null;
            bgWorker.RunWorkerAsync(new WorkerArg(WorkerTypeEnum.LOAD_SERVER_RES, txtServerRes.Text));
        }

        private void btnLoadClientRes_Click(object sender, EventArgs e)
        {
            this.lbRes.DataSource = null;
            bgWorker.RunWorkerAsync(new WorkerArg(WorkerTypeEnum.LOAD_CLIENT_RES, txtClientRes.Text));
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!this.splashScreenManager.IsSplashFormVisible)
            {
                this.splashScreenManager.ShowWaitForm();
            }
            WorkerArg arg = (WorkerArg)e.Argument;
            if (arg.WorkerType == WorkerTypeEnum.LOAD_SERVER_RES || arg.WorkerType == WorkerTypeEnum.LOAD_CLIENT_RES)
            {
                this._currentWork = arg.WorkerType;
                this._gridMenu = null;
                this.LoadResDir(arg.WorkerType, arg.WorkerType == WorkerTypeEnum.LOAD_SERVER_RES ? txtServerRes.Text : txtClientRes.Text);
            } else if (arg.WorkerType == WorkerTypeEnum.LOAD_RES)
            {
                this.LoadResData(arg.ArgValue.ToString());
                this.CreateGridMenu();
                // Prevent export data to txt HQTrans for server
                if (this._currentWork == WorkerTypeEnum.LOAD_SERVER_RES && _gridMenu.Count > 0 && _gridMenu[0].Items.Count > 0)
                {
                    _gridMenu[0].Items.RemoveAt(_gridMenu[0].Items.Count - 1);
                }
            } else if (arg.WorkerType == WorkerTypeEnum.SAVE_RES)
            {
                this.SaveResData();
            } else if (arg.WorkerType == WorkerTypeEnum.TRANSLATE)
            {
            }
            if (this.splashScreenManager.IsSplashFormVisible)
            {
                this.splashScreenManager.CloseWaitForm();
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void LoadResData(string filePath)
        {
            string filename = lbRes.SelectedItem.ToString().ToLower();
            var structdata = _supportedFiles[filename];
            if (structdata._checksum <= 0)
            {
                SWReader reader = new SWReader(filePath);
                try
                {
                    reader.readObject(structdata);
                } catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                structdata.ResetChecksum();
                structdata.calcChecksum();
            }

            object[] a = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
            List<object> list = new List<object>(a);
            if (!_dataTable.ContainsKey(filename))
            {
                _dataTable.Add(filename, list.ToDataTable(a.GetType().GetElementType()));
            }

            Invoke(new Action(() =>
            {
                gridControl1.DataSource = _dataTable[filename];
                gridView1.BestFitColumns();
            }));
        }

        private void TabContentClear()
        {
            this.lbRes.DataSource = null;
            this.gridControl1.DataSource = null;
            this.lbRes.Items.Clear();
            this.gridView1.Columns.Clear();
            this._gridMenu = null;
        }

        private void LoadResDir(WorkerTypeEnum workerType, string resPath)
        {
            if (workerType == WorkerTypeEnum.LOAD_SERVER_RES)
            {
                this.InitServerSupportedFiles();
            }
            else if (workerType == WorkerTypeEnum.LOAD_CLIENT_RES)
            {
                this.InitClientSupportedFiles();
            }
            if (string.IsNullOrEmpty(resPath))
            {
                XtraMessageBox.Show((workerType == WorkerTypeEnum.LOAD_SERVER_RES ? "Server" : "Client") + " res path is empty");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(resPath);
            if (!di.Exists)
            {
                XtraMessageBox.Show((workerType == WorkerTypeEnum.LOAD_SERVER_RES ? "Server" : "Client") + " res path invalid");
                return;
            }
            FileInfo[] files = di.GetFiles("*.res");
            if (files.Length <= 0)
            {
                XtraMessageBox.Show("No res file found");
                return;
            }
            Invoke(new Action(() =>
            {
                lbRes.Items.Clear();
            }));
            lsRes = new List<string>();
            foreach (FileInfo fi in files)
            {
                if (this._supportedFiles.ContainsKey(fi.Name.ToLower()))
                {
                    lsRes.Add(fi.Name);
                }
            }
            this._currentResPath = resPath;
            Invoke(new Action(() =>
            {
                lbRes.DataSource = lsRes;
                tabFormContentContainer2.Visible = true;
                tabFormPage2.Visible = true;
                tabFormControl1.SelectedPage = tabFormPage2;
                tabFormControl1.SelectedContainer = tabFormContentContainer2;
                barbtnSave.Visibility = BarItemVisibility.Always;
            }));
        }

        private void SaveResData()
        {
            if (gridControl1.DataSource != null && !string.IsNullOrEmpty(_currentResPath))
            {
                string filename = lbRes.SelectedItem.ToString().ToLower();
                if (!_dataTable.ContainsKey(filename) || !_supportedFiles.ContainsKey(filename))
                {
                    XtraMessageBox.Show("Data table not have selected item???");
                    return;
                }
                if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName))
                {
                    Type type = _supportedFiles[filename].GetType();
                    List<object> lsObj = this.ConvertDataTableToList(_dataTable[filename], type.GetField("lsData").FieldType.GetElementType());
                    BaseStruct exportObj = Activator.CreateInstance(type) as BaseStruct;
                    Array arrData = Array.CreateInstance(type.GetField("lsData").FieldType.GetElementType(), lsObj.Count);
                    for (int i = 0; i < lsObj.Count; i++)
                    {
                        arrData.SetValue(lsObj[i], i);
                    }
                    type.GetField("lsData").SetValue(exportObj, arrData);
                    exportObj.ResetChecksum();
                    exportObj.calcChecksum();
                    exportObj.CreateMD5();
                    SWWriter writer = new SWWriter(this.xtraSaveFileDialog.FileName);
                    writer.writeObject(exportObj);
                    writer.flush();
                    XtraMessageBox.Show("Saved");
                }
            }
        }

        private void lbRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            if (lbRes == null || lbRes.SelectedItem == null || !_supportedFiles.ContainsKey(lbRes.SelectedItem.ToString().ToLower()))
            {
                return;
            }
            this.ReadResFile(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()), true);
        }

        private DataTable ReadResFile(string filepath, bool isAsync)
        {
            FileInfo fi = new FileInfo(filepath);
            if (this._lsEditUnsupported.Contains(fi.Name.ToLower()))
            {
                XtraMessageBox.Show(fi.Name + " is view only, checksum currently not work", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!fi.Exists)
            {
                XtraMessageBox.Show("Res file not found");
                return null;
            }
            if (isAsync)
            {
                WorkerArg arg = new WorkerArg(WorkerTypeEnum.LOAD_RES, fi.FullName);
                if (bgWorker.IsBusy)
                {
                    this.CreateWorkerInstance();
                }
                bgWorker.RunWorkerAsync(arg);
            }
            else
            {
                string filename = fi.Name.ToLower();
                var structdata = _supportedFiles[filename];
                if (structdata._checksum <= 0)
                {
                    SWReader reader = new SWReader(filepath);
                    try
                    {
                        reader.readObject(structdata);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    structdata.ResetChecksum();
                    structdata.calcChecksum();
                }

                object[] a = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
                List<object> list = new List<object>(a);
                return list.ToDataTable(a.GetType().GetElementType());
            }
            return null;
        }

        private void CreateWorkerInstance()
        {
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
        }

        private void barbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            WorkerArg workerArg = new WorkerArg(WorkerTypeEnum.SAVE_RES, null);
            this.bgWorker.RunWorkerAsync(workerArg);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!_reChecksumOnUpdate)
            {
                return;
            }
            // To prevent paste from clipboard
            if (e.RowHandle < 0)
            {
                return;
            }
            // To re-calculate checksum
            // Get original checksum value
            FileInfo fi = new FileInfo(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()));
            if (!_supportedFiles.ContainsKey(fi.Name.ToLower()))
            {
                XtraMessageBox.Show("Idk how but error");
                return;
            }
            var structdata = _supportedFiles[fi.Name.ToLower()];
            var lsData = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
            if (lsData.Length <= e.RowHandle)
            {
                XtraMessageBox.Show("By someway, it's make error");
                return;
            }
            var fields = lsData[e.RowHandle].GetType().GetFields();
            if (fields.Length < e.Column.AbsoluteIndex)
            {
                XtraMessageBox.Show("Wtf did you do to make this error?");
                return;
            }
            var originalValueField = fields[e.Column.AbsoluteIndex];
            Int64 originalChecksum = this.GetChecksum(originalValueField.GetValue(lsData[e.RowHandle]));
            if (originalChecksum < 0)
            {
                BandedGridView view = sender as BandedGridView;
                view.SetRowCellValue(e.RowHandle, e.Column.FieldName, originalValueField.GetValue(lsData[e.RowHandle]));
                XtraMessageBox.Show("Not allow to update data here");
                return;
            }
            // Re-calculate checksum
            if (!_dataTable.ContainsKey(fi.Name.ToLower()))
            {
                XtraMessageBox.Show("Dahell is this error?");
                return;
            }
            Int64 newChecksum = this.GetChecksum(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle][e.Column.AbsoluteIndex]);
            // Set checksum value
            _dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"] = Convert.ToInt64(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"]) - originalChecksum;
            _dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"] = Convert.ToInt64(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"]) + newChecksum;
            // Re-offset
            if ("String".Equals(originalValueField.FieldType.Name))
            {
                //long adjust = Encoding.Unicode.GetBytes(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle][e.Column.AbsoluteIndex].ToString()).Length -
                //    Encoding.Unicode.GetBytes(originalValueField.GetValue(lsData[e.RowHandle]).ToString()).Length;
                //this.ReOffset(adjust, e.RowHandle + 1, fi.Name.ToLower(), lsData);
            }
        }

        private void ReOffset(long adjust, int startIndex, string dtKey, object[] lsRefData)
        {
            long offset;
            for (int i = startIndex; i < _dataTable[dtKey].Rows.Count; i++)
            {
                offset = (long)lsRefData[i].GetType().GetField("_offset").GetValue(lsRefData[i]);
                _dataTable[dtKey].Rows[i]["_offset"] = offset + adjust;
            }
        }

        private Int64 GetChecksum(object originalValue)
        {
            Int64 originalChecksum = 0;
            Type type = originalValue.GetType();
            switch (type.Name)
            {
                case "Double":
                case "UInt16":
                case "UInt32":
                case "UInt64":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Byte":
                case "Single":
                case "Boolean":
                    originalChecksum += Convert.ToInt64(originalValue);
                    break;
                case "String":
                    byte[] ss = Encoding.Unicode.GetBytes((string)originalValue);
                    originalChecksum += (ss.Length / 2);
                    foreach (byte b in ss)
                    {
                        originalChecksum += b;
                    }
                    break;
                default:
                    originalChecksum = -1;
                    break;
            }
            
            return originalChecksum;
        }

        private List<object> ConvertDataTableToList(DataTable dt, Type type)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();

            var fields = type.GetFields();

            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance(type);

                foreach (var field in fields)
                {
                    if (columnNames.Contains(field.Name))
                        field.SetValue(objT, row[field.Name]);
                }

                return objT;
            }).ToList();

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                //long adjust = 0;
                string filename = lbRes.SelectedItem.ToString().ToLower();
                foreach (int rowid in view.GetSelectedRows().OrderByDescending(c => c))
                {
                    //adjust += ((long)_dataTable[filename].Rows[rowid + 1]["_offset"] - (long)_dataTable[filename].Rows[rowid]["_offset"]);
                    _dataTable[filename].Rows[rowid].Delete();
                    //this.ReOffset(adjust, rowid, filename, _supportedFiles[filename].GetType().GetField("lsData").GetValue(_supportedFiles[filename]) as object[]);
                }
                // view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void gridView1_ClipboardRowPasting(object sender, ClipboardRowPastingEventArgs e)
        {
            try
            {
                string filename = lbRes.SelectedItem.ToString().ToLower();
                Type type = _supportedFiles[filename].GetType().GetField("lsData").FieldType.GetElementType();
                var columnNames = _dataTable[filename].Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
                var dr = e.OriginalValues;
                var objT = Activator.CreateInstance(type) as BaseStruct;

                foreach (var field in type.GetFields())
                {
                    if (columnNames.Contains(field.Name) && !e.Values[field.Name].GetType().IsAssignableFrom(typeof(DBNull)))
                        field.SetValue(objT, Convert.ChangeType(e.Values[field.Name], field.FieldType));
                }

                object[] arrData = _supportedFiles[filename].GetType().GetField("lsData").GetValue(_supportedFiles[filename]) as object[];
                Array setter = Array.CreateInstance(type, arrData.Length + 1);
                for (int i = 0; i < arrData.Length; i++)
                {
                    setter.SetValue(arrData[i], i);
                }
                setter.SetValue(objT, arrData.Length);
                _supportedFiles[filename].GetType().GetField("lsData").SetValue(_supportedFiles[filename], setter);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void lbRes_MouseDown(object sender, MouseEventArgs e)
        {
            this.lbRes_SelectedIndexChanged(sender, e);
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                if (_gridMenu != null && _gridMenu.Count > 0)
                {
                    _gridMenu.ForEach(menu =>
                    {
                        e.Menu.Items.Add(menu);
                    });
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (tabFormControl1.SelectedPage == tabFormPage2 && tabFormControl1.SelectedContainer == tabFormContentContainer2)
            {
                if (keyData == (Keys.Control | Keys.Shift | Keys.T))
                {
                    try
                    {
                        this.TranslateCell();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    return true;
                } else if (keyData == (Keys.Control | Keys.R))
                {
                    FileInfo fi = new FileInfo(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()));
                    _dataTable.Remove(fi.Name.ToLower());
                    WorkerArg arg = new WorkerArg(WorkerTypeEnum.LOAD_RES, fi.FullName);
                    if (bgWorker.IsBusy)
                    {
                        this.CreateWorkerInstance();
                    }
                    bgWorker.RunWorkerAsync(arg);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TranslateCell()
        {
            if (this.gridControl1.DataSource == null || lbRes == null || lbRes.DataSource == null || this._dataTable[lbRes.SelectedItem.ToString().ToLower()] == null)
            {
                XtraMessageBox.Show("Data not found");
                return;
            }
            GridView view = (GridView) gridControl1.FocusedView;
            string selectedValue = view.FocusedValue.ToString();
            view.SetFocusedValue(Translator.translate(selectedValue));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (gridView1.GetSelectedCells().Length > 0)
            {
                foreach (GridCell cell in gridView1.GetSelectedCells())
                {
                    if (cell.RowHandle == e.RowHandle && cell.Column == e.Column)
                    {
                        continue;
                    }
                    gridView1.SetRowCellValue(cell.RowHandle, cell.Column, e.Value);
                }
            }
        }
    }
}
