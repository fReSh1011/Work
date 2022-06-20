using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace progect1
{
    class Program
    {
        static void NewGame()
        {
            Random rand = new();                    //Добавляю метод random
            Console.WriteLine("Введите имя персонажа:");
            string Name = Console.ReadLine();       //Ввожу имя персонажа через консоль
            Console.WriteLine("Вы уверены?");
            string Change = Console.ReadLine();     //Спрашиваю уверен ли в выборе имени
            if (Change == "нет")                    //Если нет то происходит это(низ)
            {
                Console.WriteLine("Введите имя персонажа:");
                Name = Console.ReadLine();
            }


            //Инфа про перса
            int HpMax = 100;                        //хп персонажа
            int HPNow = 100;                        //текущее хп персонажа
            int DmgMax = 1;                         //Максимальный урон
            int DmgMin = 1;                         //Минимальный урон
            int ExpNow = 0;                         //Текущий опыт
            int ExpMax = 100;                         //Максимальный опыт
            int Lvl = 1;                         //Текущий уровень
            int MyDmg = 0;                         //Средний урон(случайный в промежутке от Min-Max)
            int Gold = 0;
            int AttackSpeed = 0;

            Console.WriteLine("Ваше имя " + Name);
            Console.WriteLine("Ваш лвл " + Lvl);
            Console.WriteLine("Ваше хп " + HPNow + " из " + HpMax);
            Console.WriteLine("Ваш текущий опыт " + ExpNow + " из " + ExpMax);
            Console.WriteLine("Ваш урон " + DmgMin + "-" + DmgMax);
            Console.WriteLine("У вас золота: " + Gold);
            //Конец инфо про перса

            //Магазин
            bool Shop = false;

            //Конец магаизна


            //Снаряжение
            bool Inventory = false;

            int EquipDurabilityWeapon= 0;
            string EquipNameWeapon = "";
            int EquipDmgMinWeapon = 0;
            int EquipDmgMaxWeapon = 0;
             
            int IdWeapon = 0;
            
            int Сounter = 0;
            int Subjects = 1 ;
            string NameWeapon = "";
            string RareMessage = "";
            int DmgMinWeapon = 0;
            int DmgMaxWeapon = 0;
            int DurabilityWeapon = 0;
            int RareWeapon = 1;


            int CounterWeapon = 1;
            int[,] _ArrayInventory = new int[99, 4];
            string[,] _ArrayInventoryName = new string[99, 1];
            CounterWeapon = 0;
            //Конец снаряжения


            //Монстры
            string NameMob = "";                         //Название монстра
            int HpMaxMob = 0;                         //Максимальные жизни монтра
            int HPNowMob = 0;                         //Текущие жизни монстра
            int DmgMinMob = 0;                         //Минимальный урон монстра
            int DmgMaxMob = 0;                         //Максимальный урон монстра
            int ExpDeadMob = 0;                         //Сколько дают опыта за убийство монстра
            int DmgMob = 0;                         //Средний урон монстра
            int Exp = ExpMax - ExpNow;
            int RandomMob = 0;
            int ChanseDrop = 0;
            int GoldDeadMob = 0;
            int AttackSpeedMob = 0;
            //Конец мострам


            Console.WriteLine("Что будешь делать?");                            //Игрок выберает одно из действий
            Console.WriteLine("1)Пойти на битву Богов");
            Console.WriteLine("2)Открыть инвентарь");
                        

            int Game = Convert.ToInt32(Console.ReadLine());
            switch (Game)
            {
                case 1:                                                             //Начало игры


                    //Кейс с шансем выпадения оружия



                    


                    if (Lvl <= 3)
                    {
                        RandomMob = rand.Next(1, 4);                     //Достает случайного мостра из списка(+1)
                    }
                    else if (Lvl >= 3)
                    {
                        RandomMob = rand.Next(2, 4);
                    }
                    


                    switch (RandomMob)                                                             //Список случайных монтров
                    {
                        case 1:
                            //Павук(Начальный моб(с 1 по 3 лвл))
                            Subjects = rand.Next(1, 2);          //Шанс выпадения оружия
                            NameMob = "Паук";                      //Название монстра
                            HpMaxMob = 1;                         //Максимальные жизни монтра
                            HPNowMob = 1;                         //Текущие жизни монстра
                            DmgMinMob = 1;                         //Минимальный урон монстра
                            DmgMaxMob = 4;                         //Максимальный урон монстраs
                            ExpDeadMob = 50;                         //Сколько дают опыта за убийство монстра

                            //AttackSpeedMob = 1000;

                            GoldDeadMob = rand.Next(0, 15);                   //Сколько падает золота после смерти
                            break;
                        case 2:
                            //Зомби(Начальный моб(с 1 по 3 лвл))
                            Subjects = rand.Next(1, 2);          //Шанс выпадения оружия
                            NameMob = "Зомби";                      //Название монстра
                            HpMaxMob = 13;                         //Максимальные жизни монтра
                            HPNowMob = 13;                         //Текущие жизни монстра
                            DmgMinMob = 1;                         //Минимальный урон монстра
                            DmgMaxMob = 4;                         //Максимальный урон монстраs
                            ExpDeadMob = 35;                         //Сколько дают опыта за убийство монстра

                            //AttackSpeedMob = 1000;

                            GoldDeadMob = rand.Next(0, 20);                   //Сколько падает золота после смерти
                            break;
                        case 3:
                            //Слизьнюк(Начальный моб(с 1 по 3 лвл))
                            Subjects = rand.Next(1, 2);          //Шанс выпадения оружия
                            NameMob = "Слизь";                      //Название монстра
                            HpMaxMob = 10;                         //Максимальные жизни монтра
                            HPNowMob = 10;                         //Текущие жизни монстра
                            DmgMinMob = 2;                         //Минимальный урон монстра
                            DmgMaxMob = 5;                         //Максимальный урон монстраs
                            ExpDeadMob = 27;                         //Сколько дают опыта за убийство монстра

                            //AttackSpeedMob = 1000;

                            GoldDeadMob = rand.Next(0, 26);                   //Сколько падает золота после смерти
                            break;
                        case 10:
                            //Голем(Босс)
                            NameMob = "Каменный голем";
                            HpMaxMob = 100;
                            HPNowMob = 100;
                            DmgMinMob = 1;
                            DmgMaxMob = 5;
                            ExpDeadMob = 25;
                            Subjects = rand.Next(1, 2);          //Шанс выпадения оружия
                            break;
                    }


                    switch (Subjects)                                                             //Дроп предметов 
                    {
                        case 1:
                            IdWeapon = 1;
                            CounterWeapon++;
                            NameWeapon = "Деревянный меч";
                            DmgMinWeapon = 1;
                            DmgMaxWeapon = 2;
                            RareWeapon = rand.Next(1, 101);
                            DurabilityWeapon = 25;
                            break;
                        case 2:
                            IdWeapon = 2;
                            CounterWeapon++;
                            NameWeapon = "Железный меч";
                            DmgMinWeapon = 3;
                            DmgMaxWeapon = 9;
                            DurabilityWeapon = 50;
                            break;
                        case 3:
                            IdWeapon = 3;
                            CounterWeapon++;
                            NameWeapon = "";
                            DmgMinWeapon = 1;
                            DmgMaxWeapon = 2;
                            DurabilityWeapon = 5;
                            break;

                    }


                    //Битва с монстрами

                    while (HPNowMob >= 0)                                                             //Пока монстр не умер происходит цикл
                    {
                        Console.Clear();



                        EquipDurabilityWeapon--;

                        MyDmg = rand.Next(DmgMin, DmgMax);                                                             //Случайный урон героя

                        DmgMob = rand.Next(DmgMinMob, DmgMaxMob);                                                             //Случайный урон монстра

                        

                        HPNowMob -= MyDmg;                                                             //Уменьшение хп монстра

                        if (HPNowMob <= 0)
                        {
                            HPNowMob = 0;
                        }

                        HPNow -= DmgMob;                                                             //Уменьшение моего хп

                        if (HPNow <= 0)
                        {
                            HPNow = 0;
                        }

                        Console.WriteLine("{0,-20} {1,0}", "Информация о " + NameMob, "| Информация о " + Name);
                        Console.WriteLine("{0,-20} {1,0}", "Всего HP: " + HpMaxMob, "| Всего HP: " + HpMax + " Ваш лвл " + Lvl);
                        Console.WriteLine("{0,-20} {1,0}", "Урон: " + DmgMinMob + "-" + DmgMaxMob, "| Урон: " + DmgMin + "-" + DmgMax);

                        Console.WriteLine(Name + " нанес " + MyDmg + " урона\nУ " + NameMob + " осталось " + HPNowMob + "HP");
                        Console.WriteLine(NameMob + " нанес " + DmgMob + " урона\nУ " + Name + " осталось " + HPNow + "HP\n");

                        if (EquipDurabilityWeapon == 0)                         //Если предмет сломался
                        {
                            Console.WriteLine("У " + Name + " сломался " + EquipNameWeapon);
                            DmgMin -= EquipDmgMinWeapon;
                            DmgMax -= EquipDmgMaxWeapon;
                        }

                        if (HPNow <= 0)                                                             //Если герой умер
                        {
                            Console.WriteLine("Какая жалость!!! Ты проиграл\n");
                            Console.WriteLine("\nЧто будешь делать дальше?");
                            Console.WriteLine("1)Начать сначала");
                            Console.WriteLine("2)Начать сначала");
                            Console.WriteLine("3)Выйти из игры :(");
                            string reset = Console.ReadLine();                  //Рестрат
                            int Reset = Convert.ToInt32(reset);
                            if (Reset == 1)
                            {
                                Program.NewGame();
                            }
                            else if (Reset == 2)
                            {
                                Environment.Exit(0);
                            }
                            else if (Reset == 3)
                            {
                                Environment.Exit(0);
                            }
                            break;
                        }

                        if (HPNowMob <= 0)                                                             //Если монстр умер
                        {

                            if (RareWeapon >= 50 && RareWeapon <= 75)
                            {
                                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                                RareMessage = "необычный ";
                            }
                            else if (RareWeapon >= 76 && RareWeapon <= 90)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
                                RareMessage = "редкий ";
                            }
                            else if (RareWeapon >= 91 && RareWeapon <= 99)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет
                                RareMessage = "эпический ";
                            }
                            else if (RareWeapon == 100)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
                                RareMessage = "ЛЕГЕНДАРЫНЙ ";
                            }

                            _ArrayInventoryName[CounterWeapon, 0] = RareMessage;
                            _ArrayInventoryName[CounterWeapon, 1] = NameWeapon;

                            _ArrayInventory[CounterWeapon, 0] = IdWeapon;
                            _ArrayInventory[CounterWeapon, 1] = DmgMinWeapon;
                            _ArrayInventory[CounterWeapon, 2] = DmgMaxWeapon;
                            _ArrayInventory[CounterWeapon, 3] = DurabilityWeapon;


                            Gold += GoldDeadMob;                                                              //Добавляет золото за убийство моба
                            ExpNow += ExpDeadMob;                                                             //Добавляет ЕХР за убийство моба
                            if (Subjects == 1)                                                             //Дроп с монстра
                            {
                                Console.WriteLine("Поздравляю вам упал "+ RareMessage + NameWeapon);
                            }
                            else if (Subjects == 2)
                            {
                                Console.WriteLine("Поздравляю вам упал " + NameWeapon);
                            }
                            Console.ResetColor(); // сбрасываем в стандартный
                            Console.WriteLine(Name + " получил " + ExpDeadMob + " EXP\n" + "Вы получили " + GoldDeadMob + " золота");
                            if (ExpNow >= ExpMax)                                                             //LVL UP!
                            {
                                ExpMax *= 2;                                                             //Увеличение опыта до LVLUP
                                Lvl++;                                                             //Добавление уровня
                                HpMax += 10;                                                             //+ХП за LVLUP
                                DmgMin++;                                                             //+МинУрон за LVLUP
                                DmgMax += 2;                                                             //+МаксУрон за LVLUP
                                HPNow = HpMax;                                                             //Полное излечение после LVL Up
                                Console.WriteLine("Вы подняли уровень! \n Теперь ваш уровень " + Lvl);
                                Console.WriteLine("До следующего уровня осталось " + (ExpMax - ExpNow));
                            }
                            Console.WriteLine("Что будешь делать?");
                            Console.WriteLine("1)Пойти на битву Богов");
                            Console.WriteLine("2)Открыть инвентарь");
                            break;
                        }

                        Console.WriteLine("\nЧто будешь делать дальше?");
                        Console.WriteLine("1)Атаковать");
                        Console.WriteLine("2)Открыть инвентарь");
                        Console.WriteLine("3)Убежать с поля боя");

                        

                        int Battle = Convert.ToInt32(Console.ReadLine());
                        if (Battle == 2)
                        {
                            Console.WriteLine("Вы зашли в инвентарь:");
                            Console.WriteLine("Ваше имя " + Name);
                            Console.WriteLine("Ваш лвл " + Lvl);
                            Console.WriteLine("Ваше хп " + HPNow + " из " + HpMax);
                            Console.WriteLine("Ваш текущий опыт " + ExpNow + " из " + ExpMax);
                            Console.WriteLine("Ваш урон " + DmgMin + "-" + DmgMax);
                            Console.WriteLine("У вас золота: " + Gold);

                            Console.WriteLine("В вашем инвентаре есть:");

                            /*
                            while (Сounter >= СounterWeapon)
                            {
                                Console.WriteLine("Название предмета: " + NameWeapon + "\nУрон: " + DmgMinWeapon + "-" + DmgMaxWeapon + "\nПрочность: " + DurabilityWeapon);
                                Сounter++;
                            }
                            */

                            while (Сounter >= CounterWeapon)
                            {
                                int[][] _inventory = new int[CounterWeapon][];
                            }
                        }


                        

                    }
                    
                    
                    




                    Console.WriteLine(ExpNow);                                               
                    int Jump = Convert.ToInt32(Console.ReadLine());                                     //Переход между кейсами  
                    Console.Clear();
                    if (Jump == 1)
                    {
                        goto case 1;
                    }
                    else if (Jump == 2)
                    {
                        Inventory = true;
                    }
                    if (Inventory == true)                                      //Инвентарь
                    {
                        Console.WriteLine("Вы зашли в инвентарь:");
                        Console.WriteLine("Ваше имя " + Name);
                        Console.WriteLine("Ваш лвл " + Lvl);
                        Console.WriteLine("Ваше хп " + HPNow + " из " + HpMax);
                        Console.WriteLine("Ваш текущий опыт " + ExpNow + " из " + ExpMax);
                        Console.WriteLine("Ваш урон " + DmgMin + "-" + DmgMax);
                        Console.WriteLine("У вас золота: " + Gold);

                        Console.WriteLine("В вашем инвентаре есть:\n");
                        int Count = 0;
                        while (Count <= CounterWeapon)
                        {
                            Console.WriteLine(Count + ") " + "Название предмета: " + _ArrayInventoryName[Count, 0] + "\nУрон: " + _ArrayInventory[Count, 1] + "-" + _ArrayInventory[Count, 2] + "\nПрочность: " + _ArrayInventory[Count, 3]);
                            
                            Count++;
                        }

                        Console.WriteLine("\nЧто будешь делать?");
                        Console.WriteLine("1)Пойти на битву Богов");
                        Console.WriteLine("2)Открыть магазин");
                        Console.WriteLine("3)Надеть/использовать предмет");
                        Jump = Convert.ToInt32(Console.ReadLine());                                     //Переход между кейсами  

                        if (Jump == 1)
                        {
                            Console.Clear();
                            goto case 1;
                        }
                        else if (Jump == 2)
                        {
                            Console.Clear();
                            Shop = true;
                        }
                        else if (Jump == 3)
                        {
                            Console.WriteLine("Напишиет номер предмета который хотите использовать");
                            int Select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Вы одели/использовали " + NameWeapon);

                                EquipNameWeapon = _ArrayInventoryName[Select, 0];
                                EquipDmgMinWeapon = _ArrayInventory[Select, 1];
                                EquipDmgMaxWeapon = _ArrayInventory[Select, 2];
                                EquipDurabilityWeapon = _ArrayInventory[Select, 3];

                                DmgMin += EquipDmgMinWeapon;
                                DmgMax += EquipDmgMaxWeapon;


                                Console.WriteLine("Теперь у " + Name + " урон " + DmgMin + "-" + DmgMax);
                                goto case 1;
                        }


                        Inventory = false;
                    }

                    if (Shop == true)                                   //Магазин
                    {
                        Console.WriteLine("Вы зашли в магазин:");
                        Console.WriteLine("У вас золота: " + Gold);
                        Console.WriteLine("Товары в наличии:");





                        Console.WriteLine("\nЧто будешь делать?");
                        Console.WriteLine("1)Пойти на битву Богов");
                        Console.WriteLine("2)Открыть инвентарь");
                        Jump = Convert.ToInt32(Console.ReadLine());                                     //Переход между кейсами  
                        Console.Clear();

                        if (Jump == 1)
                        {
                            goto case 1;
                        }
                        else if (Jump == 2)
                        {
                            Inventory = true;
                        }
                    }
                    break;                                                          //Инвентарь
            }
        }
        static void Main()
        {

            Console.WriteLine("Выбирайте: ");
            Console.WriteLine("1)Новая игра");
            Console.WriteLine("2)Продолжить игру");
            Console.WriteLine("3)Статистика");
            Console.WriteLine("4)Выход");
            int Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    Program.NewGame();
                    break;
                case 2:
                    Program.NewGame();
                    break;
                case 3:
                    Program.NewGame();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
