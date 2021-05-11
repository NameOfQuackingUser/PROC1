using _1ProgMethods;
using System;
using System.Collections.Generic;
using System.IO;
struct Container
{
    private static List<lang> langs = new List<lang>();

    public void In(StreamReader reader)
    {
        while (!reader.EndOfStream)
        {
            lang l = new lang();
            l.In(reader);
            langs.Add(l);
        }
    }
    public void Print(StreamWriter writer)
    {
        for(int i=0;i<langs.Count;i++)
        {
            writer.Write("Id: {0}\t", i);
            langs[i].Print(writer);
        }
    }
    public void Clear()
    {
        langs.Clear();
    }

    public int Count()
    {
        return langs.Count;
    }

    public void Sort()
    {
        
        for (int i = 0; i < langs.Count - 1; i++)
            for (int j = i + 1; j < langs.Count; j++)
                if (Age.Compare(langs[i], langs[j]))
                {
                    lang t = langs[i];
                    langs[i] = langs[j];
                    langs[j] = t;
                }
    }

}