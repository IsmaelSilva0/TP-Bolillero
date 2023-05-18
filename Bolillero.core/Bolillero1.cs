namespace Bolillero.core;
public class Bolillero1
{    
    public List<int> Adentro { get; set; }
    public List<int> Jugada { get; set; }
    public List<int> Afuera { get; set; }
    public IRandom Random { get; set; }

    private Bolillero1 (Bolillero1 original)
    {
        Adentro = new List<int> (original.Adentro);
        Jugada = new List<int> (original.Jugada);
        Random = original.Random;
    }


    public Bolillero1 (int bolillas , IRandom random) 
    {
        this.Adentro = new List<int>();
        CrearBolillas(bolillas);
        this.Jugada = new List<int>();
        this.Afuera = new List<int>();
        this.Random = random;
    }
    public Bolillero1
    Clonar()
    public void CrearBolillas(int bollillas)
    {
        for (int i = 0; i < bollillas;i++)
            Adentro.Add(i);

    }

    public int SacarBolillas()
    {
        var indice = Random.SacarIndice(this.Adentro);
        var numero = Adentro[indice];
        this.Afuera.Add(numero);
        this.Adentro.Remove(numero);
        return numero;
    }

    public bool Jugar(List<int> jugada) 
    {
        for (int i = 0; i < jugada.Count();i++) 
        {   
            var indicejugada = SacarBolillas();
            if (indicejugada != jugada[i])
                return false; 
        } 
            return true;
    }

    public int JugarNVeces(List<int> Jugada, int cantidad)
    {
        var Victoria = 0;
        for ( int i = 0; i <= cantidad;i++)
        {
            var jugadaAcertada = Jugar(Jugada);
            if (jugadaAcertada == true)
                Victoria += 1;
        }

            return Victoria;
    }
    public void ReingresarBolillas()
    {
        Adentro.AddRange(Afuera);
        Afuera.Clear();
    }

}

