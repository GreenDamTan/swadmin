using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Speech_Client : BaseStruct
    {
        public tb_Speech[] lsData;
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

        public class tb_Speech : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public String Unkown8 = "";
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
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
