using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Customize_View_Ani_Client : BaseStruct
    {
        public tb_Customize_View_Ani[] lsData;
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

        public class tb_Customize_View_Ani : BaseStruct
        {
            public Byte Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
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
