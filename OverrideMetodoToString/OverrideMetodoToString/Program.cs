using OverrideMetodoToString;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto objeto1 = new Objeto();
            objeto1.Name = "Fulano";
            objeto1.Classificacao = 10;

            Console.WriteLine(objeto1);

        }
    }
}