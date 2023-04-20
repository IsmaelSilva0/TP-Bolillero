namespace Bolillero.core;
public class Randomazar : IRandom
{
    private Random _random { get; set; }
    public Randomazar()
        => _random = new Random(DateTime.Now.Millisecond);
    public int SacarIndice(List<int> adentro)
        => _random.Next(0, adentro.Count);
}
