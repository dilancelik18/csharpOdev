using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    class çilek: Meyve // çilek classını meyve classından miras alarak oluşturduk
    {
        public double agirlik;
        public double verim;
        public çilek()
        {
            Random rnd = new Random();
            agirlik = rnd.Next(70, 120);
            Random rst = new Random();
            double yuzde = rst.Next(80, 95);
            verim = agirlik * (yuzde / 100);
        }
    }
}
