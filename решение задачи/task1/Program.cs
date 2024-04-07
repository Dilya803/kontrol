//Написать программу, которая из имеющегося массива строк формирует новый 
//массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать 
//на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.




string[] mas1 = new string[7] {"1234", "-23", "Hello", "world", "res", "Russia", "computer science"};
string[] mas2 = new string[mas1.Length];

void SecondArrayWithIF(string[] mas1, string[] mas2)
{
    int count = 0;
    for (int i = 0; i < mas1.Length; i++)
    {
    if(mas1[i].Length <= 3)
        {
        mas2[count] = mas1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(mas1, mas2);
PrintArray(mas2);
