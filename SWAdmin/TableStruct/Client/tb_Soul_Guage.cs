using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Soul_Guage_Client : BaseStruct
    {
        public tb_Soul_Guage[] lsData;
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

        public class tb_Soul_Guage : BaseStruct
        {
            public Byte Unkown1;
            public UInt16 Unkown2;
            public Byte Unkown3;
            public UInt32 Unkown4;
            public Byte Unkown5;
            public Byte Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;


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
