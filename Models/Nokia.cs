namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string marca, string modelo, int armazenamentoInterno, int memoriaRAM)
            : base(numero, marca, modelo, armazenamentoInterno, memoriaRAM)
        {
            // Nenhum código adicional necessário no construtor do Nokia
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na loja de aplicativos da Nokia.");
        }
    }
}
