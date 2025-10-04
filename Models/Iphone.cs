namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
            Console.WriteLine("Tecle Qualquer tecla para finalizar a instalação....");
            Console.ReadLine();
        }

        public override void MostrarModelo()
        {
            Console.WriteLine("Iphone");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"O modelo é: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
        }
    }
}