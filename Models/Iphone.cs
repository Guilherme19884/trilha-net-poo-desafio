namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string marca, string modelo, int armazenamentoInterno, int memoriaRAM)
            : base(numero, marca, modelo, armazenamentoInterno, memoriaRAM)
        {
            // Nenhum código adicional necessário no construtor do Iphone
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na loja de aplicativos da Apple.");
        }
    }
}