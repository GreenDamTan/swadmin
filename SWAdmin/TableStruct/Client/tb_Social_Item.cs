using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Social_Item_Client : BaseStruct
    {
        public tb_Social_Item[] lsData;
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

        public class tb_Social_Item : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public UInt32 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public String Unkown10 = "";
            public String Unkown11 = "";
            public String Unkown12 = "";
            public Int16 Unkown13;
            public String Unkown14 = "";
            public String Unkown15 = "";
            public Int16 Unkown16;
            public String Unkown17 = "";
            public UInt32 Unkown18;
            public Byte Unkown19;


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