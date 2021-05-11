using System;
using System.IO;

struct lang
{
    int year;

    proc procElem;
    oop oopElem;
    int elem;

    public void In(StreamReader reader)
    {
        string[] tmp = reader.ReadLine().Split(' ');
        year = int.Parse(tmp[1]);

        elem = int.Parse(tmp[0]);
        switch (elem)
        {
            case 0: procElem = new proc(tmp); break;
            case 1: oopElem = new oop(tmp); break;
            default: break;
        }
    }

    public void Print(StreamWriter writer)
    {
        writer.Write("Development year: {0}\t", year);
        switch (elem)
        {
            case 0: procElem.Print(writer); break;
            case 1: oopElem.Print(writer); break;
            default: break;
        }
        
        
    }
}