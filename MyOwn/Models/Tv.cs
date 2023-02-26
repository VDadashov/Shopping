using MyOwn.MainProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwn.Models
{
    internal class Tv:Product
    {
        public byte ScreenDiagonal;
        public bool SmartTv = false;
        public bool VoiceControl = false;
    }
}
