using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_District_Transport_Client : BaseStruct
    {
        public tb_District_Transport[] lsData;
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

        public class tb_District_Transport : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;


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