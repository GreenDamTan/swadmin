﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Color_Client : BaseStruct
    {
        public tb_Color[] lsData;
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

        public class tb_Color : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public Byte Unkown4;
            public Byte Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public Byte Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public Byte Unkown14;
            public Byte Unkown15;
            public Byte Unkown16;
            public Byte Unkown17;

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
