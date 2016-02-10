using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceFormatter
{
    class ClassPrice
    {
        private double price;


        public ClassPrice()
        {
            this.price = 0;
        }

        public ClassPrice(double price)
        {
            this.price = price;
        }
        
        public double GetPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            String strPrice = " " + this.price; // пустоой строкага енгиздим
            int cnt = 0;
            for (int i = 0; i < strPrice.Length; i++)
            {
                cnt++;
                if ((strPrice - cnt) % 3 == 0)
                {
                    p = strPrice.Insert(i, " ");
                }
            }
        
            return price + "тг";
        }

        public static ClassPrice operator +(ClassPrice left, ClassPrice right)
        {
            return new ClassPrice(left.price + right.price);
        }
    }
}
