using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int ArmazenamentoInterno { get; set; }
        public int MemoriaRAM { get; set; }

        public Smartphone(string numero, string marca, string modelo, int armazenamentoInterno, int memoriaRAM)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            ArmazenamentoInterno = armazenamentoInterno;
            MemoriaRAM = memoriaRAM;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}