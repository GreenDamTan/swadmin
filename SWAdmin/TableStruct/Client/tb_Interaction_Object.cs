using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Interaction_Object_Client : BaseStruct
    {
        public tb_Interaction_Object[] lsData;
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

        public class tb_Interaction_Object : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public String Unkown3 = "";
            public Byte Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public String Unkown9 = "";
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public UInt32 Unkown13;
            public UInt32 Unkown14;
            public UInt32 Unkown15;
            public UInt32 Unkown16;
            public UInt32 Unkown17;
            public UInt32 Unkown18;
            public UInt32 Unkown19;
            public Int16 Unkown20;
            public Int16 Unkown21;
            public UInt32 Unkown22;
            public UInt32 Unkown23;
            public Byte Unkown24;
            public UInt32 Unkown25;
            public UInt32 Unkown26;
            public UInt32 Unkown27;
            public UInt32 Unkown28;
            public UInt32 Unkown29;
            public Byte Unkown30;
            public String Unkown31 = "";
            public String Unkown32 = "";
            public String Unkown33 = "";
            public String Unkown34 = "";
            public String Unkown35 = "";
            public String Unkown36 = "";
            public String Unkown37 = "";
            public String Unkown38 = "";
            public String Unkown39 = "";
            public String Unkown40 = "";
            public Single Unkown41;
            public Int16 Unkown42;
            public Int16 Unkown43;
            public Int16 Unkown44;
            public Int16 Unkown45;
            public Int16 Unkown46;
            public Int16 Unkown47;


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
