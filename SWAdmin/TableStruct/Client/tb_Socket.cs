using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Socket_Client : BaseStruct
    {
        public tb_Socket[] lsData;
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

        public class tb_Socket : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt16 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt16 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt16 Unkown13;
            public UInt32 Unkown14;
            public UInt16 Unkown15;


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
