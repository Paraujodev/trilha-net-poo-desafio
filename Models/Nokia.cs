namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
    
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Console.WriteLine ($"Esse é meu numero: {numero}, modelo: {modelo}, Nº imei:{imei} com memória de {memoria}GB");
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado no seu Nokia!");
        }
    }
}