using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_district_Client : BaseStruct
    {
        public tb_district[] lsData;
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

        public class tb_district : BaseStruct
        {
            public Int16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public String Unkown5 = "";
            public String Unkown6 = "";
            public UInt16 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public String Unkown10 = "";
            public String Unkown11 = "";
            public Byte Unkown12;
            public Byte Unkown13;
            public String Unkown14 = "";
            public Byte Unkown15;
            public Byte Unkown16;


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
