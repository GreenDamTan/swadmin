using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_LeagueSkill_Script_Client : BaseStruct
    {
        public tb_LeagueSkill_Script[] lsData;
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

        public class tb_LeagueSkill_Script : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public String Unkown4 = "";
            public String Unkown5 = "";
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
