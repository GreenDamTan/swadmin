using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_SpecialMaze_Open_Client : BaseStruct
    {
        public tb_SpecialMaze_Open[] lsData;
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

        public class tb_SpecialMaze_Open : BaseStruct
        {
            public UInt16 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt16 Unkown10;
            public UInt16 Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public Byte Unkown14;
            public Byte Unkown15;
            public Byte Unkown16;
            public Byte Unkown17;
            public Byte Unkown18;
            public Byte Unkown19;
            public Byte Unkown20;
            public Byte Unkown21;


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