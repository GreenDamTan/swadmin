using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_ClassBattle_Role_Client : BaseStruct
    {
        public tb_ClassBattle_Role[] lsData;
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

        public class tb_ClassBattle_Role : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public Byte Unkown4;
            public Byte Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt16 Unkown10;
            public Byte Unkown11;


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