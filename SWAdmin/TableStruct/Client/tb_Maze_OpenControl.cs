using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Maze_OpenControl_Client : BaseStruct
    {
        public tb_Maze_OpenControl[] lsData;
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

        public class tb_Maze_OpenControl : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public String Unkown6 = "";


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
