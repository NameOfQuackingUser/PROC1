using System;
using System.IO;

struct FunctionalLang
{
    public FunctionalLang(string[] data)
    {
        this.typ = (typization)int.Parse(data[2]);
        this.lazyCalc = bool.Parse(data[3]);
    }
    enum typization { strict, dynamic };
    typization typ;
    bool lazyCalc;
    public void Print(StreamWriter writer)
    {
        writer.WriteLine("\tType: Functional\tTypization: {0}\tLazy calculations: {1}", typ, lazyCalc);
    }
}