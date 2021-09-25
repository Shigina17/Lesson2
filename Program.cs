using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Задание №1");
             Console.WriteLine("Тип данных sbyte:\n " + "Значение min: -128\n" + " Значение max: 127");
             Console.WriteLine("Тип данных byte:\n " + "Значение min: 0\n" + " Значение max: 255");
             Console.WriteLine("Тип данных short:\n " + "Значение min: -32768\n" + " Значение max: 32767");
             Console.WriteLine("Тип данных ushort:\n " + "Значение min: 0\n" + " Значение max: 65536");
             Console.WriteLine("Тип данных int:\n " + "Значение min: -2 147 483 648\n" + " Значение max: 2 147 483 647");
             Console.WriteLine("Тип данных uint:\n " + "Значение min: 0\n" + " Значение max: 4 294 967 295");
             Console.WriteLine("Тип данных long:\n " + "Значение min: -2 147 483 648\n" + " Значение max: 2 147 483 647");  
             Console.WriteLine("Тип данных ulong:\n " + "Значение min: 0\n" + " Значение max: 4 294 967 295");
             Console.WriteLine("Тип данных float:\n " + "Значение min: 3,4 * 10^-38\n" + " Значение max: 3,4 * 10^38");
             Console.WriteLine("Тип данных double:\n " + "Значение min: 1,7 * 10^-308\n" + " Значение max: 1,7 * 10^308");
             Console.WriteLine("Тип данных double:\n " + "Значение min: 1,7 * 10^-308\n" + " Значение max: 1,7 * 10^308");
             Console.WriteLine($"Decimal - {Decimal.MinValue} - {Decimal.MaxValue}");


             Console.WriteLine("Задание №2");
             string name, city; 
             byte age; 
             int code;
             Console.WriteLine("Введите ваше имя");
             name = Console.ReadLine();
             Console.WriteLine("Введите название вашего города");
             city = Console.ReadLine();
             Console.WriteLine("Введите ваше возраст");
             age = byte.Parse(Console.ReadLine());
             Console.WriteLine("Введите ваш PIN-CODE");
             code = int.Parse(Console.ReadLine());
             Console.WriteLine($"Имя: {name}\nГород: {city}\nВозраст: {age}\nPIN-CODE: {code}");


             Console.WriteLine("Задание №3");
             string str = "hello world";
             string s = str.ToUpper();
             string t = s.ToLower();
             Console.WriteLine($"Результат: {s}, {t}");


             Console.WriteLine("Задание №4");
             str = Console.ReadLine();
             string substr = Console.ReadLine();
             int j = 0;
             while(true)
            {
                if (str.Contains(substr))
                {
                    int index = str.IndexOf(substr);
                    str = str.Substring(index + substr.Length);
                    j++;
                }
                else break;
            }
            Console.WriteLine($"{j} раз подстрока содержится в строке");
            

            Console.WriteLine("Задание №5");
            Console.WriteLine("Введиет скрость таракана в (км/ч): ");
            double v = double.Parse(Console.ReadLine().Replace(".", ","));
            double v1 = v * 1000 / 3600;
            Console.WriteLine($"Вы получили: {v1}(м/c)"); 

           
            Console.WriteLine("Задание №6");
            Console.WriteLine("Введите текущий возраст отца: ");
            byte ageOfFather, ageOfSon;
            ageOfFather = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите текущий возраст сына: ");
            ageOfSon = byte.Parse(Console.ReadLine());
            int result = ageOfFather - ageOfSon * 2;
            if (result > 0)
            {
                Console.WriteLine($"Через {ageOfFather - ageOfSon * 2} лет отец будет старше сына вдвое");
            }
            else if (result < 0)
            {
                Console.WriteLine($"Столько {ageOfFather > ageOfSon * 2} лет назад отец был старше сына вдвое");
            }
            else
            {
                Console.WriteLine("Возраст сына уже в два раза больше возраста отца");
            }


            Console.WriteLine("Задание №7");
            Console.WriteLine("Введите стоимость одной бутылки: ");
            float normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в %: ");
            float salePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость вашего отпуска: ");
            float holidayPrice = Convert.ToInt32(Console.ReadLine());
            float saving = normPrice * salePrice / 100;
            Console.WriteLine("Необходимо купить " + Math.Floor(holidayPrice / saving));


            Console.WriteLine("Задание для 18.09 Методичка 2.3");
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            char symbol2 = char.ToLower(symbol);
            char Nextsymbol;
            if (symbol2 == 'z')
            {
                Nextsymbol = 'a';
            }
            else
            {
                Nextsymbol = (char)(((int)symbol) + 1);
            }
            Console.WriteLine();
            Console.WriteLine($"{Nextsymbol}");
            Console.ReadLine();
        }
    }
}
