using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Infinite_Tower_Client : BaseStruct
    {
        public tb_Infinite_Tower[] lsData;
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

        public class tb_Infinite_Tower : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public String Unkown3 = "";
            public Int16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public Byte Unkown15;
            public Byte Unkown16;
            public Byte Unkown17;
            public Byte Unkown18;
            public Byte Unkown19;
            public UInt32 Unkown20;
            public UInt32 Unkown21;
            public UInt32 Unkown22;
            public UInt32 Unkown23;
            public UInt32 Unkown24;
            public UInt16 Unkown25;
            public UInt16 Unkown26;
            public UInt16 Unkown27;
            public UInt16 Unkown28;
            public UInt16 Unkown29;


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
