using System;
using System.Collections.Generic;
using System.IO;

namespace CSVParser
{
    static public class CsvReader
    {
        static public string[][] ReadAllLines(string path)
        {
            var str = File.ReadAllText(path);
            str = str.Replace("\r\n", "\n");
            var sl = new List<List<string>>();
            sl.Add(new List<string>());
            sl[0].Add("");
            bool esc = false;
            int normal_length = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\"')
                {
                    if ((i + 1 < str.Length) && (str[i + 1] == '\"'))
                    {
                        sl[sl.Count - 1][sl[sl.Count - 1].Count - 1] += str[i];
                        i++;
                    }
                    else
                    {
                        esc = !esc;
                    }
                }
                else
                {
                    if ((str[i] == ';') && (!esc))
                    {
                        sl[sl.Count - 1].Add("");
                    }
                    else
                    {
                        if ((str[i] == '\n') && (!esc))
                        {
                            if (sl.Count == 1)
                            {
                                normal_length = sl[sl.Count - 1].Count;
                            }
                            else
                            {
                                while (sl[sl.Count - 1].Count < normal_length)
                                {
                                    (sl[sl.Count - 1]).Add("");
                                }
                                if (sl[sl.Count - 1].Count > normal_length)
                                {
                                    throw new FormatException("Lines should be" +
                                        " as wide as head lines, can not parse " +
                                        path + " as CSV table");
                                }
                            }
                            sl.Add(new List<string>());
                            sl[sl.Count - 1].Add("");
                        }
                        else
                        {
                            sl[sl.Count - 1][sl[sl.Count - 1].Count - 1] += str[i];
                        }
                    }
                }
            }
            if (esc)
            {
                throw new FormatException("Escape sequence not finished: opening \"" +
                    " before EOF, can not parse " + path + " as CSV table");
            }
            return sl.ConvertAll(l => l.ToArray()).ToArray();
        }
    }
}
