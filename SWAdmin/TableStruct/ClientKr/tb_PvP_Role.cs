using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_PvP_Role_Client : BaseStruct
    {
        public tb_PvP_Role[] lsData;
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

        public class tb_PvP_Role : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt16 Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public Int32 Unkown14;
            public Byte Unkown15;
            public Int32 Unkown16;
            public Int32 Unkown17;
            public Byte Unkown18;
            public Int32 Unkown19;
            public Int32 Unkown20;
            public Byte Unkown21;
            public Byte Unkown22;
            public Byte Unkown23;
            public Int32 Unkown24;
            public Int32 Unkown25;


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
