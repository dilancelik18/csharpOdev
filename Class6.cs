﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    class mandalina : Meyve // mandalina classını meyve classından miras alarak oluşturduk
    {
        public double agirlik;
        public double verim;

        public mandalina()
        {

            Random rnd = new Random();
            agirlik = rnd.Next(70, 120);

            Random rst = new Random();
            double yuz = rst.Next(30, 70);
            double yuzde = yuz / 100;
            verim = agirlik * yuzde;


        }
    }
}
