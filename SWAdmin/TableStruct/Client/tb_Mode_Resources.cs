using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Mode_Resources_Client : BaseStruct
    {
        public tb_Mode_Resources[] lsData;
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

        public class tb_Mode_Resources : BaseStruct
        {
            public Byte Unkown1;
            public Byte Unkown2;
            public String Unkown3 = "";
            public String Unkown4 = "";
            public String Unkown5 = "";
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public Single Unkown9;
            public Single Unkown10;
            public Single Unkown11;


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
