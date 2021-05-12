using System;
using System.IO;

struct lang
{
    int year;
    int timesSearched;

    proc procElem;
    oop oopElem;
    FunctionalLang functionalElem;
    int elem;

    public void In(StreamReader reader)
    {
        try
        {

            string[] tmp = reader.ReadLine().Split(' ');
            year = int.Parse(tmp[1]);
            timesSearched = int.Parse(tmp[2]);

            elem = int.Parse(tmp[0]);
            switch (elem)
            {
                case 0: procElem = new proc(tmp); break;
                case 1: oopElem = new oop(tmp); break;
                case 2: functionalElem = new FunctionalLang(tmp); break;
                default: break;
            }
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    }
    public int HowOldIsLang()
    {
        return DateTime.Now.Year - year;
    }

    public void Print(StreamWriter writer, int filter)
    {
        try
        {
            if (filter != elem && filter > -1)
            {
                writer.Write("\n");
                return;
            }

            writer.Write("Development year: {0}\tTimes searched: {1}\tAgeOfLang: {2}\t", year, timesSearched, HowOldIsLang());


            switch (elem)
            {
                case 0: procElem.Print(writer); break;
                case 1: oopElem.Print(writer); break;
                case 2: functionalElem.Print(writer); break;
                default: break;
            }
        }catch(Exception ex)
        {
            writer.Write("ERROR\n");
        }

        
        
        
    }
}