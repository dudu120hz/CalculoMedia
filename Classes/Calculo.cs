namespace CalculoMedia.Classes
{
    public class Calculo
    {
        public Calculo(string materia, double diver, double obrig, double atitu)
        {
            double mediaFinal = ((diver + obrig) / 2) + atitu;

            if (mediaFinal > 10.0)
            {
                throw new Exception("\n\n Você digitou alguma nota errado,\n feche o programa e tente novamente \n");
            }
            else
            {
                string aprovacao = mediaFinal > 6 ? "azul" : "vermelha";
                Console.WriteLine($"\n Na matéria de {materia}");
                Console.WriteLine($" sua nota foi {aprovacao}");
                Console.WriteLine($" com média final de {mediaFinal}");
            }
        }
    }
}