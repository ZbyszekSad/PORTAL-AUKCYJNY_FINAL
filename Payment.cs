using PORTAL_AUKCYJNY;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PORTAL_AUKCYJNY
{

    //clasa karty
    public class
          Payment
    {
        public string? Nazwa { get; set; }
        public string? Numer { get; set; }
        public int Saldo { get; set; }

        //klient wprowadza numer karty



        public void GetProduct()
        {
            var przedmiot = new Przedmiot();
        }
        public void ProvideCard()
        {
            Console.WriteLine();
            Console.Write("Podaj numer karty kredytowej (4 cyfry) =>");
        }
        //wyświetlanie czy transakcja przeszła czy nie
        public int Display()
        {
            int wiadomosc = 1;

            int wrong = 1;
            while (wrong == 1)
            {
                Console.Clear();
                if (wiadomosc == 1)
                {
                    Console.WriteLine(); ;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidłowa karta");
                }
                ProvideCard();
                string cardnumber = Console.ReadLine();
                if (cardnumber.Length != 4)
                {
                    wiadomosc++;

                }
                else
                {
                    wrong = 0;

                }
                string[] KartaNazwa = { "Visa", "Mastercard", "American Express", "Diners Club" };
                string[] KartaNumer = { "0001", "0002", "0003", "0004" };
                int[] KartaSaldo = { 100, 10000, 3000, 1000 };
                GetProduct();
                if (KartaNumer.Contains(cardnumber))
                {
                    int saldocheck = 1;
                    while (saldocheck = 1)
                    {

                        switch (cardnumber)

                        {

                            case "0001":

                                if (KartaSaldo[0] > przedmiot.test.Cena)

                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Kupiłeś przedmiot:", przedmiot.test.Item);

                                    Console.WriteLine("Cena:", przedmiot.test.cena);

                                    Console.WriteLine("Płatność kartą:", KartaNazwa[0]);

                                    saldocheck = 0;

                                }

                                else

                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");

                                }

                            case "0002":

                                if (KartaSaldo[1] > przedmiot.test.Cena)

                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Kupiłeś przedmiot:", przedmiot.test.Item);

                                    Console.WriteLine("Cena:", przedmiot.test.cena);

                                    Console.WriteLine("Płatność kartą:", KartaNazwa[0]);

                                    saldocheck = 0;


                                }

                                else

                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");

                                }

                            case "0003":

                                if (KartaSaldo[2] > przedmiot.test.Cena)

                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Kupiłeś przedmiot:", przedmiot.test.Item);

                                    Console.WriteLine("Cena:", przedmiot.test.cena);

                                    Console.WriteLine("Płatność kartą:", KartaNazwa[0]);

                                    saldocheck = 0;


                                }

                                else


                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");
                                }

                            case "0004":

                                if (KartaSaldo[3] <= przedmiot.test.Cena)

                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Kupiłeś przedmiot:", przedmiot.test.Item);

                                    Console.WriteLine("Cena:", przedmiot.test.cena);

                                    Console.WriteLine("Płatność kartą:", KartaNazwa[0]);

                                    saldocheck = 0;


                                }

                                else

                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");

                                }

                        }

                    else

                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Nieprawidłowa karta");

                    }

                }

                int walidacja;

                return walidacja = 1;



                }


            }

        }
    }
}