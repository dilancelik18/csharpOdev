using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    class elma : Meyve // elma classını meyve classından miras alarak oluşturduk
    {
        public double agirlik;
        public double verim;

        public elma() 
        {

            Random rnd = new Random();
            agirlik = rnd.Next(70, 120);
           
            Random rst = new Random();
                double yuz = rst.Next(80, 95);
            double yuzde = yuz / 100;
                 verim = agirlik * yuzde ;
                
            
        }
    }

}
