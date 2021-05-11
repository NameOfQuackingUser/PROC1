using System;
using System.IO;

struct oop
{
    enum inher { SINGLE, MULTIPLE, INTERFACE };
    public oop(string[] data)
    {
        this.i = (inher)int.Parse(data[2]);
    } 
    inher i;

    public void Print(StreamWriter writer)
    {
        writer.WriteLine("\tType: Object-oriented\tInheritance: {0}", i);
    }

}