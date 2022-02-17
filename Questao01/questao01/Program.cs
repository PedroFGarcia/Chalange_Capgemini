namespace questao01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            String teste = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    teste += " ";
                }
                for (int k = 0; k < i; k++)
                {
                    teste += "*";
                }
                teste += "\n";
            }

            Console.WriteLine(teste);
        }
    }
}