using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214073
{
    internal class suratke6_1214073 : product_1214073
    {
        public string surah;
        public suratke6_1214073(string title, string surah)
        {
            this.MyType = "surat ke enam dalam alquran";
            this.MyTitle = title;
            this.surah = surah;
        }
        public string surat
        {
            get { return surah; }
            set { surah = value; }
        }
    }
}
