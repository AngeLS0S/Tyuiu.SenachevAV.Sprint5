﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SenachevAV.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '\t', '\n', '\r');
                    foreach (string word in words)
                    {
                        if (word.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count - 1;
        }
    }
}
