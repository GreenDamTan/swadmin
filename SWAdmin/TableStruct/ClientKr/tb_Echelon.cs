using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Echelon_Client : BaseStruct
    {
        public tb_Echelon[] lsData;
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

        public class tb_Echelon : BaseStruct
        {
            public Byte Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public String Unkown4 = "";
            public String Unkown5 = "";
            public UInt32 Unkown6;
            public UInt16 Unkown7;
            public Byte Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt16 Unkown11;
            public Byte Unkown12;


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
