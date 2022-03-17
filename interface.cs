using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
   
      public interface IMeyve //meyvelerle ilgili bilgileri classlarda kullanabilmek için meyve adında interface oluşturuldu
        {
           public double agirlik { get; set; }
           public double verim { get; set; }

        }
    
}
