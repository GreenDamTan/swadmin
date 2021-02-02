using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_NPC_Client : BaseStruct
    {
        public tb_NPC[] lsData;
        public SWString md5_ = new SWString();

        public override void beforeRead()
        {
        }

        public override void beforeWrite()
        {
        }

        public override void read(SWReader reader)
        {
        }

        public override void write(SWWriter writer)
        {
        }

        public class tb_NPC : BaseStruct
        {
            public UInt32 NPC_ID;
            public UInt16 Npc_Group_ID;
            public Byte NPC_Faction;
            public String NPC_Code_Name = "";
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public Byte NPC_Status_Type;
            public UInt32 NPC_Status_ID;
            public Byte Unkown12;
            public Byte Unkown13;
            public UInt32 Unkown14;
            public Byte Unkown15;
            public UInt32 Unkown16;
            public Byte Unkown17;
            public UInt32 NPC_Sight;
            public UInt16 NPC_Walk_Speed;
            public UInt16 NPC_Run_Speed;
            public UInt16 NPC_Turn_Speed;
            public Byte NPC_League;
            public Byte NPC_Intersperse_Type;
            public Byte NPC_Function_Type_01;
            public Byte NPC_Function_Type_02;
            public Byte NPC_Function_Type_03;
            public Byte NPC_Function_Type_04;
            public UInt16 Unkown28;
            public UInt16 Unkown29;
            public UInt16 Unkown30;
            public String Unkown31 = "";
            public Byte Unkown32;
            public UInt32 Unkown33;
            public UInt32 Unkown34;
            public String Unkown35 = "";
            public UInt16 Unkown36;
            public UInt16 Unkown37;
            public UInt16 Unkown38;
            public UInt16 Unkown39;
            public UInt16 Unkown40;
            public UInt16 Unkown41;
            public UInt16 Unkown42;
            public UInt16 Unkown43;
            public UInt16 Unkown44;
            public UInt16 Unkown45;
            public UInt16 Unkown46;
            public UInt16 Unkown47;
            public UInt16 Unkown48;
            public UInt16 Unkown49;
            public UInt16 Unkown50;
            public UInt16 Unkown51;
            public String Unkown52 = "";
            public String Unkown53 = "";
            public String Unkown54 = "";
            public String Unkown55 = "";
            public String Unkown56 = "";


            public override void beforeRead()
            {
            }

            public override void beforeWrite()
            {
            }

            public override void read(SWReader reader)
            {
            }

            public override void write(SWWriter writer)
            {
            }
        }
    }
}
