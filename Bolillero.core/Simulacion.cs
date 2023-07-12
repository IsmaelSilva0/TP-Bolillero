namespace Bolillero.core;

public class Simulacion
{
    public long simularSinHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones)

    => bolillero.JugarNVeces(jugada, cantsimulaciones);
    public long simularConHilos(Bolillero1 bolillero, List<int> jugada, int cantsimulaciones, int cantHilos)
    {
        Task<long>[] simulaciones = new Task<long>[cantHilos];
        var tareas = cantsimulaciones / cantHilos;

    for ( int i = 0; i <= cantHilos;i++)
        {
            var Bolillerocopia = bolillero.Clonar();
            Simulacion[i] = Task<long>.run(() => (long)Bolillerocopia.JugarNVeces(jugada, tareas));

        }
        Task<long>.WaitAll(simulaciones);
        
        return Simulacion.Sum(s => s.Result);
    }
}
