using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_u1_l3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 per conto corrente, 2 per nomi, 3 per array: ");
            int nProg = Convert.ToInt16( Console.ReadLine());

            if (nProg == 1)
            {

                Console.Write("nome dell'intestatario del conto: ");
                string nome = Console.ReadLine();


                int tot = 0;
                while (tot < 1000)
                {
                    Console.Write("importo per apertura del conto (minimo 1000$): ");
                    tot = Convert.ToInt16(Console.ReadLine());
                }

                Conto c1 = new Conto(nome, tot);


                int scelta = 0;
                while (scelta != 3)
                {
                    Console.Write("Premi 1 per prelevare, 2 per depositare o 3 per uscire: ");
                    scelta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    if (scelta == 1)
                    {
                        int prelievo = 0;
                        int sceltaPre = 0;
                        do
                        {
                            Console.Write("totale conto: ");
                            Console.Write(c1.Totale);
                            Console.Write("\n");
                            Console.Write("cifra da prelevare: ");
                            prelievo = Convert.ToInt32(Console.ReadLine());
                            if (prelievo <= c1.Totale)
                            {
                                c1.Prelievo(prelievo);
                                Console.WriteLine("saldo attuale: " + c1.Totale);
                                Console.Write("\n");

                                Console.WriteLine("premi 1 per fare un altro prelievo, 2 per uscire: ");
                                sceltaPre = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n");
                            }
                            else
                            {
                                Console.WriteLine("non disponi di quella cifra");
                            }

                        } while (sceltaPre != 2);


                    }
                    else if (scelta == 2)
                    {
                        int sceltaDep = 0;
                        do
                        {
                            Console.Write("cifra da depositare: ");
                            int deposito = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\n");
                            c1.Deposito(deposito);
                            Console.WriteLine("saldo attuale: " + c1.Totale);
                            Console.Write("\n");
                            Console.WriteLine("premi 1 per fare un altro deposito, 2 per uscire: ");
                            sceltaDep = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\n");
                        } while (sceltaDep != 2);
                    }
                    else
                    {
                        Console.WriteLine("Arrivederci " + c1.Intestatario);
                    }
                }
            }
            else if (nProg == 2)
            {
                string[] nomi = new string[10];
                for (int i = 0; i < nomi.Length; i++)
                {
                    Console.Write($"inserire il {i + 1} nome: ");
                    nomi[i] = Console.ReadLine();
                }

                Console.Write($"inserire il nome da ricercare: ");
                string ricerca = Console.ReadLine();
                Console.Write("\n");

                foreach (string s in nomi)
                {
                    if (s == ricerca)
                    {
                        Console.WriteLine(s + " trovato");
                    }
                }


            }
            else if (nProg == 3)
            {

                Console.WriteLine("Quanti numeri vuoi inserire?");
                int lunArr = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[lunArr];
                for (int i = 0; i < lunArr; i++)
                {
                    Console.Write($"inserire il {i + 1} numero: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sommaArr = 0;
                

                for (int i = 0; i < lunArr; i++)
                {
                   sommaArr += arr[i];
                }
                Console.WriteLine($"Somma dei numeri: {sommaArr}");
                float mediaArr = sommaArr / arr.Length;
                Console.WriteLine("Media numeri: " + mediaArr);


            }
            else
            {
                
                Console.WriteLine("programma non trovato");
            }


            Console.ReadLine();
        }
    }
}
