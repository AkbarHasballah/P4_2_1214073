﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214073
{
    internal class suratke4_1214073 : product_1214073
    {
        public string surah;
        public suratke4_1214073(string title, string surah)
        {
            this.MyType = "surat ke keempat dalam alquran";
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
