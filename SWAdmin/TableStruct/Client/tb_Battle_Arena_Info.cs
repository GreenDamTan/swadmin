using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Battle_Arena_Info_Client : BaseStruct
    {
        public tb_Battle_Arena_Info[] lsData;
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

        public class tb_Battle_Arena_Info : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public UInt32 Unkown6;
            public UInt16 Unkown7;


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
