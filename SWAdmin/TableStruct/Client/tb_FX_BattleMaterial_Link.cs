using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_FX_BattleMaterial_Link_Client : BaseStruct
    {
        public tb_FX_BattleMaterial_Link[] lsData;
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

        public class tb_FX_BattleMaterial_Link : BaseStruct
        {
            public Byte Unkown1;
            public String Unkown2 = "";
            public Byte Unkown3;
            public Byte Unkown4;


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
