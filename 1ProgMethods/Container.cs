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
    public void Print(StreamWriter writer, int filter)
    {
        for(int i=0;i<langs.Count;i++)
        {
            writer.Write("Id: {0}\t", i);
            langs[i].Print(writer, filter);
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

}