# Iterator
Ідея ітератора: 

Ітератор дозволяє послідовно перебирати об’єкти без розкриття їх внутрішньої структури.

Як працює код: 

Ми можемо просто “перебирати” квіти, не знаючи, як вони зберігаються — у списку, масиві чи базі.

Навіщо: 

зручно працювати з будь-якими колекціями однаково.

## Код
```csharp
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

```
## Результат
![Результат виконання](sc15.png)
