using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelimeBulmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            char [,] dizi = new char[15, 15];
            dizi[0, 0] = 'a';
            dizi[0, 1] = 'ş';
            dizi[0, 2] = 'k';
            dizi[0, 3] = 'm';
            dizi[0, 4] = 'a';
            dizi[0, 5] = 'n';
            dizi[0, 6] = 'i';
            dizi[0, 7] = 's';
            dizi[0, 8] = 'a';
            dizi[0, 9] = 'ö';
            dizi[0, 10] = 'k';
            dizi[0, 11] = 't';
            dizi[0, 12] = 't';
            dizi[0, 13] = 'a';
            dizi[0, 14] = 'h';
            dizi[1, 0] = 'o';
            dizi[1, 1] = 'y';
            dizi[1, 2] = 'a';
            dizi[1, 3] = 'd';
            dizi[1, 4] = 'o';
            dizi[1, 5] = 'a';
            dizi[1, 6] = 'r';
            dizi[1, 7] = 'm';
            dizi[1, 8] = 'u';
            dizi[1, 9] = 't';
            dizi[1, 10] = 'v';
            dizi[1, 11] = 'u';
            dizi[1, 12] = 'a';
            dizi[1, 13] = 'f';
            dizi[1, 14] = 'ç';
            dizi[2, 0] = 'i';
            dizi[2, 1] = 'y';
            dizi[2, 2] = 'h';
            dizi[2, 3] = 'k';
            dizi[2, 4] = 'b';
            dizi[2, 5] = 'g';
            dizi[2, 6] = 'e';
            dizi[2, 7] = 'r';
            dizi[2, 8] = 't';
            dizi[2, 9] = 'o';
            dizi[2, 10] = 'v';
            dizi[2, 11] = 'r';
            dizi[2, 12] = 'o';
            dizi[2, 13] = 'f';
            dizi[2, 14] = 'a';
            dizi[3, 0] = 'z';
            dizi[3, 1] = 'p';
            dizi[3, 2] = 'k';
            dizi[3, 3] = 'm';
            dizi[3, 4] = 'o';
            dizi[3, 5] = 'e';
            dizi[3, 6] = 'ş';
            dizi[3, 7] = 'c';
            dizi[3, 8] = 'b';
            dizi[3, 9] = 'a';
            dizi[3, 10] = 'e';
            dizi[3, 11] = 'u';
            dizi[3, 12] = 'l';
            dizi[3, 13] = 'c';
            dizi[3, 14] = 'l';
            dizi[4, 0] = 'o';
            dizi[4, 1] = 'n';
            dizi[4, 2] = 'o';
            dizi[4, 3] = 'r';
            dizi[4, 4] = 'y';
            dizi[4, 5] = 'a';
            dizi[4, 6] = 'n';
            dizi[4, 7] = 't';
            dizi[4, 8] = 'i';
            dizi[4, 9] = 'r';
            dizi[4, 10] = 'i';
            dizi[4, 11] = 'n';
            dizi[4, 12] = 'g';
            dizi[4, 13] = 'j';
            dizi[4, 14] = 'ı';
            dizi[5, 0] = 'h';
            dizi[5, 1] = 'ç';
            dizi[5, 2] = 'c';
            dizi[5, 3] = 'ş';
            dizi[5, 4] = 'u';
            dizi[5, 5] = 't';
            dizi[5, 6] = 'ö';
            dizi[5, 7] = 'a';
            dizi[5, 8] = 'u';
            dizi[5, 9] = 'ş';
            dizi[5, 10] = 'l';
            dizi[5, 11] = 'c';
            dizi[5, 12] = 'i';
            dizi[5, 13] = 'y';
            dizi[5, 14] = 'k';
            dizi[6, 0] = 'i';
            dizi[6, 1] = 's';
            dizi[6, 2] = 'a';
            dizi[6, 3] = 's';
            dizi[6, 4] = 'n';
            dizi[6, 5] = 'i';
            dizi[6, 6] = 'ü';
            dizi[6, 7] = 'r';
            dizi[6, 8] = 'i';
            dizi[6, 9] = 'l';
            dizi[6, 10] = 'n';
            dizi[6, 11] = 'u';
            dizi[6, 12] = 'r';
            dizi[6, 13] = 'v';
            dizi[6, 14] = 'u';
            dizi[7, 0] = 'p';
            dizi[7, 1] = 'a';
            dizi[7, 2] = 'e';
            dizi[7, 3] = 't';
            dizi[7, 4] = 'ö';
            dizi[7, 5] = 'k';
            dizi[7, 6] = 'f';
            dizi[7, 7] = 'l';
            dizi[7, 8] = 'b';
            dizi[7, 9] = 'a';
            dizi[7, 10] = 'e';
            dizi[7, 11] = 'r';
            dizi[7, 12] = 'i';
            dizi[7, 13] = 'f';
            dizi[7, 14] = 'e';
            dizi[8, 0] = 's';
            dizi[8, 1] = 'g';
            dizi[8, 2] = 'l';
            dizi[8, 3] = 'h';
            dizi[8, 4] = 's';
            dizi[8, 5] = 'a';
            dizi[8, 6] = 'u';
            dizi[8, 7] = 'a';
            dizi[8, 8] = 'a';
            dizi[8, 9] = 'ı';
            dizi[8, 10] = 'i';
            dizi[8, 11] = 's';
            dizi[8, 12] = 'n';
            dizi[8, 13] = 'm';
            dizi[8, 14] = 'a';
            dizi[9, 0] = 'u';
            dizi[9, 1] = 'e';
            dizi[9, 2] = 'i';
            dizi[9, 3] = 'y';
            dizi[9, 4] = 'd';
            dizi[9, 5] = 'a';
            dizi[9, 6] = 'ş';
            dizi[9, 7] = 't';
            dizi[9, 8] = 'y';
            dizi[9, 9] = 'd';
            dizi[9, 10] = 'h';
            dizi[9, 11] = 'o';
            dizi[9, 12] = 't';
            dizi[9, 13] = 'y';
            dizi[9, 14] = 'h';
            dizi[10, 0] = 'p';
            dizi[10, 1] = 'a';
            dizi[10, 2] = 'l';
            dizi[10, 3] = 'i';
            dizi[10, 4] = 'k';
            dizi[10, 5] = 'h';
            dizi[10, 6] = 'u';
            dizi[10, 7] = 'k';
            dizi[10, 8] = 'r';
            dizi[10, 9] = 'a';
            dizi[10, 10] = 'm';
            dizi[10, 11] = 'b';
            dizi[10, 12] = 'i';
            dizi[10, 13] = 'n';
            dizi[10, 14] = 'a';
            dizi[11, 0] = 'b';
            dizi[11, 1] = 'k';
            dizi[11, 2] = 'a';
            dizi[11, 3] = 'a';
            dizi[11, 4] = 'n';
            dizi[11, 5] = 't';
            dizi[11, 6] = 'b';
            dizi[11, 7] = 's';
            dizi[11, 8] = 'a';
            dizi[11, 9] = 's';
            dizi[11, 10] = 'n';
            dizi[11, 11] = 'z';
            dizi[11, 12] = 'k';
            dizi[11, 13] = 'ı';
            dizi[11, 14] = 'c';
            dizi[12, 0] = 'n';
            dizi[12, 1] = 't';
            dizi[12, 2] = 'r';
            dizi[12, 3] = 'a';
            dizi[12, 4] = 'i';
            dizi[12, 5] = 'f';
            dizi[12, 6] = 'c';
            dizi[12, 7] = 'b';
            dizi[12, 8] = 'k';
            dizi[12, 9] = 'a';
            dizi[12, 10] = 'd';
            dizi[12, 11] = 'e';
            dizi[12, 12] = 'm';
            dizi[12, 13] = 'e';
            dizi[12, 14] = 'ç';
            dizi[13, 0] = 'l';
            dizi[13, 1] = 'ö';
            dizi[13, 2] = 'c';
            dizi[13, 3] = 'a';
            dizi[13, 4] = 'z';
            dizi[13, 5] = 'e';
            dizi[13, 6] = 'd';
            dizi[13, 7] = 'g';
            dizi[13, 8] = 'p';
            dizi[13, 9] = 'n';
            dizi[13, 10] = 'v';
            dizi[13, 11] = 'c';
            dizi[13, 12] = 'c';
            dizi[13, 13] = 'm';
            dizi[13, 14] = 'k';
            dizi[14, 0] = 'ş';
            dizi[14, 1] = 'a';
            dizi[14, 2] = 'j';
            dizi[14, 3] = 'h';
            dizi[14, 4] = 'f';
            dizi[14, 5] = 'r';
            dizi[14, 6] = 's';
            dizi[14, 7] = 'u';
            dizi[14, 8] = 's';
            dizi[14, 9] = 'a';
            dizi[14, 10] = 'k';
            dizi[14, 11] = 't';
            dizi[14, 12] = 'u';
            dizi[14, 13] = 'i';
            dizi[14, 14] = 'y';

            for (int i=0;i<15;i++)
            {
                for(int j=0;j<15;j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                    
                }
                Console.WriteLine(" ");
            }
            // kocaeli, bayrak, turuncu, kaan, manisa, deniz, aşk
            //girinti, boyun, çalı, susak, armut, izohips, bina, tarla, patika 

            
            string bosluk = Console.ReadLine();
            Console.ReadKey();


            bool varmi = false;
            
            char aranan = 'k';
            foreach (char deger in dizi)
            {
                if(aranan==deger)
                {
                    varmi = true;
                }
            }
            if(varmi==true)
            {
                aranan = 'a';
                
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }   
                }
                if(varmi==true)
                {
                    aranan = 'a';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }
                    }
                    if(varmi==true)
                    {
                        aranan = 'n';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if(varmi==true)
                        {
                            Console.WriteLine("kaan");
                        }
                    }
                }
            }
            aranan = 'ç';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }
            }
            if(varmi==true)
            {
                aranan = 'a';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if(varmi==true)
                {
                    aranan = 'l';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if(varmi==true)
                    {
                        aranan = 'ı';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if(varmi==true)
                        {
                            Console.WriteLine("çalı");
                        }
                    }
                }
            }
            aranan = 'm';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if(varmi==true)
            {
                aranan = 'a';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if(varmi==true)
                {
                    aranan = 'n';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if(varmi==true)
                    {
                        aranan = 'i';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if(varmi==true)
                        {
                            aranan = 's';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if(varmi==true)
                            {
                                aranan = 'a';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if(varmi==true)
                                {
                                    Console.WriteLine("manisa");
                                }
                            }
                        }

                    }
                }
                aranan = 't';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'u';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'r';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'u';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 'n';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    aranan = 'c';
                                    foreach (char deger in dizi)
                                    {
                                        if (aranan == deger)
                                        {
                                            varmi = true;
                                        }

                                    }
                                    if (varmi == true)
                                    {
                                        aranan = 'u';
                                        foreach (char deger in dizi)
                                        {
                                            if (aranan == deger)
                                            {
                                                varmi = true;
                                            }

                                        }
                                        if (varmi == true)
                                        {
                                            Console.WriteLine("turuncu");
                                        }
                                    }
                                }
                            }    
                        }
                    }
                }

            }
            aranan = 'b';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'a';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'y';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'r';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'a';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 'k';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    Console.WriteLine("bayrak");
                                }
                            }
                        }
                    }
                }
            }
            aranan = 'd';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'e';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'n';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'i';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'z';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                                Console.WriteLine("deniz");
                        }
                    }
                }
            }
            aranan = 't';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'a';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'r';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'l';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'a';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                Console.WriteLine("tarla");
                            }
                        }
                    }
                }
            }
            aranan = 'b';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'o';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'y';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'u';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'n';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                Console.WriteLine("boyun");
                            }
                        }
                    }
                }
            }
            aranan = 'g';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'i';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'r';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'i';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'n';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 't';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    aranan = 'i';
                                    foreach (char deger in dizi)
                                    {
                                        if (aranan == deger)
                                        {
                                            varmi = true;
                                        }

                                    }
                                    if (varmi == true)
                                    {
                                        Console.WriteLine("girinti");
                                    }

                                }
                            }
                        }
                    }
                }
            }
            aranan = 'a';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'r';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'm';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'u';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 't';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                Console.WriteLine("armut");
                            }
                        }
                    }
                }
            }
            aranan = 'b';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'i';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'n';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'a';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            Console.WriteLine("bina");
                        }
                    }
                }
            }
            aranan = 'p';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'a';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 't';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'i';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'k';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 'a';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    Console.WriteLine("patika");
                                }
                            }
                        }
                    }
                }
            }
            aranan = 'i';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'z';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'o';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'h';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'i';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 'p';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    aranan = 's';
                                    foreach (char deger in dizi)
                                    {
                                        if (aranan == deger)
                                        {
                                            varmi = true;
                                        }

                                    }
                                    if (varmi == true)
                                    {
                                        Console.WriteLine("izohips");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            aranan = 's';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'u';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 's';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'a';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'k';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                Console.WriteLine("susak");
                            }
                        }
                    }
                }
            }
            aranan = 'k';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'o';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'c';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        aranan = 'a';
                        foreach (char deger in dizi)
                        {
                            if (aranan == deger)
                            {
                                varmi = true;
                            }

                        }
                        if (varmi == true)
                        {
                            aranan = 'e';
                            foreach (char deger in dizi)
                            {
                                if (aranan == deger)
                                {
                                    varmi = true;
                                }

                            }
                            if (varmi == true)
                            {
                                aranan = 'l';
                                foreach (char deger in dizi)
                                {
                                    if (aranan == deger)
                                    {
                                        varmi = true;
                                    }

                                }
                                if (varmi == true)
                                {
                                    aranan = 'i';
                                    foreach (char deger in dizi)
                                    {
                                        if (aranan == deger)
                                        {
                                            varmi = true;
                                        }

                                    }
                                    if (varmi == true)
                                    {
                                        Console.WriteLine("kocaeli");
                                    }
                                }
                            }
                        }

                    }    
                }
            }
            aranan = 'a';
            foreach (char deger in dizi)
            {
                if (aranan == deger)
                {
                    varmi = true;
                }

            }
            if (varmi == true)
            {
                aranan = 'ş';
                foreach (char deger in dizi)
                {
                    if (aranan == deger)
                    {
                        varmi = true;
                    }

                }
                if (varmi == true)
                {
                    aranan = 'k';
                    foreach (char deger in dizi)
                    {
                        if (aranan == deger)
                        {
                            varmi = true;
                        }

                    }
                    if (varmi == true)
                    {
                        Console.WriteLine("aşk");
                    }
                }
            }

                Console.ReadKey();
        }
    }

}

       