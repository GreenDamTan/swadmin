using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_item_Title_Value_Client : BaseStruct
    {
        public tb_item_Title_Value[] lsData;
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

        public class tb_item_Title_Value : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public Int16 Unkown9;
            public Int16 Unkown10;
            public Int16 Unkown11;


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
