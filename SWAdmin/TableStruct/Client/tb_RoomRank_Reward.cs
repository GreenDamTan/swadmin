using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_RoomRank_Reward_Client : BaseStruct
    {
        public tb_RoomRank_Reward[] lsData;
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

        public class tb_RoomRank_Reward : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;


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
