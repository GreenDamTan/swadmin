using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_UI_PopUp_Client : BaseStruct
    {
        public tb_UI_PopUp[] lsData;
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

        public class tb_UI_PopUp : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public UInt32 Unkown10;
            public UInt16 Unkown11;
            public Byte Unkown12;
            public UInt16 Unkown13;
            public UInt16 Unkown14;
            public UInt16 Unkown15;
            public UInt16 Unkown16;
            public UInt16 Unkown17;
            public UInt16 Unkown18;
            public UInt16 Unkown19;
            public UInt16 Unkown20;
            public UInt16 Unkown21;
            public UInt16 Unkown22;


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
