/*Задача: Регистрация пассажиров на самолёт. Самолёт делиться на сектора. У секторов формально не будет названий. Будет порядковый номер сетора и количество мест внутри сектора*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 15, 17 }; //Каждый элемент массива озночает количество мест в одном секторе;
            bool isOpen = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                for(int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе свободно {i + 1} свободно {sectors[i]} мест.");
                }
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1 - забронировать места\n2 - выход из программы\n");
                Console.WriteLine("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите лететь? ");
                        userSector =Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неаерное количество мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секеторе {userSector} недостаточно мест. Осталось {sectors[userSector]} мест.  ");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
