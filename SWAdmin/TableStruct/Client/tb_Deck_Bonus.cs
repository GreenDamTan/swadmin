using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Deck_Bonus_Client : BaseStruct
    {
        public tb_Deck_Bonus[] lsData;
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

        public class tb_Deck_Bonus : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public Byte Unkown3;
            public UInt16 Unkown4;
            public Byte Unkown5;
            public Single Unkown6;


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