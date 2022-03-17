using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    class Meyve : IMeyve //IMeyve den alınan bilgileri classlarda kullanabilecek hale getirdik
    {
        double IMeyve.verim { get; set ; }

        double IMeyve.agirlik { get ; set ; }
       

      
        
    }

}
