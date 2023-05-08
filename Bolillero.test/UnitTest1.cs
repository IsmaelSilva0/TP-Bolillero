using Bolillero.core;

namespace Bolillero.test;

public class BolilleroTest

{
    public Bolillero1 Bolilleroprueba { get; set; }

    public BolilleroTest() => Bolilleroprueba = new Bolillero1(10, new Azarprimero());


    [Fact]
    public void SacarBolillaTest()
    {
        var numero = Bolilleroprueba.SacarBolillas();
        var esperado = 0;
        var esperado1 = 9;
        var esperado2 = 1;

        Assert.Equal(esperado, numero);
        Assert.Equal(esperado1, Bolilleroprueba.Adentro.Count);
        Assert.Equal(esperado2, Bolilleroprueba.Afuera.Count);
    }

    [Fact]
    public void ReingresarBolillaTest()
    {
        Bolilleroprueba.SacarBolillas();
        Bolilleroprueba.ReingresarBolillas();
        
        var bolillasAdentro = Bolilleroprueba.Adentro.Count;

        Assert.Equal(10, bolillasAdentro);
        Assert.Empty(Bolilleroprueba.Afuera);
    }
    [Fact]
    public void JugarGana()
    {
        var intentoGana = Bolilleroprueba.Jugar(jugada: new List<int>() { 0, 1, 2, 3 });
        Assert.True(intentoGana);
    }

    [Fact]
    public void JugarPierde()
    {
        var intentoPierde = Bolilleroprueba.Jugar(jugada: new List<int> { 4, 2, 1 });

        Assert.False(intentoPierde);
    }

    [Fact]
    public void JugarNVecesGana()
    {
        var jugada = Bolilleroprueba.JugarNVeces(Jugada: new List<int> { 0, 1 }, 1);

        Assert.Equal(1, jugada);
    }


}