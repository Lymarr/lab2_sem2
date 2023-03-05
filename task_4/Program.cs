using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> strings = new List<string>
        {
            "Мене звати Олена",
            "Я студентка",
            "Я вчуся на 2 курсi",
            "Я вивчаю iнженерiю програмного забезпечення",
            "Я маю таку дисциплiну, як ООП",
            "Менi подобається ця дисциплiна"
        };

        Func<string, int> stringLengthDelegate = l => l.Length;

        foreach (string l in strings)
        {
            int length = stringLengthDelegate(l);
            Console.WriteLine($"Довжина рядку '{l}' дорiвнює {length}");
        }
    }
}
