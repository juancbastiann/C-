namespace EjerciciosconClases
{
  class Cliente
  {
    private string nombre;
    private int monto;

    public string Nombre
    {
      get { return nombre; }
      private set { nombre = value; }
    }

    public int Monto
    {
      get { return monto; }
      private set { monto = value; }
    }

    public Cliente(string nombre)
    {
      Nombre = nombre;
      Monto = 0;
    }

    public void Depositar(int monto)
    {
      if (monto > 0)
      {
        Monto += monto;
      }
      else
      {
        Console.WriteLine("El monto a depositar debe ser positivo.");
      }
    }

    public void Extraer(int monto)
    {
      if (monto > 0)
      {
        if (Monto >= monto)
        {
          Monto -= monto;
        }
        else
        {
          Console.WriteLine("Fondos insuficientes.");
        }
      }
      else
      {
        Console.WriteLine("El monto a extraer debe ser positivo.");
      }
    }

    public int RetornarMonto()
    {
      return Monto;
    }

    public void Imprimir()
    {
      Console.WriteLine($"{Nombre} tiene depositado la suma de {Monto}");
    }
  }

  class Banco
  {
    private Cliente cliente1, cliente2, cliente3;

    public Banco()
    {
      cliente1 = new Cliente("Juan");
      cliente2 = new Cliente("Paula");
      cliente3 = new Cliente("Carlos");
    }

    public void Operar()
    {
      cliente1.Depositar(100);
      cliente2.Depositar(150);
      cliente3.Depositar(200);
      cliente3.Extraer(150);
    }

    public void DepositosTotales()
    {
      int totalDepositos = cliente1.RetornarMonto() +
                          cliente2.RetornarMonto() +
                          cliente3.RetornarMonto();
      Console.WriteLine($"El total de dinero en el banco es: {totalDepositos}");
      cliente1.Imprimir();
      cliente2.Imprimir();
      cliente3.Imprimir();
    }

    static void Main(string[] args)
    {
      Banco banco = new Banco();
      banco.Operar();
      banco.DepositosTotales();
      Console.ReadKey();
    }
  }
}
