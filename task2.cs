// See https://aka.ms/new-console-template for more information
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
internal class Program2
{
        private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*int read () {   
            return Convert.ToInt32(Console.ReadLine());
            принимает любое число входящее в int32
        }*/
        int b = threeDigitNumber();

        Console.WriteLine($"Это успех вы совершенно уникальны своим гением ииии ваша награда: {b} -> " +  getThirdNumber(b));
    }

    static int threeDigitNumber() // Принимаем сттроку, проверяем количество символов, пытаемся конвертировать, проверяем на 000, 001...
        //если все ок получаем число
        {
            int b = 0;
            while (true) {
                String a = Console.ReadLine();
                try{  
                    if (a.Length >= 3) {
                        b = Convert.ToInt32(a);
                        return b;
                    } else {
                        Console.WriteLine($"{a} -> третьей цифры нет");
                        continue;
                    }
                } catch {
                    Console.WriteLine("Вы ввели не число " + '\n' + "Попробуйте ввести 3ех значное число");
                } 
                
            }
        }
        static int getThirdNumber(int a) {
            while( a >= 1000) {
            a = a / 10;
            }
            return a % 10;
        }
}