using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Buff_Client : BaseStruct
    {
        public tb_Buff[] lsData;
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

        public class tb_Buff : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public Int32 Unkown7;
            public Byte Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public Byte Unkown14;
            public String Unkown15 = "";
            public UInt16 Unkown16;
            public UInt32 Unkown17;
            public UInt16 Unkown18;
            public UInt16 Unkown19;
            public Byte Unkown20;
            public Int32 Unkown21;
            public Byte Unkown22;
            public Int32 Unkown23;
            public Byte Unkown24;
            public Int32 Unkown25;
            public UInt16 Unkown26;
            public UInt16 Unkown27;
            public UInt16 Unkown28;
            public UInt16 Unkown29;
            public UInt16 Unkown30;
            public UInt16 Unkown31;
            public String Unkown32 = "";
            public UInt16 Unkown33;
            public UInt32 Unkown34;
            public Byte Unkown35;
            public Byte Unkown36;


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
