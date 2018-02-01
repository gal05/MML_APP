using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MML_APP.Metodos
{
    public class Metodos
    {

        public static string toAscii(string va)
        {
            string s = va.ToLower();
            byte[] by = Encoding.ASCII.GetBytes(s);
            string[] salida = new string[by.Length];


                for(int i = 0; i < by.Length; i++)
            {
                int d = by[i] - 20;
                char ca = (char)d;
                string tex = ca.ToString();
                salida[i] = tex;
            }
                


            string result = string.Concat(salida);

            //int d = by[1] - 20;



            return result;
        }

    }


}