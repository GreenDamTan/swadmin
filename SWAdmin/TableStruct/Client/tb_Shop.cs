using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Shop_Client : BaseStruct
    {
        public tb_Shop[] lsData;
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

        public class tb_Shop : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public Byte Unkown6;
            public UInt32 Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public String Unkown14 = "";
            public String Unkown15 = "";
            public Byte Unkown16;
            public UInt16 Unkown17;
            public UInt32 Unkown18;
            public UInt32 Unkown19;
            public UInt32 Unkown20;
            public UInt32 Unkown21;
            public UInt32 Unkown22;
            public Byte Unkown23;
            public Byte Unkown24;
            public UInt32 Unkown25;


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
