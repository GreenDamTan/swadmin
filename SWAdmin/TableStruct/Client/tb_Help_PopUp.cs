using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Help_PopUp_Client : BaseStruct
    {
        public tb_Help_PopUp[] lsData;
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

        public class tb_Help_PopUp : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public String Unkown5 = "";
            public String Unkown6 = "";


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