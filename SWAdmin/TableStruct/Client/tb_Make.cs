using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Make_Client : BaseStruct
    {
        public tb_Make[] lsData;
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

        public class tb_Make : BaseStruct
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
            public UInt32 Unkown11;
            public UInt16 Unkown12;
            public UInt16 Unkown13;
            public UInt16 Unkown14;
            public UInt16 Unkown15;
            public UInt16 Unkown16;
            public UInt32 Unkown17;
            public UInt16 Unkown18;
            public Byte Unkown19;
            public UInt16 Unkown20;
            public Byte Unkown21;


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
