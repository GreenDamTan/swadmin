using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Random_Get_Group_Client : BaseStruct
    {
        public tb_Random_Get_Group[] lsData;
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

        public class tb_Random_Get_Group : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt32 Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public UInt16 Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public UInt16 Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;


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
