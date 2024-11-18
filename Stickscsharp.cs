using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sticks - C# version");
            Console.WriteLine("Programmer: Steciuc Angel Florentin");
            Console.WriteLine("The basic rule is: the one who cuts the last piece has lost the game!");
            Console.WriteLine();
            int nr_juc = 0;
            String nume1 = "";
            String nume2 = "";
            int loop = 10;
            int rnd = 0;
            int bte = 0;
            int dificultate = 0;
            int loop1 = 10;
            Console.WriteLine("Choose the difficulty level: ");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Standard");
            Console.WriteLine("3 - Hard");
            while (loop != 0)
            {
                try
                {
                    Console.WriteLine("Input the chosen option:");
                    dificultate = Convert.ToInt32(Console.ReadLine());
                    if ((dificultate == 1) || (dificultate == 2) || (dificultate == 3))
                    {
                        loop = 0;
                    }
                    else
                    {
                        Console.WriteLine("You have entered a wrong option!");
                        loop = 10;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have entered a wrong option!");
                }
            }
            Console.WriteLine("Choose the number of players:");
            Console.WriteLine("1 - One player vs A.I.");
            Console.WriteLine("2 - Two players");
            loop = 10;
            while (loop != 0)
            {
                try
                {
                    Console.WriteLine("Input the chosen option:");
                    nr_juc = Convert.ToInt32(Console.ReadLine());
                    if (nr_juc == 1)
                    {
                        Console.WriteLine("Enter the name of the player:");
                        nume1 = Console.ReadLine();
                        loop = 0;
                    }
                    else if (nr_juc == 2)
                    {
                        Console.WriteLine("Enter the name of the first player:");
                        nume1 = Console.ReadLine();
                        Console.WriteLine("Enter the name of the second player:");
                        nume2 = Console.ReadLine();
                        loop = 0;
                    }
                    else
                    {
                        loop = 10;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have entered a wrong option!");
                }
            }

            // creare si afisare initiala a stickslor
            List<Char> list1 = new List<char>();
            List<Char> list2 = new List<char>();
            List<Char> list3 = new List<char>();
            List<Char> list4 = new List<char>();
            if (dificultate == 1)
            {
                Console.Write("1st Row   ");
                for (int i = 0; i < 1; i++)
                {
                    list1.Add('|');
                    Console.Write(list1[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("2nd Row   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("3rd Row   ");
                for (int i = 0; i < 5; i++)
                {
                    list3.Add('|');
                    Console.Write(list3[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else if (dificultate == 2)
            {
                Console.Write("1st Row   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("2nd Row   ");
                for (int i = 0; i < 5; i++)
                {
                    list3.Add('|');
                    Console.Write(list3[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("3rd Row   ");
                for (int i = 0; i < 7; i++)
                {
                    list4.Add('|');
                    Console.Write(list4[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else if (dificultate == 3)
            {
                Console.Write("1st Row   ");
                for (int i = 0; i < 1; i++)
                {
                    list1.Add('|');
                    Console.Write(list1[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("2nd Row   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("3rd Row   ");
                for (int i = 0; i < 5; i++)
                {
                    list3.Add('|');
                    Console.Write(list3[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("4th Row   ");
                for (int i = 0; i < 7; i++)
                {
                    list4.Add('|');
                    Console.Write(list4[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            int rand = 0;
            int nr_ales = 0;
            byte jucator = 0;

            // cuprins joc

            if ((nr_juc == 1) && (dificultate == 1))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine("You chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine("A.I. won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    //Mutare A.I.
                    if (jucator == 1)
                    {
                        //Rationament A.I.
                        Console.WriteLine();
                        Console.WriteLine("A.I.'s turn");
                        // cazul par par par
                        if ((list1.Count() % 2 == 0) && (list2.Count() % 2 == 0) && (list3.Count() % 2 == 0))
                        {
                            if ((list2.Count() == 2) && (list3.Count() > 2))
                            {
                                while (list3.Count() != 2)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() == 2))
                            {
                                list3.RemoveAt(list3.Count() - 1);
                                rnd = 3;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 0) && (list3.Count() >= 2))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() == 0))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 2;
                                bte = bte + 1;
                            }
                        }
                        //cazul impar impar impar
                        else if ((list1.Count() % 2 != 0) && (list2.Count() % 2 != 0) && (list3.Count() % 2 != 0))
                        {
                            if ((list2.Count() == 1) && (list3.Count() == 1))
                            {
                                list3.RemoveAt(list3.Count() - 1);
                                rnd = 3;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() > 1) && (list3.Count() > 1))
                            {
                                while (list3.Count() != 2)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() > 1) && (list3.Count() == 1))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list3.Count() > 1))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }

                        }
                        // cazul par par impar
                        else if ((list1.Count() % 2 == 0) && (list2.Count() % 2 == 0) && (list3.Count() % 2 != 0))
                        {
                            if ((list1.Count() == 0) && (list2.Count() == 0))
                            {
                                if (list3.Count() > 1)
                                {
                                    while (list3.Count() != 1)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list1.Count() == 0) && (list2.Count() == 2))
                            {
                                if (list3.Count() > 1)
                                {
                                    while (list3.Count() != 2)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else
                                {
                                    while (list2.Count() != 0)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }

                            }
                        }

                        //cazul par impar impar
                        else if ((list1.Count() % 2 == 0) && (list2.Count() % 2 != 0) && (list3.Count() % 2 != 0))
                        {
                            if (list2.Count() == list3.Count())
                            {
                                list3.RemoveAt(list3.Count() - 1);
                                rnd = 3;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 1) && (list3.Count() >= 1))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if (list2.Count() > list3.Count())
                            {
                                while (list2.Count() != list3.Count())
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if (list3.Count() > list2.Count())
                            {
                                while (list3.Count() != list2.Count())
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                        }
                        //cazul impar par par
                        else if ((list1.Count() % 2 != 0) && (list2.Count() % 2 == 0) && (list3.Count() % 2 == 0))
                        {
                            if ((list2.Count() >= 2) && (list3.Count() >= 2))
                            {
                                list1.RemoveAt(list1.Count() - 1);
                                rnd = 1;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 0) && (list3.Count() >= 2))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                        }
                        //cazul impar impar par
                        else if ((list1.Count() % 2 != 0) && (list2.Count() % 2 != 0) && (list3.Count() % 2 == 0))
                        {
                            if ((list2.Count() >= 1) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list3.Count() >= 2))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 3) && (list3.Count() >= 2))
                            {
                                if (list2.Count() > list3.Count())
                                {
                                    while (list2.Count() != list3.Count())
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if (list3.Count() > list2.Count())
                                {
                                    while (list3.Count() != list2.Count())
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                            }
                        }
                        //cazul impar par impar
                        else if ((list1.Count() % 2 != 0) && (list2.Count() % 2 == 0) && (list3.Count() % 2 != 0))
                        {
                            if ((list2.Count() == 0) && (list3.Count() >= 1))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() == 1))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 2;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 2) && (list3.Count() >= 3))
                            {
                                while (list3.Count() != 2)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                        }


                        //cazul par impar par
                        else if ((list1.Count() % 2 == 0) && (list2.Count() % 2 != 0) && (list3.Count() % 2 == 0))
                        {
                            if ((list2.Count() == 1) && (list3.Count() == 0))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 2;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 3) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list3.Count() >= 2))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 3) && (list3.Count() >= 2))
                            {
                                if (list2.Count() > list3.Count())
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                                else if (list3.Count() > list2.Count())
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                        }
                        Console.WriteLine("A.I. chose the row " + Convert.ToString(rnd) + " and cut " + Convert.ToString(bte) + " sticks.");
                        bte = 0;
                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }
            }

            else if ((nr_juc == 1) && (dificultate == 2))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine("You chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine("A.I. won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    //Mutare A.I.
                    if (jucator == 1)
                    {
                        //Rationament A.I.
                        Console.WriteLine("A.I.'s turn");
                        Console.WriteLine();
                        // cazul suma para
                        if ((list2.Count() + list3.Count() + list4.Count()) % 2 == 0)
                        {
                            // 0 0 >=2
                            if ((list2.Count() == 0) && (list3.Count() == 0))
                            {
                                while (list4.Count() != 1)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 0) && (list4.Count() == 0))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 0) && (list4.Count() == 0))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            // 1 1 0
                            else if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list4.Count() == 1) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 1) && (list4.Count() == 1) && (list2.Count()) == 0)
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }

                            // 0  3  1
                            else if ((list2.Count() > 1) && (list3.Count() == 1) && (list4.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() > 1) && (list4.Count() == 1) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list3.Count() > 1) && (list4.Count() == 0))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list4.Count() > 1) && (list3.Count() == 0))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() > 1) && (list4.Count() == 1) && (list2.Count() == 0))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 1) && (list4.Count() > 1) && (list2.Count() == 0))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }

                            //1 1 2
                            else if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() >= 2))
                            {
                                while (list4.Count() != 1)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list4.Count() == 1) && (list3.Count() >= 2))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if (((list3.Count() == 1) && list4.Count() == 1) && (list2.Count()) == 2)
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            //2 2 0
                            else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() >= 0))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list4.Count() == 2) && (list3.Count() >= 0))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 2) && (list4.Count() == 2) && (list2.Count()) == 0)
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }

                            //2 2 2
                            else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() == 2))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }

                            //0 >2 >2
                            else if ((list2.Count() == 0) && (list3.Count() > 2) && (list4.Count() > 2))
                            {
                                if (list3.Count() > list4.Count())
                                {
                                    while (list3.Count() != list4.Count())
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if (list3.Count() < list4.Count())
                                {
                                    while (list4.Count() != list3.Count())
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if (list3.Count() == list4.Count())
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() == 0) && (list4.Count() > 2))
                            {
                                while (list4.Count() != list2.Count())
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() == 0))
                            {
                                while (list3.Count() != list2.Count())
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }

                            //2 >2 >2
                            else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() > 2))
                            {
                                if (list3.Count() > list4.Count())
                                {
                                    while (list3.Count() != list4.Count())
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if (list4.Count() > list3.Count())
                                {
                                    while (list4.Count() != list3.Count())
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if (list3.Count() == list4.Count())
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }

                            //2 2 >2
                            else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() > 2))
                            {
                                while (list4.Count() != list3.Count())
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() == 2))
                            {
                                while (list3.Count() != list3.Count())
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }

                            //3 >=3 >=3
                            else if ((list2.Count() == 3) && (list3.Count() >= 3) && (list4.Count() >= 3))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 1;
                                bte = bte + 1;
                            }

                            // >=2  >=3  1
                            else if ((list2.Count() >= 2) && (list3.Count() >= 3) && (list4.Count() == 1))
                            {
                                list4.RemoveAt(list4.Count() - 1);
                                rnd = 3;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() >= 2) && (list3.Count() == 1) && (list4.Count() >= 3))
                            {
                                list3.RemoveAt(list3.Count() - 1);
                                rnd = 2;
                                bte = bte + 1;
                            }
                            else if ((list2.Count() == 1) && (list3.Count() >= 2) && (list4.Count() >= 3))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 1;
                                bte = bte + 1;
                            }
                        }


                        //cazul suma impara
                        else if ((list2.Count() + list3.Count() + list4.Count()) % 2 != 0)
                        {
                            //1 1 1
                            if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() == 1))
                            {
                                list4.RemoveAt(list4.Count() - 1);
                                rnd = 3;
                                bte = bte + 1;
                            }

                            //0 0 1
                            else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() == 1))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 0) && (list4.Count() == 0) && (list3.Count() == 1))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 0) && (list4.Count() == 0) && (list2.Count() == 1))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }

                            //0 0 >=3
                            else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() >= 3))
                            {
                                while (list4.Count() != 1)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 0) && (list4.Count() == 0) && (list3.Count() >= 3))
                            {
                                while (list3.Count() != 1)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 0) && (list4.Count() == 0) && (list2.Count() == 3))
                            {
                                while (list2.Count() != 1)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }

                            //2 1 2
                            else if ((list2.Count() == 2) && (list3.Count() == 1) && (list4.Count() == 2))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 1) && (list4.Count() == 2) && (list3.Count() == 2))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 2) && (list4.Count() == 1) && (list2.Count() == 2))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }

                            //2 3 2
                            else if ((list2.Count() == 2) && (list3.Count() >= 3) && (list4.Count() == 2))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 3) && (list4.Count() == 2) && (list3.Count() == 2))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 2) && (list4.Count() >= 3) && (list2.Count() == 2))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            //1 >=3 >=3
                            else if ((list2.Count() == 1) && (list3.Count() >= 3) && (list4.Count() >= 3))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() == 3) && (list4.Count() == 1) && (list3.Count() >= 3))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() == 1) && (list4.Count() >= 3) && (list2.Count() == 3))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }

                            //3 >=3 >=3
                            else if ((list2.Count() == 3) && (list3.Count() >= 3) && (list4.Count() >= 3))
                            {
                                list2.RemoveAt(list2.Count() - 1);
                                rnd = 1;
                                bte = bte + 1;
                            }

                            // 0  1  3
                            else if ((list2.Count() == 0) && (list3.Count() == 1) && (list4.Count() >= 2))
                            {
                                while (list4.Count() != 0)
                                {
                                    list4.RemoveAt(list4.Count() - 1);
                                    rnd = 3;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list2.Count() >= 2) && (list4.Count() == 1) && (list3.Count() == 0))
                            {
                                while (list2.Count() != 0)
                                {
                                    list2.RemoveAt(list2.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                            }
                            else if ((list3.Count() >= 2) && (list4.Count() == 0) && (list2.Count() == 1))
                            {
                                while (list3.Count() != 0)
                                {
                                    list3.RemoveAt(list3.Count() - 1);
                                    rnd = 2;
                                    bte = bte + 1;
                                }
                            }
                            // 0  2  3
                            else if ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() >= 2))
                            {
                                if (list3.Count() > list4.Count())
                                    while (list3.Count() != list4.Count())
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                else if (list3.Count() < list4.Count())
                                    while (list4.Count() != list3.Count())
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                            }
                            else if ((list2.Count() >= 2) && (list4.Count() == 0) && (list3.Count() >= 2))
                            {
                                if (list3.Count() > list2.Count())
                                    while (list3.Count() != list2.Count())
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                else if (list3.Count() < list2.Count())
                                    while (list2.Count() != list3.Count())
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 1;
                                        bte = bte + 1;
                                    }
                            }
                            else if ((list3.Count() == 0) && (list4.Count() >= 2) && (list2.Count() >= 2))
                            {
                                if (list2.Count() > list4.Count())
                                    while (list2.Count() != list4.Count())
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 1;
                                        bte = bte + 1;
                                    }
                                else if (list2.Count() < list4.Count())
                                    while (list4.Count() != list2.Count())
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                            }

                        }


                        Console.WriteLine("A.I. chose the row " + Convert.ToString(rnd) + " and cut " + Convert.ToString(bte) + " sticks.");
                        bte = 0;
                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }
            }
            else if ((nr_juc == 1) && (dificultate == 3))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine("You chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 4)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }


                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("4th Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine("A.I. won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    //Mutare A.I.
                    if (jucator == 1)
                    {
                        //Rationament A.I.
                        Console.WriteLine();
                        Console.WriteLine("A.I.'s turn");
                        //cazul suma para
                        if ((list1.Count() + list2.Count() + list3.Count() + list4.Count()) % 2 == 0)
                        {
                            if (list1.Count() == 0)
                            {
                                if ((list2.Count() + list3.Count() + list4.Count()) % 2 == 0)
                                {
                                    // 0 0 >=2
                                    if ((list2.Count() == 0) && (list3.Count() == 0))
                                    {
                                        while (list4.Count() != 1)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 0) && (list4.Count() == 0))
                                    {
                                        while (list3.Count() != 1)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 0) && (list4.Count() == 0))
                                    {
                                        while (list2.Count() != 1)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    // 1 1 0
                                    else if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() == 0))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 1) && (list4.Count() == 1) && (list3.Count() == 0))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 1) && (list4.Count() == 1) && (list2.Count()) == 0)
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }

                                    // 0  3  1
                                    else if ((list2.Count() > 1) && (list3.Count() == 1) && (list4.Count() == 0))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() > 1) && (list4.Count() == 1) && (list3.Count() == 0))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 1) && (list3.Count() > 1) && (list4.Count() == 0))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 1) && (list4.Count() > 1) && (list3.Count() == 0))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() > 1) && (list4.Count() == 1) && (list2.Count() == 0))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 1) && (list4.Count() > 1) && (list2.Count() == 0))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }

                                    //1 1 2
                                    else if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() >= 2))
                                    {
                                        while (list4.Count() != 1)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 1) && (list4.Count() == 1) && (list3.Count() >= 2))
                                    {
                                        while (list3.Count() != 1)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if (((list3.Count() == 1) && list4.Count() == 1) && (list2.Count()) == 2)
                                    {
                                        while (list2.Count() != 1)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 2 0
                                    else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() >= 0))
                                    {
                                        while (list2.Count() != 1)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 2) && (list4.Count() == 2) && (list3.Count() >= 0))
                                    {
                                        while (list2.Count() != 1)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 2) && (list4.Count() == 2) && (list2.Count()) == 0)
                                    {
                                        while (list3.Count() != 1)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 2 2
                                    else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() == 2))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    //0 >2 >2
                                    else if ((list2.Count() == 0) && (list3.Count() > 2) && (list4.Count() > 2))
                                    {
                                        if (list3.Count() > list4.Count())
                                        {
                                            while (list3.Count() != list4.Count())
                                            {
                                                list3.RemoveAt(list3.Count() - 1);
                                                rnd = 3;
                                                bte = bte + 1;
                                            }
                                        }
                                        else if (list3.Count() < list4.Count())
                                        {
                                            while (list4.Count() != list3.Count())
                                            {
                                                list4.RemoveAt(list4.Count() - 1);
                                                rnd = 4;
                                                bte = bte + 1;
                                            }
                                        }
                                        else if (list3.Count() == list4.Count())
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 2) && (list3.Count() == 0) && (list4.Count() > 2))
                                    {
                                        while (list4.Count() != list2.Count())
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() == 0))
                                    {
                                        while (list3.Count() != list2.Count())
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 >2 >2
                                    else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() > 2))
                                    {
                                        if (list3.Count() > list4.Count())
                                        {
                                            while (list3.Count() != list4.Count())
                                            {
                                                list3.RemoveAt(list3.Count() - 1);
                                                rnd = 3;
                                                bte = bte + 1;
                                            }
                                        }
                                        else if (list4.Count() > list3.Count())
                                        {
                                            while (list4.Count() != list3.Count())
                                            {
                                                list4.RemoveAt(list4.Count() - 1);
                                                rnd = 4;
                                                bte = bte + 1;
                                            }
                                        }
                                        else if (list3.Count() == list4.Count())
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 2 >2
                                    else if ((list2.Count() == 2) && (list3.Count() == 2) && (list4.Count() > 2))
                                    {
                                        while (list4.Count() != list3.Count())
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 2) && (list3.Count() > 2) && (list4.Count() == 2))
                                    {
                                        while (list3.Count() != list3.Count())
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }

                                    //3 >=3 >=3
                                    else if ((list2.Count() == 3) && (list3.Count() >= 3) && (list4.Count() >= 3))
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 1;
                                        bte = bte + 1;
                                    }

                                    // >=2  >=3  1
                                    else if ((list2.Count() >= 2) && (list3.Count() >= 3) && (list4.Count() == 1))
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                    else if ((list2.Count() >= 2) && (list3.Count() == 1) && (list4.Count() >= 3))
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                    else if ((list2.Count() == 1) && (list3.Count() >= 2) && (list4.Count() >= 3))
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }



                            }
                            //list1.Count()!=0
                            else
                            {
                                if ((list2.Count() >= 1) && (list3.Count() >= 1) && (list4.Count() >= 1))
                                {
                                    list1.RemoveAt(list1.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                                else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() >= 1))
                                {
                                    while (list4.Count() != 0)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 1) && (list3.Count() == 0) && (list4.Count() == 0))
                                {
                                    while (list2.Count() != 0)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() >= 1) && (list4.Count() == 0))
                                {
                                    while (list3.Count() != 0)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() == 1) && (list4.Count() >= 2))
                                {
                                    while (list4.Count() != 1)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() == 1))
                                {
                                    while (list3.Count() != 1)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 1) && (list3.Count() >= 2) && (list4.Count() == 0))
                                {
                                    while (list3.Count() != 1)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 1) && (list3.Count() == 0) && (list4.Count() >= 2))
                                {
                                    while (list4.Count() != 1)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 2) && (list3.Count() == 0) && (list4.Count() == 1))
                                {
                                    while (list2.Count() != 1)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 2) && (list3.Count() == 1) && (list4.Count() == 0))
                                {
                                    while (list2.Count() != 1)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if (((list2.Count() >= 2) && (list3.Count() >= 2) && (list4.Count() == 0)) || ((list2.Count() >= 2) && (list3.Count() == 0) && (list4.Count() >= 2)) || ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() >= 2)))
                                {
                                    list1.RemoveAt(list1.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }


                                //de completat pentru list1.Count()!=0







                            }
                        }



                        //cazul suma impara
                        else
                        {
                            if (list1.Count() == 0)
                            {
                                if ((list2.Count() + list3.Count() + list4.Count()) % 2 != 0)
                                {
                                    //1 1 1
                                    if ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() == 1))
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                    //0 0 1
                                    else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() == 1))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 0) && (list4.Count() == 0) && (list3.Count() == 1))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 0) && (list4.Count() == 0) && (list2.Count() == 1))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    //0 0 >=3
                                    else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() >= 3))
                                    {
                                        while (list4.Count() != 1)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 0) && (list4.Count() == 0) && (list3.Count() >= 3))
                                    {
                                        while (list3.Count() != 1)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 0) && (list4.Count() == 0) && (list2.Count() == 3))
                                    {
                                        while (list2.Count() != 1)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 1 2
                                    else if ((list2.Count() == 2) && (list3.Count() == 1) && (list4.Count() == 2))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 1) && (list4.Count() == 2) && (list3.Count() == 2))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 2) && (list4.Count() == 1) && (list2.Count() == 2))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    //2 3 2
                                    else if ((list2.Count() == 2) && (list3.Count() >= 3) && (list4.Count() == 2))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 3) && (list4.Count() == 2) && (list3.Count() == 2))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 2) && (list4.Count() >= 3) && (list2.Count() == 2))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    //1 >=3 >=3
                                    else if ((list2.Count() == 1) && (list3.Count() >= 3) && (list4.Count() >= 3))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() == 3) && (list4.Count() == 1) && (list3.Count() >= 3))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() == 1) && (list4.Count() >= 3) && (list2.Count() == 3))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    //3 >=3 >=3
                                    else if ((list2.Count() == 3) && (list3.Count() >= 3) && (list4.Count() >= 3))
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                    // 0 1 3
                                    else if ((list2.Count() == 0) && (list3.Count() == 1) && (list4.Count() >= 2))
                                    {
                                        while (list4.Count() != 0)
                                        {
                                            list4.RemoveAt(list4.Count() - 1);
                                            rnd = 4;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list2.Count() >= 2) && (list4.Count() == 1) && (list3.Count() == 0))
                                    {
                                        while (list2.Count() != 0)
                                        {
                                            list2.RemoveAt(list2.Count() - 1);
                                            rnd = 2;
                                            bte = bte + 1;
                                        }
                                    }
                                    else if ((list3.Count() >= 2) && (list4.Count() == 0) && (list2.Count() == 1))
                                    {
                                        while (list3.Count() != 0)
                                        {
                                            list3.RemoveAt(list3.Count() - 1);
                                            rnd = 3;
                                            bte = bte + 1;
                                        }
                                    }
                                    // 0 2 3
                                    else if ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() >= 2))
                                    {
                                        if (list3.Count() > list4.Count())
                                            while (list3.Count() != list4.Count())
                                            {
                                                list3.RemoveAt(list3.Count() - 1);
                                                rnd = 3;
                                                bte = bte + 1;
                                            }
                                        else if (list3.Count() < list4.Count())
                                            while (list4.Count() != list3.Count())
                                            {
                                                list4.RemoveAt(list4.Count() - 1);
                                                rnd = 4;
                                                bte = bte + 1;
                                            }
                                    }
                                    else if ((list2.Count() >= 2) && (list4.Count() == 0) && (list3.Count() >= 2))
                                    {
                                        if (list3.Count() > list2.Count())
                                            while (list3.Count() != list2.Count())
                                            {
                                                list3.RemoveAt(list3.Count() - 1);
                                                rnd = 3;
                                                bte = bte + 1;
                                            }
                                        else if (list3.Count() < list2.Count())
                                            while (list2.Count() != list3.Count())
                                            {
                                                list2.RemoveAt(list2.Count() - 1);
                                                rnd = 2;
                                                bte = bte + 1;
                                            }
                                    }
                                    else if ((list3.Count() == 0) && (list4.Count() >= 2) && (list2.Count() >= 2))
                                    {
                                        if (list2.Count() > list4.Count())
                                            while (list2.Count() != list4.Count())
                                            {
                                                list2.RemoveAt(list2.Count() - 1);
                                                rnd = 2;
                                                bte = bte + 1;
                                            }
                                        else if (list2.Count() < list4.Count())
                                            while (list4.Count() != list2.Count())
                                            {
                                                list4.RemoveAt(list4.Count() - 1);
                                                rnd = 4;
                                                bte = bte + 1;
                                            }
                                    }

                                }
                            }
                            //list1.Count()!=0
                            else
                            {
                                if ((list2.Count() >= 1) && (list3.Count() >= 1) && (list4.Count() >= 1))
                                {
                                    list1.RemoveAt(list1.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                                else if ((list2.Count() == 0) && (list3.Count() == 0) && (list4.Count() >= 1))
                                {
                                    while (list4.Count() != 0)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 1) && (list3.Count() == 0) && (list4.Count() == 0))
                                {
                                    while (list2.Count() != 0)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() >= 1) && (list4.Count() == 0))
                                {
                                    while (list3.Count() != 0)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() == 1) && (list4.Count() >= 2))
                                {
                                    while (list4.Count() != 1)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() == 1))
                                {
                                    while (list3.Count() != 1)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 1) && (list3.Count() >= 2) && (list4.Count() == 0))
                                {
                                    while (list3.Count() != 1)
                                    {
                                        list3.RemoveAt(list3.Count() - 1);
                                        rnd = 3;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() == 1) && (list3.Count() == 0) && (list4.Count() >= 2))
                                {
                                    while (list4.Count() != 1)
                                    {
                                        list4.RemoveAt(list4.Count() - 1);
                                        rnd = 4;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 2) && (list3.Count() == 0) && (list4.Count() == 1))
                                {
                                    while (list2.Count() != 1)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if ((list2.Count() >= 2) && (list3.Count() == 1) && (list4.Count() == 0))
                                {
                                    while (list2.Count() != 1)
                                    {
                                        list2.RemoveAt(list2.Count() - 1);
                                        rnd = 2;
                                        bte = bte + 1;
                                    }
                                }
                                else if (((list2.Count() >= 2) && (list3.Count() >= 2) && (list4.Count() == 0)) || ((list2.Count() >= 2) && (list3.Count() == 0) && (list4.Count() >= 2)) || ((list2.Count() == 0) && (list3.Count() >= 2) && (list4.Count() >= 2)))
                                {
                                    list1.RemoveAt(list1.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }
                                else if (((list2.Count() == 0) && (list3.Count() == 1) && (list4.Count() == 1)) || ((list2.Count() == 1) && (list3.Count() == 0) && (list4.Count() == 1)) || ((list2.Count() == 1) && (list3.Count() == 1) && (list4.Count() == 0)))
                                {
                                    list1.RemoveAt(list1.Count() - 1);
                                    rnd = 1;
                                    bte = bte + 1;
                                }

                                // de completat pentru list1.Count()!=0


                            }




                        }


                        Console.WriteLine("A.I. chose the row " + Convert.ToString(rnd) + " and cut " + Convert.ToString(bte) + " sticks.");
                        bte = 0;

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("4th Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }
            }

            else if ((nr_juc == 2) && (dificultate == 1))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine(nume1 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    else
                    {
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume2 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }

                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine(nume2 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }
            }

            else if ((nr_juc == 2) && (dificultate == 2))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine(nume1 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    else
                    {
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume2 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine(nume2 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }

            }

            else if ((nr_juc == 2) && (dificultate == 3))
            {
                loop = 10;
                while (loop != 0)
                {
                    if (jucator == 0)
                    {
                        // selectare rand
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume1 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }
                        Console.WriteLine(nume1 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 4)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("4th Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 1;
                        }

                    }
                    else
                    {
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(nume2 + "'s turn");
                            Console.WriteLine("Input the row you choose:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Wrong row! Input the row you choose:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have entered a wrong option!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("How many sticks do you want to cut? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Wrong number! Enter the number of sticks:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You have entered a wrong option!");
                            }
                        }

                        Console.WriteLine(nume2 + " chose the row " + Convert.ToString(rand) + " and cut " + Convert.ToString(nr_ales) + " sticks.");

                        //aplicare alegeri
                        if (rand == 1)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list1.RemoveAt(list1.Count() - 1);
                            }
                        }
                        else if (rand == 2)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list2.RemoveAt(list2.Count() - 1);
                            }
                        }
                        else if (rand == 3)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list3.RemoveAt(list3.Count() - 1);
                            }
                        }
                        else if (rand == 4)
                        {
                            for (int i = 0; i < nr_ales; i++)
                            {
                                list4.RemoveAt(list4.Count() - 1);
                            }
                        }

                        //afisare noua tabela de joc
                        Console.Write("1st Row   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("2nd Row   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("3rd Row   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("4th Row   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " won!");
                            loop = 0;
                        }
                        else
                        {
                            jucator = 0;
                        }
                    }
                }

            }

            // terminare joc
            Console.WriteLine("Press ENTER to close the game!");
            Console.ReadLine();
        }
    }

  
}
   

