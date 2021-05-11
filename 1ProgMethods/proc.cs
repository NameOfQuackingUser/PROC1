using System;
using System.IO;

struct proc
{
    public proc(string[] data)
    {
        this.isAbstract = bool.Parse(data[2]); 
    }

    bool isAbstract;
    public void Print(StreamWriter writer)
    {
        writer.WriteLine("\tType: Procedural\tAbstract classes: {0}", isAbstract);
    }
}