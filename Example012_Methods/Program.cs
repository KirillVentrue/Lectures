//Method1
// void Metod1()
// {
//     Console.WriteLine("Автор …"); 
// }

//Method2
// void Metod2(string msg)
// { 
//     Console.WriteLine(msg);
// } 
// Metod2("Текст сообщения");

// void Metod21(string msg, int count)
// {
//      int i = 0; 
//      while (i < count)
//     { 
//     Console.WriteLine(msg);
//     i++; 
//     } 
// Metod2("Текст", 4);
// }

//Method3
// int Metod3()
// {
//     return DataTime.Now.Year;
// } 
//     int year = Metod3();
// Console.WriteLine(year);

//Method4
// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
    
//     while (i<count)
//     { 
//         result = result + text; 
//         i++;
//     } 
//     return result;
// } 
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);

//Цикл for
// string Metod4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i<count; i++)
//     { 
//         result = result + text; 
//     } 
// return result; 
// } 
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);

// Цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     } 
//     Console.WriteLine(); 
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” маленькими “с”. 
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
    
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

//Упорядочить массивы
// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }    
// PrintArray(arr);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);