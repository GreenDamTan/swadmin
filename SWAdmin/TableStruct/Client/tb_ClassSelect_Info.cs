using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_ClassSelect_Info_Client : BaseStruct
    {
        public tb_ClassSelect_Info[] lsData;
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

        public class tb_ClassSelect_Info : BaseStruct
        {
            public Byte Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public UInt32 Unkown15;
            public UInt32 Unkown16;
            public UInt16 Unkown17;
            public UInt16 Unkown18;
            public Int32 Unkown19;
            public UInt16 Unkown20;
            public String Unkown21 = "";
            public String Unkown22 = "";
            public String Unkown23 = "";
            public String Unkown24 = "";
            public String Unkown25 = "";
            public String Unkown26 = "";


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
