namespace HelloWorld
{
    class Program
    {
        //Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0
        //ввел пользователь
        //0,7,8,-2-2->2
        //1,-7,567,89,223->3        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            int[] rowofNumber = new int[rowLength];
            int numberAboveZero = ManualFillArray(rowofNumber);
            Console.Write("Чисел в ряду: ");
            Console.WriteLine();
            Console.WriteLine($"Количество чисел больше нуля равно {numberAboveZero}");            
        }
        public static int ManualFillArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 0)
                {
                    count += 1;
                }
            }
            return count;
        }
        public static void PrintArray(int[] incomingArray, int index)
        {
            if(index == incomingArray.Length)
            {
                return;
            }
            Console.Write(incomingArray[index]);
            Console.Write(", ");
            PrintArray(incomingArray, index + 1);
        }
    }
}   
        