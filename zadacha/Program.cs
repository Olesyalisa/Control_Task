/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на стартевыполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */


System.Console.Write("Enter array strings without commas: ");
string[] GetMassive = (Console.ReadLine().Split());
System.Console.WriteLine("Result array: {0}", String.Join(" ", GetMassive));
System.Console.WriteLine("Soring array elements ");
System.Console.WriteLine("Enter the number of characters with a positive number. Программа создаст массив с заполненными элементами массива и с символами (меньше или равно длины, например = 3)");
int lengthMassive = int.Parse(Console.ReadLine());
string[] SortMass = new string[0];
for (int i = 0, j = 0; i < GetMassive.Length; i++)
{
    if (GetMassive[i].Length <= lengthMassive)
    {
        Array.Resize(ref SortMass, j + 1);
        SortMass[j] = GetMassive[i];
        j++;
    }
}
System.Console.WriteLine("Result: {0}", String.Join(" ", SortMass));

