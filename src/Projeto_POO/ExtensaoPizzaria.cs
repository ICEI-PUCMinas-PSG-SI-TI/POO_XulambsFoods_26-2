using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public static class ExtensaoPizzaria
    {
        public static double Valor (this EBorda borda)
        {
            double valorBorda = 0;
            switch (borda)
            {
                case EBorda.Chocolate:
                    valorBorda = 8;
                    break;
                case EBorda.Cheddar:
                    valorBorda = 10;
                    break;
                case EBorda.Requeijao:
                    valorBorda = 7;
                    break;

            }
            return valorBorda;
        }
    }
}
