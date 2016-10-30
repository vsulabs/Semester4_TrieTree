using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieTree
{
    class Utiles
    {
        public const int AlphabetMax = 33;
        public const int firstLitera = (int)'а';

        static public bool CheckWord(string wrd)
        {
            wrd.ToLower();
            bool res = true;
            for (int i = 0; i < wrd.Length && res; i++)
                res = wrd[i] > 'а' && wrd[i] < 'я';
            return res;
        }
    }
}
