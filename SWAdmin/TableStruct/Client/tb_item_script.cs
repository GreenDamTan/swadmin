using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_item_script_Client : BaseStruct
    {
        public tb_item_script[] lsData;
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

        public class tb_item_script : BaseStruct
        {
            public UInt32 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public String Unkown4 = "";
            public String Unkown5 = "";
            public String Unkown6 = "";
            public String Unkown7 = "";
            public Byte Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public String Unkown13 = "";
            public String Unkown14 = "";


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
