using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Character_Parts_Client : BaseStruct
    {
        public tb_Character_Parts[] lsData;
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

        public class tb_Character_Parts : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public Byte Unkown3;
            public String Unkown4 = "";
            public String Unkown5 = "";
            public String Unkown6 = "";
            public String Unkown7 = "";
            public String Unkown8 = "";


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
