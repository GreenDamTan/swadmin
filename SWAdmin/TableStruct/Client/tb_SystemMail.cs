using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_SystemMail_Client : BaseStruct
    {
        public tb_SystemMail[] lsData;
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

        public class tb_SystemMail : BaseStruct
        {
            public Byte Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public String Unkown4 = "";
            public String Unkown5 = "";
            public String Unkown6 = "";
            public String Unkown7 = "";


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
