
using PORTAL_AUKCYJNY;

var payment = new Payment();
var przedmiot = new Przedmiot();
/*
static void StworzKarte()
{
    List<Payment> karty = new List<Payment>();
    Payment card1 = new Payment();
    card1.Nazwa = "Visa";
    card1.Numer = "0001";
    card1.Saldo = 100;

    Payment card2 = new Payment();
    card2.Nazwa = "Mastercard";
    card2.Numer = "0002";
    card2.Saldo = 10000;

    Payment card3 = new Payment();
    card3.Nazwa = "American Express";
    card3.Numer = "0003";
    card3.Saldo = 3000;

    Payment card4 = new Payment();
    card4.Nazwa = "Diners Club";
    card4.Numer = "0004";
    card4.Saldo = 1000;

    karty.Add(card1);
    karty.Add(card2);
    karty.Add(card3);
    karty.Add(card4);
}
*/
//testowy przedmiot
Przedmiot test = new Przedmiot();
test.Item = "Test";
test.Kategoria = "Kategoria";
test.Cena = 99;
payment.ProvideCard();
payment.Display();

