using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Auto Generated by GreenDamTan
//Not verified it work or not
namespace SWAdmin.TableStruct.Client.JP_1_11_9_1
{
    public class tb_Cultivation_Client : BaseStruct
    {
        public tb_Cultivation[] lsData;
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

        public class tb_Cultivation : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public String Unkown11 = "";
            public String Unkown12 = "";
            public String Unkown13 = "";
            public String Unkown14 = "";
            public String Unkown15 = "";


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