namespace EstatisticaAPI.Models
{
    public interface IEstatistica
    {
        double mediana(string[] m);
        double moda(string[] m);
        double media(string[] m);
        double maximo(string[] m);
        double minimo(string[] m);
        double mediaponderada(string[] m);
        double CalcularDesvioPadrao(string[] m);
    } 
}