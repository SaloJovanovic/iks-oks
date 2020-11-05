using System;

namespace Test
{
    class Program
    {
        static string[,] tabla = new string[3,3];
        static int x, y;
        static string pobednik = "";
        static void Igrac1()
        {
            System.Console.WriteLine("Igrac 1 na potezu...");
            System.Console.Write("X koordinata - ");
            x = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Y koordinata - ");
            y = Convert.ToInt32(Console.ReadLine());
            tabla[x,y] = "X";
        }

        static void igrac2()
        {
            System.Console.WriteLine("Igrac 2 na potezu...");
            System.Console.Write("X koordinata - ");
            x = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Y koordinata - ");
            y = Convert.ToInt32(Console.ReadLine());
            tabla[x,y] = "O";
        }

        static void ispis()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabla[i,j] == null)
                    {
                        Console.Write(".");
                    }
                    else
                        Console.Write(tabla[i,j]);
                }
                System.Console.WriteLine();
            }
        }

        static void provera_x()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        for (int k = 1; k < 3; k++)
                        {
                            if (tabla[i,k] != "X")
                                break;
                            if (k == 2)
                            {
                                if (tabla[i,k] == "X")
                                    pobednik = "Igrac 1";
                            }     
                        }
                        
                    }

                    if (i == 0)
                    {
                        for (int k = 1; k < 3; k++)
                        {
                            if (tabla[k,j] != "X")
                                break;
                            if (k == 2)
                            {
                                if (tabla[k,j] == "X")
                                    pobednik = "Igrac 1";
                            }
                        }
                    }
                }
            }
        }

        static void provera_o()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        for (int k = 1; k < 3; k++)
                        {
                            if (tabla[i,k] != "O")
                                break;
                            if (k == 2)
                            {
                                if (tabla[i,k] == "O")
                                    pobednik = "Igrac 2";
                            }     
                        }
                        
                    }

                    if (i == 0)
                    {
                        for (int k = 1; k < 3; k++)
                        {
                            if (tabla[k,j] != "O")
                                break;
                            if (k == 2)
                            {
                                if (tabla[k,j] == "O")
                                    pobednik = "Igrac 2";
                            }
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            bool running = true;
            int num = 1;
            while (running)
            {
                if (num % 2 == 1)
                {
                    Igrac1();
                }
                else
                {
                    igrac2();
                }
                ispis();
                provera_x();
                provera_o();
                if (pobednik != "")
                {
                    System.Console.WriteLine("Pobednik je {0}", pobednik);
                    running = false;
                }
                num++;
            }
        }
    }
}

/*
X O X
X O X
X O X
*/
