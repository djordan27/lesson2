/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

internal class Program
{
        private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int a = threeDigitNumber();
        Console.WriteLine($"Это успех вы совершенно уникальны своим гением ииии ваша награда: {a} -> " + getSecondNumber(a));
    }

    /*int read () {   
     return Convert.ToInt32(Console.ReadLine());
            принимает любое число входящее в int32
        }*/
    static int threeDigitNumber() // Принимаем сттроку, проверяем количество символов, пытаемся конвертировать, проверяем на 000, 001...
        //если все ок получаем число
        {
            int b = 0;
            while (true) {
                String a = Console.ReadLine();
                try{  
                    if (a.Length == 3) {
                        b = Convert.ToInt32(a);
                        if (b >= 100 && b <= 999 || b <= -100 && b >= -999)
                        {
                            return b;
                        }
                        else
                        {
                            continue;
                        }
                    } else {
                        Console.WriteLine("АААААА! КААААрл!!!");
                    }
                } catch {
                    Console.WriteLine("Вы ввели не число " + '\n' + "Попробуйте ввести 3ех значное число");
                } 
                
            }
        }
        static int getSecondNumber(int a) {
            return (a % 100) / 10;
        }
}