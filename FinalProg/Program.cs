// Написать прогромму, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

namespace FinalTask
{
    class program
    {
        public static void Main(string[] args)
        {
            string[] FirstArray = new string[7] { "1234", "444", "-2", ":-)", "world", "dota2", "Russia" };
            string[] SecondArray = new string[FirstArray.Length];
            
            ModifiedSecondArray(FirstArray, SecondArray);
            PrintArray(SecondArray);
        }
        static void ModifiedSecondArray(string[] FirstArray, string[] SecondArray)
            {
                int count = 0;
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    if (FirstArray[i].Length <= 3)
                    {
                        SecondArray[count] = FirstArray[i];
                        count++;
                    }
                }
            }
           static void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
    }
}