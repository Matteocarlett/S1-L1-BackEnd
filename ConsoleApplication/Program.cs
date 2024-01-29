using System;

internal class Program
{
    static void Main(string[] args)
    {
        Dovahkiin dovahkiin = new Dovahkiin
        {
            Nome = "Dovahkiin",
            Razza = "Imperiale",
            Classe = "Mago",
            Urlo = "Fus-roh-dah",
            Livello = 50
        };

        Tullius tullius = new Tullius
        {
            Titolo = "Generale",
            Razza = "Imperiale",
            Origini = "Cyrodil",
            LuogoAttuale = "Skyrim"
        };
        Shadowmere shadowmere = new Shadowmere
        {
            Animale = "Cavallo",
            Razza = "Ombra",
            Casa = "Confraterita Oscura"
        };

        Console.WriteLine(dovahkiin.DescrizionePersonaggio());
        dovahkiin.Combatti();

        Console.WriteLine(tullius.DescrizionePersonaggiodue());
        tullius.Solitude();

        Console.WriteLine(shadowmere.DescrizioneAnimale());

        Console.ReadLine();
    }
}

public class Dovahkiin
{
    public string Nome;
    public string Razza;
    public string Classe;
    public string Urlo;
    public int Livello;

    public string DescrizionePersonaggio()
    {
        return $"Il {Nome} è un {Razza}, che fa il {Classe}, al livello {Livello}. Predilige il {Urlo}";
    }

    public void Combatti()
    {
        Console.WriteLine($"Il {Nome} sta uccidendo Ulfric Manto della Tempesta");
    }
}

public class Tullius {

    public string Titolo;
    public string Razza;
    public string Origini;
    public string LuogoAttuale;

    public string DescrizionePersonaggiodue()
    {
        return $"Il {Titolo} Tullius è un {Razza}, di {Origini}, mandato per riportare l'ordine a {LuogoAttuale} ";
    }
    public void Solitude()
    {
        Console.WriteLine($"Il {Titolo} Tullius odia i Manto della Tempesta");
    }
}

public class Shadowmere
{
    public string Animale;
    public string Razza;
    public string Casa;

    public string DescrizioneAnimale()
    {
        return $"Shadowmere è un {Animale} {Razza}, di proprietà della {Casa}, uno dei cavalli più veloci di tutta skyrim";
    }
}
