using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Transport_Info_Client : BaseStruct
    {
        public tb_Transport_Info[] lsData;
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

        public class tb_Transport_Info : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public UInt16 Unkown4;
            public Byte Unkown5;
            public UInt32 Unkown6;
            public Byte Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public String Unkown10 = "";
            public Byte Unkown11;
            public UInt32 Unkown12;
            public Byte Unkown13;
            public Int16 Unkown14;
            public Int16 Unkown15;
            public Int16 Unkown16;
            public Int16 Unkown17;
            public Int16 Unkown18;
            public Int16 Unkown19;
            public Byte Unkown20;
            public Int16 Unkown21;
            public Int16 Unkown22;
            public String Unkown23 = "";


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
