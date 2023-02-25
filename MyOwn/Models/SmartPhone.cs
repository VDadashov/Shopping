using MyOwn.Enums;
using MyOwn.MainProduct;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyOwn.Models
{
    internal class SmartPhone : Product
    {
        #region Field

        public TypeColorSP Color;
        byte  _ram;
        public TypeOPSP OperatingSystem;
        byte _simCardCount;

        #endregion

        #region Propertys

        public byte RAM
        {
            get { return _ram; }
            set
            {
                if (value <= 32)
                    _ram = value;
            }
        }

        public byte SimCardCount
        {
            get { return _simCardCount; }
            set
            {
                if (value <= 2)
                {
                    _simCardCount = value;
                }
            }
        }
            #endregion

       
    
    }
}
