namespace GarageMVC.Models
{ 
 public class Auto
{
    
    public int NumeroAuto { get; set; }
    public string Marca { get; set; }
    public string Placa { get; set; }


    public Auto(int numeroAuto, string marca, string placa)
    {
        NumeroAuto = numeroAuto;
        Marca = marca;
        Placa = placa;
    }
}
}
