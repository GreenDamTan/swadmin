﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Item_CostumeSet_Client : BaseStruct
    {
        public tb_Item_CostumeSet[] lsData;
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

        public class tb_Item_CostumeSet : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public Byte Unkown3;
            public UInt32 Unkown4;
            public UInt32 Unkown5;
            public UInt32 Unkown6;
            public UInt32 Unkown7;
            public UInt32 Unkown8;
            public UInt32 Unkown9;
            public Byte Unkown10;
            public UInt32 Unkown11;
            public Byte Unkown12;
            public UInt32 Unkown13;
            public Byte Unkown14;
            public UInt32 Unkown15;
            public Byte Unkown16;
            public UInt32 Unkown17;
            public Byte Unkown18;
            public UInt32 Unkown19;
            public Byte Unkown20;
            public UInt32 Unkown21;

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
