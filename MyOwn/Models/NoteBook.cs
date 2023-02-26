using MyOwn.Enums;
using MyOwn.MainProduct;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace MyOwn.Models
{
    internal class NoteBook:Product
    {

        #region Fields
        public TypeColorNT Color;
        string _processor;
        string _videoCard;
        public byte SSD;
        #endregion

        #region Propertys

        public string Processor
        {
            get { return _processor; }
            set 
            { 
                if (CheckProcessor(value))
                {
                    _processor = value;
                }
            }
        }

        public string VideoCard
        {
            get { return _videoCard; }
            set
            {
                if (CheckVideoCard(value))
                {
                    _videoCard = value;
                }
            }
        }
        #endregion

        #region CheckMethod

        public static bool CheckProcessor(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            if (value.Length != 2) return false;

            if (!char.IsLetter(value[0]) || (value[0] != 'i' && value[0] != 'I')) return false;

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] != '7' && value[i] != '5' && value[i] != '3')
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckVideoCard(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            if (value.Length != 7 && value.Length != 6) return false;

            if (value[0] != 'G' || value[1] != 'T' || value[2] != 'X') return false;

            for (int i = 3; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion







    }
}
