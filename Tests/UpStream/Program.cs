using UpStream;

Contrato c = new Contrato {
    Id = 1,
    Cliente = new Cliente {
        Id = 1,
        Tipo = 1,
        Nombre = "Cliente con dirección",
        Direccion = new Direccion { Calle = "Madre Sacramento" }
    }
};

Contrato c2 = new Contrato
{
    Id = 2,
    Cliente = new ClienteSinDir
    {
        Id = 2,
        Tipo = 2,
        Nombre = "Cliente sin dirección"
    }
};

ImprimirContrato(c);
ImprimirContrato(c2);

static void ImprimirContrato(Contrato contrato)
{
    if(contrato.Cliente.GetType() == typeof(Cliente))
    {
        Cliente newCliente = (Cliente)contrato.Cliente;
        Console.WriteLine(newCliente.Direccion.Calle);
    }
    else
    {
        Console.WriteLine(contrato.Cliente.Nombre);
    }
}