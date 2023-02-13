// Собрать строку с числами от а до b, при условии a <= b.



// обычный итеративный способ

string res = NumberFor(2, 12);
Console.WriteLine(res);

string NumberFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// рекурсионный способ

string resRecursion = NumberForRecursion(2, 25);
Console.WriteLine(resRecursion);

string NumberForRecursion(int a, int b)
{
    if (a <= b) return $"{a} " + NumberForRecursion(a + 1, b);
    else return String.Empty;
}



//собираем строку от a до b при условии, что a >= b

string resRecursion2 = NumberForRecursion2(25, 2);
Console.WriteLine(resRecursion2);

string NumberForRecursion2(int a, int b)
{
    if (a >= b) return $"{a} "  +  NumberForRecursion2(a - 1, b);
    else return String.Empty;
}