using System;
using System.IO;

struct FunctionalLang
{
    public FunctionalLang(string[] data)
    {
        if (int.Parse(data[3]) > 2)
            throw new IndexOutOfRangeException();
        this.typ = (typization)int.Parse(data[3]);
        this.lazyCalc = bool.Parse(data[4]);
    }
    enum typization { strict, dynamic };
    typization typ;
    bool lazyCalc;
    public void Print(StreamWriter writer)
    {
        writer.WriteLine("\tType: Functional\tTypization: {0}\tLazy calculations: {1}", typ, lazyCalc);
    }
}