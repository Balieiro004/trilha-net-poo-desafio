namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        //ok TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
            Console.WriteLine("Tecle Qualquer tecla para finalizar a instalação....");
            Console.ReadLine();
        }

        public override void MostrarModelo()
        {
            Console.WriteLine("Nokia");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"O modelo é: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
        }
    }
}