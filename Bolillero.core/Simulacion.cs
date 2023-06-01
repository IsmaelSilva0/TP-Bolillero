namespace Bolillero.core;

public class Simulacion
{
    long simularSinHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones)

    => bolillero.JugarNVeces(jugada, cantsimulaciones);
    long simularConHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones, int cantHilos)
    {
    Task<long>[] cantsimulaciones = new Task<long>[cantHilos];
    for ( int i = 0; i <= cantHilos;i++)
        {

        }
    }
}
