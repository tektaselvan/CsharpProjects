using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drawCircle
{
    public class Daire
    {
        private double yaricap;
        public Daire (double yaricap){
            this.yaricap = yaricap;
        }

        public string[][] DaireyiOlustur(){
            int boyut = (int)(2 * yaricap);
            string[][] daireMatris = new string[boyut][];

            for (int i = 0; i < boyut; i++)
            {
                daireMatris[i] = new string[boyut];

                for (int j = 0; j < boyut; j++)
                {
                   double uzaklikMerkez = Math.Sqrt(Math.Pow((i - yaricap), 2) + Math.Pow((j - yaricap), 2));
                    if(uzaklikMerkez < yaricap){
                        daireMatris[i][j] = "*";

                    }
                    else{
                        daireMatris[i][j] = " ";
                    }
                }
            }
            return daireMatris;
        }
    }
}