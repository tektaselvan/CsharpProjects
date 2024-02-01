using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drawCircle
{
    public class Dairecizici
    {
        public void DaireCiz(double yaricap){
          Daire daire = new Daire(yaricap);
          string [][] daireMatris = daire.DaireyiOlustur();
          for (int i = 0; i < daireMatris.Length; i++)
          {
            for (int j = 0; j < daireMatris[i].Length; j++)
            {
                Console.WriteLine(daireMatris[i][j]);
            }
            Console.WriteLine();
          }

        }
    }
}