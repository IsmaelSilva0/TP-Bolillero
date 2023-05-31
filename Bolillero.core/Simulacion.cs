namespace Bolillero.core;

public class Simulacion
{
    long simularSinHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones)

    => bolillero.JugarNVeces(jugada, cantsimulaciones);
    long simularConHilos(Bolillero1 bolillero1, List<int> jugada, int cantsimulaciones, int cantHilos)
    {
    Task<int>[] cantsimulaciones = new Task<int>[cantHilos]
    Array.ForEach(cantsimulaciones, t => t.Start());
    Task<int>.WaitAll(cantHilos);
    => bolillero.JugarNVeces(jugada, cantsimulaciones, cantHilos)
    }
}
