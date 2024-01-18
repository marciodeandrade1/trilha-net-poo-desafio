namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone()
        {
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
    {
        // Lógica para instalar o aplicativo no iPhone
        // Por exemplo:
        Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
    }
    }
}