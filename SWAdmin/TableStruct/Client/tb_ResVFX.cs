﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_ResVFX_Client : BaseStruct
    {
        public tb_ResVFX[] lsData;
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

        public class tb_ResVFX : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public Byte Unkown3;
            public String Unkown4 = "";
            public Byte Unkown5;
            public String Unkown6 = "";
            public Byte Unkown7;
            public Byte Unkown8;
            public Int16 Unkown9;
            public Int16 Unkown10;
            public Int16 Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;

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
