namespace PrimerMvcNetCore.Models
{
    public class FilaTablaMultiplicar
    {
        public FilaTablaMultiplicar(string operacion, int resultado)
        {
            Operacion = operacion;
            Resultado = resultado;
        }

        public string Operacion { get; set; }
        public int Resultado { get; set; }
    }
}
