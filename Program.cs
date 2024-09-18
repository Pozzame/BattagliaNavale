class Program
{
    public static void Main(string[] args){
        Console.WriteLine("----Battaglia Navale----");
        Console.WriteLine("Come ti chiami?");
        string NomeUtente = Console.ReadLine()!;
        Console.WriteLine("Scegli il nome della tua portaerei.");
        Portaerei portarei = new Portaerei(Console.ReadLine()!);
        Console.WriteLine("Scegli il nome del tuo incrociatore.");
        Portaerei incrociatore = new Portaerei(Console.ReadLine()!);
        Console.WriteLine("Scegli il nome della tua motosilurante.");
        Portaerei motosilurante = new Portaerei(Console.ReadLine()!);
        Console.WriteLine("Scegli il nome del tuo sottomarino.");
        Portaerei sottomarino = new Portaerei(Console.ReadLine()!);

    }
}

abstract class Nave{
    private string nome;
    private int armatura;
    private int magazzino;
    private int vita;
    public string Nome { get => nome; }
    public int Armatura { get => armatura; set => armatura = value; }
    public int Magazzino { get => magazzino; set => magazzino = value; }
    public int Vita { get => vita; set => vita = value; }

    public Nave(string nome){
        this.nome = nome;
    }
}

class Portaerei : Nave
{
    public Portaerei(string nome) : base(nome)
    {
    }
}
class Incrociatore : Nave
{
    public Incrociatore(string nome) : base(nome)
    {
    }
}
class Sottomarino : Nave
{
    public Sottomarino(string nome) : base(nome)
    {
    }
}
class Motosilurante : Nave
{
    public Motosilurante(string nome) : base(nome)
    {
    }
}