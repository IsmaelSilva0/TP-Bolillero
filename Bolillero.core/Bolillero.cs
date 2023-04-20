namespace Bolillero.core;
public class Bolillero
{
    public List<int> adentro { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> afuera { get; set; }

    public IRandom Random { get; set; }

    public Bolillero()
    {
        this.adentro = new List<int>();
        this.Jugada = new List<int>();
        this.afuera = new List<int>();
    }

    public int SacarBolillas()
    {
        var indice = Randomazar.SacarIndice(this.numeros);
        var numero = indice;
        this.afuera.Add(indice);
        this.adentro.Remove(indice);
    }

    public bool Jugar(List<int> jugada)
    {
        var indice = Randomazar.SacarIndice(this.numeros);
        return false;
    }

    public int JugarNVeces(List<int> Jugada, int cantidad)
    {
        var Victoria = 0;

        Jugar(Jugada);

        return Victoria;
    }

}

