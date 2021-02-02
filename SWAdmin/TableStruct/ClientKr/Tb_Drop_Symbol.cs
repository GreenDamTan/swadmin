using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class Tb_Drop_Symbol_Client : BaseStruct
    {
        public Tb_Drop_Symbol[] lsData;
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

        public class Tb_Drop_Symbol : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public String Unkown4 = "";
            public String Unkown5 = "";
            public String Unkown6 = "";
            public String Unkown7 = "";
            public String Unkown8 = "";
            public String Unkown9 = "";
            public String Unkown10 = "";
            public String Unkown11 = "";


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
