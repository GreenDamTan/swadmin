using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Customize_Eyes_Client : BaseStruct
    {
        public tb_Customize_Eyes[] lsData;
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

        public class tb_Customize_Eyes : BaseStruct
        {
            public Byte Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public String Unkown12 = "";
            public String Unkown13 = "";
            public String Unkown14 = "";
            public String Unkown15 = "";
            public String Unkown16 = "";
            public String Unkown17 = "";
            public String Unkown18 = "";
            public String Unkown19 = "";
            public String Unkown20 = "";
            public String Unkown21 = "";
            public UInt32 Unkown22;
            public UInt32 Unkown23;
            public UInt32 Unkown24;
            public UInt32 Unkown25;
            public UInt32 Unkown26;
            public UInt32 Unkown27;
            public UInt32 Unkown28;
            public UInt32 Unkown29;
            public UInt32 Unkown30;
            public UInt32 Unkown31;


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
