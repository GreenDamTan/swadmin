using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Week_Group_Client : BaseStruct
    {
        public tb_Week_Group[] lsData;
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

        public class tb_Week_Group : BaseStruct
        {
            public Byte Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public UInt16 Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public UInt32 Unkown10;
            public UInt16 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public String Unkown14 = "";
            public String Unkown15 = "";


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