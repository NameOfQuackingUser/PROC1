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

    public void Multimethod(StreamWriter writer)
    {
        for(int i = 0; i < langs.Count; i++)
            for(int j = i + 1; j < langs.Count; j++)
            {
                if (i == j)
                    continue;
                switch (langs[i].GetElem())
                {
                    case 0:
                        switch (langs[j].GetElem())
                        {
                            case 0: writer.WriteLine("proc & proc"); break;
                            case 1: writer.WriteLine("proc & oop"); break;
                        }
                        break;
                    case 1:
                        switch (langs[j].GetElem())
                        {
                            case 0: writer.WriteLine("oop & proc"); break;
                            case 1: writer.WriteLine("oop & oop"); break;
                        }
                        break;
                    

                }

            }
    }

}