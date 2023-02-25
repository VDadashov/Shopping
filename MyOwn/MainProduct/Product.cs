using MyOwn.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyOwn.MainProduct
{
    internal abstract class Product
    {
        #region Field
        public static TypeCategory Category;
        public string Model;
        double _price;
        double _disCountPercent;
        
        #endregion

        #region Propertys
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public double DisCountPercent
        {
            get { return _disCountPercent; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _disCountPercent = value;
                }
            }
        }
        #endregion

        #region CheckMethod
        #endregion


    }
}
