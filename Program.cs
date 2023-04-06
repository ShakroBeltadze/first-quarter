// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




//string[] ArrayWords = { "hello", "2", "world", ":-)" };

//string[] ArrayWords = { "1234", "1567", "-2", "computer science" };

string[] ArrayWords = { "Russia", "DEnmark", "Kazan", "A"};


void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Console.Write(Array[i]+"   ");
    }
}

string[] NewArray(string[] Array)
{
    string[] ArrayNew = new string[Array.GetLength(0)];
    int j=0; 
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (Array[i].Length<=3)
        {
            ArrayNew[j]=Array[i];
            j++;
        }
    }
    return ArrayNew;
}


PrintArray(ArrayWords);

Console.WriteLine("\n");

PrintArray(NewArray(ArrayWords));