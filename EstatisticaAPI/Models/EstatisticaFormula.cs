namespace EstatisticaAPI.Models
{
    public interface IEstatisticaFormula
    {
        double CalcularMediana(string[] m);
        double CalcularModa(string[] m);
        double CalcularMedia(string[] m);
        double CalcularMaximo(string[] m);
        double CalcularMinimo(string[] m);
        double CalcularMediaPonderada(string[] m);
        double CalcularDesvioPadrao(string[] m);
    } 
}