using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Monster_Broken_Parts_Client : BaseStruct
    {
        public tb_Monster_Broken_Parts[] lsData;
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

        public class tb_Monster_Broken_Parts : BaseStruct
        {
            public UInt32 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public String Unkown7 = "";
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public String Unkown10 = "";


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