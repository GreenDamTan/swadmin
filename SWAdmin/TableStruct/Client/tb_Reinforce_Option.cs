using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Reinforce_Option_Client : BaseStruct
    {
        public tb_Reinforce_Option[] lsData;
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

        public class tb_Reinforce_Option : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public UInt16 Unkown13;
            public UInt16 Unkown14;
            public UInt16 Unkown15;
            public UInt16 Unkown16;
            public UInt16 Unkown17;
            public UInt32 Unkown18;
            public UInt32 Unkown19;
            public UInt32 Unkown20;
            public UInt32 Unkown21;
            public UInt32 Unkown22;


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
