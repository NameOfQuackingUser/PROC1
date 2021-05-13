using System;
using System.IO;

struct oop
{
    enum inher { SINGLE, MULTIPLE, INTERFACE };
    public oop(string[] data)
    {
        if (int.Parse(data[3]) > 3)
            throw new IndexOutOfRangeException();
        this.i = int.Parse(data[3]);
    } 
    int i;

    public void Print(StreamWriter writer)
    {
        
        writer.WriteLine("\tType: Object-oriented\tInheritance: {0}", (inher)i);
    }

}