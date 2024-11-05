using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day1
{
    public class CountWord
    {
        public int WordCount(string text, string wordToCount)
        {

            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(wordToCount))
            {
                return 0;
            }
            int count = 0;
            int index = text.IndexOf(wordToCount, StringComparison.OrdinalIgnoreCase);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(wordToCount, index + wordToCount.ToLower().Length, StringComparison.OrdinalIgnoreCase);
            }

            return count;
        }
    }

}