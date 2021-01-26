using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_PVP_Revise_NI_Client : BaseStruct
    {
        public tb_PVP_Revise_NI[] lsData;
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

        public class tb_PVP_Revise_NI : BaseStruct
        {
            public UInt16 Unkown1;
            public Int32 Unkown2;
            public Int32 Unkown3;
            public Int16 Unkown4;
            public Int16 Unkown5;
            public Int16 Unkown6;
            public Int16 Unkown7;
            public Int16 Unkown8;
            public Int16 Unkown9;
            public Int32 Unkown10;
            public Int16 Unkown11;
            public Int16 Unkown12;


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
