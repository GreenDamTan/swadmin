using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_HitVFX_Client : BaseStruct
    {
        public tb_HitVFX[] lsData;
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

        public class tb_HitVFX : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public String Unkown9 = "";
            public String Unkown10 = "";
            public String Unkown11 = "";
            public String Unkown12 = "";
            public String Unkown13 = "";
            public String Unkown14 = "";
            public String Unkown15 = "";


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
