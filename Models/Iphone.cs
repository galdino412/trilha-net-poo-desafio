namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
 public class Iphone : Smartphone
    {
        // Construtor que utiliza o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método InstalarAplicativoS
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo '{nome}' na App Store do iPhone.");
        }
    }
}