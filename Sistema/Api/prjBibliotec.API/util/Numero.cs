using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjBibliotec.API.util
{
    public class Numero
    {
        public static bool ehNumero(string obj)
        {
            try
            {
                long.Parse(obj);
                return true;
            }
            catch
            { 
                return false;
            }
        }
    }
}