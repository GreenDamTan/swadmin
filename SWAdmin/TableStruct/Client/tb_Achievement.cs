using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Achievement_Client : BaseStruct
    {
        public tb_Achievement[] lsData;
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

        public class tb_Achievement : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public Byte Unkown4;
            public UInt16 Unkown5;
            public String Unkown6 = "";
            public UInt16 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public UInt32 Unkown15;
            public Byte Unkown16;
            public Byte Unkown17;
            public UInt32 Unkown18;
            public UInt32 Unkown19;
            public Byte Unkown20;
            public Byte Unkown21;


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