﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinasAlgorithms
{
    internal class WordSkipCounter
    {
        public int TimedReading(int MaxLength, string text)
        {
            int count = 0;
            string[] words = text.Split(' ', ',', '.', ';', ':', '!', '?', '\'', '"');
            foreach (string word in words)
            {
                if (word.Length >= 1 && word.Length <= MaxLength)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
