using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Akashic_Disassemble_Client : BaseStruct
    {
        public tb_Akashic_Disassemble[] lsData;
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

        public class tb_Akashic_Disassemble : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public UInt32 Unkown3;
            public Byte Unkown4;
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
