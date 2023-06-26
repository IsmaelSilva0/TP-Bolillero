namespace Bolillero.core;

public class Simulacion
{
    long simularSinHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones)

    => bolillero.JugarNVeces(jugada, cantsimulaciones);
    long simularConHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones, int cantHilos)
    {
    Task<long>[] simulaciones = new Task<long>[cantHilos];
    Array.ForEach(simulaciones, t => t.Start());
    for ( int i = 0; i <= cantHilos;i++)
        {
            
        }
    }
}
