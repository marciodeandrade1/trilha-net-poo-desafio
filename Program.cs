using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
public class Program
{
    private static void Main(string[] args)
    {
        static void Main()
        {
            TestarNokia();
            TestarIphone();
            Console.ReadLine();
        }

        static void TestarNokia()
        {
            // Criar uma instância da classe Nokia
            Nokia nokia = new Nokia();

            // Chamar o método InstalarAplicativo da classe Nokia
            nokia.InstalarAplicativo("WhatsApp");
        }

        static void TestarIphone()
        {
            // Criar uma instância da classe Iphone
            Iphone iphone = new Iphone();

            // Chamar o método InstalarAplicativo da classe Iphone
            iphone.InstalarAplicativo("Instagram");
        }
    }
}