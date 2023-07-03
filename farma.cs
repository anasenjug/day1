public abstract class Zivotinja
{
    public string ime;
    public string pasmina;
    public int stupanjSrece;

    public abstract void Glasanje();


}

public interface IZivotinja
{
    void Crtez();
}

public class Konj : Zivotinja, IZivotinja
{
    public Konj(string ime, string pasmina, int stupanjSrece)
    {
        this.ime = ime;
        this.pasmina = pasmina;
        this.stupanjSrece = stupanjSrece;
    }
    public override void Glasanje()
    {
        Console.WriteLine("njiha\n");

    }

    public void Crtez()
    {
        Console.Write("     _ ____\r\n     /( ) _   \\\r\n    / //   /\\` \\,  ||--||--||-\r\n      \\|   |/  \\|  ||--||--||-\r\n~^~^~^~~^~~~^~~^^~^^^^^^^^^^^^");
    }

}

public class Krava : Zivotinja, IZivotinja
{
    public override void Glasanje()
    {
        Console.WriteLine("moo\n");

    }
    public void Crtez()
    {
        Console.Write("\\|/          (__)    \r\n     `\\------(oo)\r\n       ||    (__)\r\n       ||w--||     \\|/\r\n   \\|/");
    }
}

class Farma
{
    static void Main(string[] args)
    {
        Konj bero = new Konj("Bero", "frizijski konj", 7);


        Krava milka = new Krava();
        milka.ime = "Milka";
        milka.pasmina = "europska grbava krava";
        milka.stupanjSrece = 9;

        List<Zivotinja> zivotinje = new List<Zivotinja>();
        zivotinje.Add(bero);
        zivotinje.Add(milka);

        zivotinje.Add(new Konj("Kiki", "andaluzijski konj", 5));

        int brojZivotinja = 0;
        int sumaSrece = 0;
        foreach (Zivotinja zivotinja in zivotinje)
        {

            brojZivotinja++;
            sumaSrece += zivotinja.stupanjSrece;
            Console.Write(brojZivotinja + "." + zivotinja + " : " + zivotinja.ime + ", pasmina: " + zivotinja.pasmina + ", glasanje: ");
            zivotinja.Glasanje();


        }
        float prosjekSrece = sumaSrece / brojZivotinja;
        if (prosjekSrece < 5)
        {
            Console.WriteLine("Vas prosjek srece je: " + prosjekSrece + "\n. Vase zivotinje su nesretne i nezbrinute, morate se vise potruditi");
        }
        else if (prosjekSrece > 5 && prosjekSrece < 8)
        {
            Console.WriteLine("Vas prosjek srece je: " + prosjekSrece + "\n Vase zivotinje imaju zbrinute osnovne potrebe, no treba im zabave");
        }
        else
        {
            Console.WriteLine("Vas prosjek srece je: " + prosjekSrece + "\n.Bravo!Vase zivotinje su vrlo sretne te uzivaju :)");
        }
        if (milka.stupanjSrece > 8)
        {
            Console.WriteLine(milka.ime + " je vrlo zadovoljna te vam poklanja jedan crtez!\n");
            milka.Crtez();
        }

    }


}


