using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Aura_Client : BaseStruct
    {
        public tb_Aura[] lsData;
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

        public class tb_Aura : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public UInt32 Unkown3;
            public Byte Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;


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
