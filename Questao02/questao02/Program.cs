namespace questao01
{
    public class Program
    {
        public static void Main()
        {
            string senha = Console.ReadLine();

            if (senha.Length < 6)
            {
                int sugestao = 6 - senha.Length;
                Console.WriteLine($"Senha muito curta, adicione {sugestao} caracteres!");
            }
            else
            {
                Console.WriteLine("Senha segura!");
            }
        }
    }
}