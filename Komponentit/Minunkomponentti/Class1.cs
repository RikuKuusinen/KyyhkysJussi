using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Minunkomponentti
{
    public class Class1
    {
        public string Ping()
        {
            string formatStr =
            @"Metodi, jota kutsuit on: {0}
            Se on luokassa: {1}
            Luokka on assemblyssä (koko nimi): {2}
            Assembly on ladattu hevostiedostosta:
            {3}";
            //apumuuttujat tietojen keräämiseen

            MethodBase metodi = new StackFrame().GetMethod();
            Type tyyppi = GetType();
            Assembly asmbly = Assembly.GetExecutingAssembly();
            return string.Format(formatStr,
            metodi.Name,
            tyyppi.FullName,
            asmbly.FullName,
            asmbly.Location);
        }
    }
}
