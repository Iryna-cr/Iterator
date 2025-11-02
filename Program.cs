using System;
using System.Collections.Generic;

class FlowerCollection
{
    private List<string> flowers = new List<string>() { "Троянда", "Тюльпан", "Ромашка" };
    public IEnumerable<string> GetFlowers() => flowers;
}

class Program
{
    static void Main()
    {
        var collection = new FlowerCollection();
        foreach (var f in collection.GetFlowers())
            Console.WriteLine(f);
    }
}










