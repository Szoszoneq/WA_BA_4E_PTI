using System;
/*
Nazwa: Notatka
Opis: Klasa reprezentuje notatke
Pola: licznik,id,tresc i tytul 
Metody: Notatka, wyswietl, diagnotsyka, 
Autor: Waleczek Bartosz
*/
public class Notatka
{
    private static int licznik;
    private int id;
    protected string tresc;
    protected string tytul;

    public Notatka(string tytulP, string trescP){
        licznik++;
        id = licznik;
        tytul = tytulP;
        tresc = trescP;
    }
    public void wyswietl()
    {
        Console.WriteLine("------Notatka"+id+"------");
        Console.WriteLine(tytul);
        Console.WriteLine(tresc);
        Console.WriteLine("-------------------");
    }
    public void diagnostyka()
    {
        Console.WriteLine("---------------------------Diagnostyka"+id+"-----------------------------");
        Console.WriteLine("Licznik:"+licznik+";"+"Id:"+id+";"+"Tytul:"+tytul+";"+"Tresc:"+tresc);
        Console.WriteLine("-------------------------------------------------------------------------");
    }
    public static void Main()
    {
        Notatka n1 = new Notatka("Plan lekcji", "Matematyka, Polski, Informatyka, Pracownia projektowania obiektowego");
        Notatka n2 = new Notatka("Lista zakupów", "Chleb, Masło, Szynka, Ser, Mleko");
        n1.wyswietl();
        n1.diagnostyka();
        n2.wyswietl();
        n2.diagnostyka();

    }
}

