using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_PC_Reward_System_Client : BaseStruct
    {
        public tb_PC_Reward_System[] lsData;
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

        public class tb_PC_Reward_System : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public UInt32 Unkown7;
            public Int16 Unkown8;
            public Int16 Unkown9;
            public Int16 Unkown10;
            public Int16 Unkown11;
            public Int16 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public UInt32 Unkown15;
            public UInt32 Unkown16;
            public UInt32 Unkown17;


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
