using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_League_Raid_Client : BaseStruct
    {
        public tb_League_Raid[] lsData;
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

        public class tb_League_Raid : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public UInt32 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public UInt32 Unkown15;
            public UInt32 Unkown16;
            public UInt32 Unkown17;
            public UInt32 Unkown18;
            public UInt32 Unkown19;
            public UInt32 Unkown20;
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