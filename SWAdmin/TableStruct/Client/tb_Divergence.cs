using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Divergence_Client : BaseStruct
    {
        public tb_Divergence[] lsData;
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

        public class tb_Divergence : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public UInt32 Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public UInt16 Unkown10;
            public Byte Unkown11;
            public String Unkown12 = "";
            public Byte Unkown13;
            public UInt32 Unkown14;
            public Single Unkown15;


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
