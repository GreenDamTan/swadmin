using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Navigation_Warpmap_Client : BaseStruct
    {
        public tb_Navigation_Warpmap[] lsData;
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

        public class tb_Navigation_Warpmap : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public Byte Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt32 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt32 Unkown10;
            public UInt16 Unkown11;


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
