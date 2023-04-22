using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examin_maksimov
{
    public class Tec_DataBase
    {
        internal List<Technics> tecs { get; private set; }

        public void InInitialize()
        {
            tecs = new List<Technics>()
            {
                new Technics("комп", 100000, 3),
                new Technics("принетер", 5000, 1),
                new Technics("сканер", 15000, 5),
            };
        }
    }
}
