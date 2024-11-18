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
            Console.WriteLine("Bete - versiunea C#");
            Console.WriteLine("Programator: Steciuc Angel Florentin");
            Console.WriteLine("Regula de baza este: cel care taie ultima piesa a pierdut jocul!");
            Console.WriteLine();
            int nr_juc = 0;
            String nume1 = "";
            String nume2 = "";
            int loop = 10;
            int rnd = 0;
            int bte = 0;
            int dificultate = 0;
            int loop1 = 10;
            Console.WriteLine("Alege nivelul de dificultate: ");
            Console.WriteLine("1 - Usor");
            Console.WriteLine("2 - Normal");
            Console.WriteLine("3 - Greu");
            while (loop != 0)
            {
                try
                {
                    Console.WriteLine("Introdu optiunea aleasa:");
                    dificultate = Convert.ToInt32(Console.ReadLine());
                    if ((dificultate == 1) || (dificultate == 2) || (dificultate == 3))
                    {
                        loop = 0;
                    }
                    else
                    {
                        Console.WriteLine("Ai introdus o optiune gresita");
                        loop = 10;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ai introdus o optiune gresita!");
                }
            }
            Console.WriteLine("Alege numarul de jucatori:");
            Console.WriteLine("1 - Un jucator contra A.I.");
            Console.WriteLine("2 - Doi jucatori");
            loop = 10;
            while (loop != 0)
            {
                try
                {
                    Console.WriteLine("Introdu optiunea aleasa:");
                    nr_juc = Convert.ToInt32(Console.ReadLine());
                    if (nr_juc == 1)
                    {
                        Console.WriteLine("Introdu numele jucatorului:");
                        nume1 = Console.ReadLine();
                        loop = 0;
                    }
                    else if (nr_juc == 2)
                    {
                        Console.WriteLine("Introdu numele primului jucator:");
                        nume1 = Console.ReadLine();
                        Console.WriteLine("Introdu numele celui de al doilea jucator:");
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
                    Console.WriteLine("Ai introdus o optiune gresita!");
                }
            }

            // creare si afisare initiala a betelor
            List<Char> list1 = new List<char>();
            List<Char> list2 = new List<char>();
            List<Char> list3 = new List<char>();
            List<Char> list4 = new List<char>();
            if (dificultate == 1)
            {
                Console.Write("Randul 1   ");
                for (int i = 0; i < 1; i++)
                {
                    list1.Add('|');
                    Console.Write(list1[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 2   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 3   ");
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
                Console.Write("Randul 1   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 2   ");
                for (int i = 0; i < 5; i++)
                {
                    list3.Add('|');
                    Console.Write(list3[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 3   ");
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
                Console.Write("Randul 1   ");
                for (int i = 0; i < 1; i++)
                {
                    list1.Add('|');
                    Console.Write(list1[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 2   ");
                for (int i = 0; i < 3; i++)
                {
                    list2.Add('|');
                    Console.Write(list2[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 3   ");
                for (int i = 0; i < 5; i++)
                {
                    list3.Add('|');
                    Console.Write(list3[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.Write("Randul 4   ");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine("Ai ales randul " + Convert.ToString(rand) + " si tai " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine("A.I. a castigat!");
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
                        Console.WriteLine("Muta A.I.");
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
                        Console.WriteLine("A.I. a ales randul " + Convert.ToString(rnd) + " si a taiat " + Convert.ToString(bte) + " bete.");
                        bte = 0;
                        //afisare noua tabela de joc
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine("Ai ales randul " + Convert.ToString(rand) + " si tai " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine("A.I. a castigat!");
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
                        Console.WriteLine("Muta A.I.");
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


                        Console.WriteLine("A.I. a ales randul " + Convert.ToString(rnd) + " si a taiat " + Convert.ToString(bte) + " bete.");
                        bte = 0;
                        //afisare noua tabela de joc
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine("Ai ales randul " + Convert.ToString(rand) + " si tai " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 4   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine("A.I. a castigat!");
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
                        Console.WriteLine("Muta A.I.");
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


                        Console.WriteLine("A.I. a ales randul " + Convert.ToString(rnd) + " si a taiat " + Convert.ToString(bte) + " bete.");
                        bte = 0;

                        //afisare noua tabela de joc
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 4   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine(nume1 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume2);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }

                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine(nume2 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine(nume1 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume2);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 3))
                                {
                                    if ((rand == 1) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine(nume2 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume1);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }
                        Console.WriteLine(nume1 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 4   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");

                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume2 + " a castigat!");
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
                            Console.WriteLine("Muta " + nume2);
                            Console.WriteLine("Introdu randul pe care il alegi:");
                            try
                            {
                                rand = Convert.ToInt32(Console.ReadLine());
                                if ((rand > 0) && (rand <= 4))
                                {
                                    if ((rand == 1) && (list1.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 2) && (list2.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 3) && (list3.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else if ((rand == 4) && (list4.Count() == 0))
                                    {
                                        Console.WriteLine("Rand gresit! Introdu randul pe care il alegi:");
                                    }
                                    else
                                    {
                                        loop1 = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ai introdus o optiune gresita!");
                                    loop1 = 10;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        // selectare numar bete de taiat
                        loop1 = 10;
                        while (loop1 != 0)
                        {
                            Console.WriteLine("Cate bete vrei sa tai? ");
                            try
                            {
                                nr_ales = Convert.ToInt32(Console.ReadLine());
                                if ((rand == 1) && ((nr_ales == 0) || (nr_ales > list1.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 2) && ((nr_ales == 0) || (nr_ales > list2.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 3) && ((nr_ales == 0) || (nr_ales > list3.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else if ((rand == 4) && ((nr_ales == 0) || (nr_ales > list4.Count())))
                                {
                                    Console.WriteLine("Numar gresit! Introdu numarul de bete:");
                                }
                                else
                                {
                                    loop1 = 0;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ai introdus o optiune gresita!");
                            }
                        }

                        Console.WriteLine(nume2 + " a ales randul " + Convert.ToString(rand) + " si a taiat " + Convert.ToString(nr_ales) + " bete.");

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
                        Console.Write("Randul 1   ");
                        for (int i = 0; i < list1.Count(); i++)
                        {
                            Console.Write(list1[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 2   ");
                        for (int i = 0; i < list2.Count(); i++)
                        {
                            Console.Write(list2[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 3   ");
                        for (int i = 0; i < list3.Count(); i++)
                        {
                            Console.Write(list3[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        Console.Write("Randul 4   ");
                        for (int i = 0; i < list4.Count(); i++)
                        {
                            Console.Write(list4[i]);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (list1.Count() + list2.Count() + list3.Count() + list4.Count() == 0)
                        {
                            Console.WriteLine(nume1 + " a castigat!");
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
            Console.WriteLine("Apasa ENTER pentru a incheia jocul!");
            Console.ReadLine();
        }
    }

  
}
   

