using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Operation_Info_Client : BaseStruct
    {
        public tb_Operation_Info[] lsData;
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

        public class tb_Operation_Info : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public Int32 Unkown6;
            public Int32 Unkown7;
            public Int32 Unkown8;
            public UInt16 Unkown9;
            public UInt16 Unkown10;
            public Int32 Unkown11;
            public Int32 Unkown12;
            public Int32 Unkown13;
            public Int32 Unkown14;
            public Int32 Unkown15;
            public Int32 Unkown16;
            public String Unkown17 = "";
            public Int32 Unkown18;
            public Int32 Unkown19;
            public Int32 Unkown20;
            public Int32 Unkown21;
            public Int32 Unkown22;
            public Int32 Unkown23;
            public Int32 Unkown24;
            public Int32 Unkown25;
            public Int32 Unkown26;
            public Int32 Unkown27;
            public Int32 Unkown28;
            public Int32 Unkown29;
            public Int32 Unkown30;
            public Int32 Unkown31;
            public Int32 Unkown32;
            public Int32 Unkown33;
            public UInt16 Unkown34;
            public UInt16 Unkown35;
            public UInt16 Unkown36;
            public UInt32 Unkown37;
            public UInt32 Unkown38;


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