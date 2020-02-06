using System;
using System.Collections.Generic;

namespace DiskretkaN1
{
    class Program
    {
        static int[,] MatrixIncid = null;
        static int[,] MatrixSmezh = null;
        static int[][] SpisokSmezh = null;
        static int vershiny = new int();
        static int rebra = new int();
        private static void Incid_Output()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\tМатрица инцидентности\n\n");
            Console.ResetColor();
            Console.Write("\t\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 1; i <= vershiny; i++)
            {
                Console.Write("\tx" + i + "   ");
            }
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < rebra; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\t\te" + (i + 1) + "\t");
                Console.ResetColor();
                for (int g = 0; g < vershiny; g++)
                    Console.Write(MatrixIncid[i, g] + "\t");
                Console.WriteLine();
            }
        }
        private static void Incid_Input()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Введите количество вершин: ");
            Console.ResetColor();
            try
            {
                vershiny = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(" Введите количество рёбер: ");
                Console.ResetColor();
                rebra = Convert.ToInt32(Console.ReadLine());
                if (vershiny == 0 || rebra == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Ошибка. Граф не может быть без вершин или рёбер.");
                    Console.ResetColor();
                    StartMenu();
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Введите число");
                Console.ResetColor();
                StartMenu();
            }
            MatrixIncid = null;
            GC.Collect();
            MatrixIncid = new int[rebra, vershiny];
            try
            {
                Console.Clear();
                for (int i = 0; i < rebra; i++)
                {
                    Console.Write("\nЗначения для ребра ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("e" + (i + 1) + ": \n");
                    Console.ResetColor();
                    for (int g = 0; g < vershiny; g++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("\nx" + (g + 1) + "= ");
                        Console.ResetColor();
                        MatrixIncid[i, g] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Матрица инцидентности введена в неправильном формате.");
                Console.ResetColor();
                StartMenu();
            }
        }
        private static void Smezh_Input()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Введите количество вершин: ");
            Console.ResetColor();
            try
            {
                vershiny = Convert.ToInt32(Console.ReadLine());
                if (vershiny == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Ошибка. Граф не может быть без вершин.");
                    Console.ResetColor();
                    StartMenu();
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Введите число");
                Console.ResetColor();
                StartMenu();
            }
            MatrixSmezh = null;
            GC.Collect();
            MatrixSmezh = new int[vershiny, vershiny];
            try
            {
                Console.Clear();
                for (int i = 0; i < vershiny; i++)
                {
                    Console.Write("\nЗначения для вершины ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("x" + (i + 1) + ": \n");
                    Console.ResetColor();
                    for (int g = 0; g < vershiny; g++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("\nx" + (g + 1) + "= ");
                        Console.ResetColor();
                        MatrixSmezh[i, g] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Матрица смежности введена в неправильном формате.");
                Console.ResetColor();
                StartMenu();
            }
        }
        private static void Smezh_Output()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\tМатрица смежности\n\n");
            Console.ResetColor();
            Console.Write("\t\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 1; i <= vershiny; i++)
                {
                    Console.Write("\tx" + i + "   ");
                }
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < vershiny; i++)
                {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\t\tx" + (i + 1) + "\t");
                Console.ResetColor();
                for (int g = 0; g < vershiny; g++)
                    Console.Write(MatrixSmezh[i, g] + "\t");
                    Console.WriteLine();
                }
        }
        private static void Spisok_Input()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Введите количество вершин: ");
            Console.ResetColor();
            try
            {
                vershiny = Convert.ToInt32(Console.ReadLine());
                if (vershiny == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Ошибка. Граф не может быть без вершин.");
                    Console.ResetColor();
                    StartMenu();
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Введите число");
                Console.ResetColor();
                StartMenu();
            }
            SpisokSmezh = null;
            GC.Collect();
            SpisokSmezh = new int[vershiny][];
            Console.Clear();
            List<int>[] vs = new List<int>[vershiny];
            for (int i = 0; i < vershiny; i++)
            {
                vs[i] = new List<int>();
            }
            try
            {
                int selection = new int();
                for (int i = 0; i < vershiny; i++)
                {
                    Console.Write(" Введите номера вершин, связанных с ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("x" + (i + 1) + ":\n");
                    Console.ResetColor();
                    for (int g = 0; g < vershiny; g++)
                    {
                        selection = Convert.ToInt32(Console.ReadLine());
                        if (selection == 0)
                        {
                            vs[i].Add(0);
                            break;
                        }
                        else
                        {
                            vs[i].Add(selection);
                        }
                    }

                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Список смежности введён в неправильном формате");
                Console.ResetColor();
                StartMenu();
            }
            for (int i = 0; i < vershiny; i++)
            {
                SpisokSmezh[i] = vs[i].ToArray();
                vs[i].Clear();
            }
            GC.Collect();
        }
        private static void Spisok_Output()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\tСписок смежности\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < vershiny; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\t\tx"+(i+1));
                Console.ResetColor(); Console.Write(" - ");
                for (int g = 0; g < SpisokSmezh[i].Length; g++)
                {
                    if (g != 0)
                    {
                        Console.Write(",");
                    }
                    Console.Write(" " + SpisokSmezh[i][g]);
                }
                Console.WriteLine("\n");
            }
        }
        private static void Incid_To_Smezh()
        {
            MatrixSmezh = null;
            GC.Collect();
            int indexOne = new int();
            int indexMinusOne = new int();
            MatrixSmezh = new int[vershiny, vershiny];
            for (int i = 0; i < rebra; i++)
            {
                for(int g=0; g < vershiny; g++)
                {
                    if (MatrixIncid[i, g] == -1)
                        indexMinusOne = g;
                    if (MatrixIncid[i, g] == 1)
                        indexOne = g;
                }
                MatrixSmezh[indexMinusOne, indexOne] = 1;
            }
        }
        private static void Smezh_To_Spisok()
        {
            SpisokSmezh = null;
            GC.Collect();
            SpisokSmezh = new int[vershiny][];
            List<int>[] vs = new List<int>[vershiny];
            for (int i = 0; i < vershiny; i++)
            {
                vs[i] = new List<int>();
            }
            for(int i = 0; i < vershiny; i++)
            {
                for(int g = 0; g < vershiny; g++)
                {
                    if (MatrixSmezh[i, g] == 1)
                    {
                        vs[i].Add(g+1);
                    }
                }
                vs[i].Add(0);
            }
            for (int i = 0; i < vershiny; i++)
            {
                SpisokSmezh[i] = vs[i].ToArray();
                vs[i].Clear();
            }
            GC.Collect();
        }
        private static void Spisok_To_Incid()
        {
            MatrixIncid = null;
            GC.Collect();
            int n = 0;
            for (int i = 0; i < vershiny; i++)
                rebra += SpisokSmezh[i].Length - 1;
            MatrixIncid = new int[rebra, vershiny];
                for (int i = 0; i < vershiny; i++)
                    for (int g = 0; g < SpisokSmezh[i].Length; g++)
                        if (SpisokSmezh[i][g] != 0)
                        {
                            MatrixIncid[n, i] = -1;
                            MatrixIncid[n++, (SpisokSmezh[i][g] - 1)] = 1;
                        }
        }
        private static void StartMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\tМеню выбора ввода\n"); 
            Console.Write("\t1. ");
            Console.ResetColor(); 
            Console.Write("Матрица инцидентности");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t2. "); 
            Console.ResetColor(); 
            Console.Write("Матрица смежности");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t3. ");
            Console.ResetColor();
            Console.Write("Список смежности\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0 - ");
            Console.WriteLine("Выход\n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                byte selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            Incid_Input();
                            Incid_To_Smezh();
                            Smezh_To_Spisok();
                            Console.Clear();
                            ShowingMenu();
                            break;
                        }
                    case 2:
                        {
                            Smezh_Input();
                            Smezh_To_Spisok();
                            Spisok_To_Incid();
                            Console.Clear();
                            ShowingMenu();
                            break;
                        }
                    case 3:
                        {
                            Spisok_Input();
                            Spisok_To_Incid();
                            Incid_To_Smezh();
                            Console.Clear();
                            ShowingMenu();
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ошибка. Введите один из пунктов");
                            Console.ResetColor();
                            StartMenu();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Введите один из пунктов");
                Console.ResetColor();
                StartMenu();
            }
        }
        private static void ShowingMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\tМеню выбора показа графа\n");
            Console.Write("\t1. ");
            Console.ResetColor();
            Console.Write("Матрица инцидентности");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t2. ");
            Console.ResetColor();
            Console.Write("Матрица смежности");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t3. ");
            Console.ResetColor();
            Console.Write("Список смежности\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0 - ");
            Console.WriteLine("Ввести новый граф\n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Действие: ");
            Console.ResetColor();
            try
            {
                byte selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            Console.Clear();
                            Incid_Output();
                            ShowingMenu();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Smezh_Output();
                            ShowingMenu();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Spisok_Output();
                            ShowingMenu();
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            StartMenu();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ошибка. Введите один из пунктов");
                            Console.ResetColor();
                            StartMenu();
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ошибка. Введите один из пунктов");
                Console.ResetColor();
                ShowingMenu();
            }


        }
        static void Main()
        {
            StartMenu();
        }
    }
}
