using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Item_Title_Change_Client : BaseStruct
    {
        public tb_Item_Title_Change[] lsData;
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

        public class tb_Item_Title_Change : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;


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