using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Mode_CardMatch_Rule_Client : BaseStruct
    {
        public tb_Mode_CardMatch_Rule[] lsData;
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

        public class tb_Mode_CardMatch_Rule : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public Byte Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public Byte Unkown9;
            public UInt16 Unkown10;
            public UInt32 Unkown11;
            public UInt32 Unkown12;
            public UInt32 Unkown13;


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
