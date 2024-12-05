using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafika
{
    public class Obraz
    {
        public int LiczbaPolubien { get; set; }
        public string UrlObrazka { get; set; }

        public Obraz(string urlObrazka)
        {
            UrlObrazka = urlObrazka;
            LiczbaPolubien = 0;
        }
    }
}
