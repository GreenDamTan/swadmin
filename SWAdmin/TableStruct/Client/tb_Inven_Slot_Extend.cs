using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Inven_Slot_Extend_Client : BaseStruct
    {
        public tb_Inven_Slot_Extend[] lsData;
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

        public class tb_Inven_Slot_Extend : BaseStruct
        {
            public Byte Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public UInt16 Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public UInt32 Unkown10;
            public Byte Unkown11;
            public UInt16 Unkown12;
            public Byte Unkown13;
            public Byte Unkown14;
            public UInt32 Unkown15;
            public Byte Unkown16;
            public UInt16 Unkown17;
            public Byte Unkown18;
            public Byte Unkown19;
            public UInt32 Unkown20;
            public Byte Unkown21;
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