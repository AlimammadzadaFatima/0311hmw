using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Check
    {
        public bool HasDigit(string word)
        {
            bool has = false;
            foreach (var item in word)
            {
                if (char.IsDigit(item))
                {
                    has = true;
                }
            }
            return has;
        }
        public bool HasUpper(string word)
        {
            bool has = false;
            foreach (var item in word)
            {
                if (char.IsUpper(item))
                {
                    has = true;
                }
            }
            return has;
        }
        public bool HasLower(string word)
        {
            bool has = false;
            foreach (var item in word)
            {
                if (char.IsLower(item))
                {
                    has = true;
                }
            }
            return has;
        }
    }
}
