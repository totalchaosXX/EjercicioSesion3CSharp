Cliente miCliente = new Cliente("Miguel Salinas Lueyza", 995467195,"Carmen 1125, Santiago", "mi.salinaslueyza@gmail.com",true);

Console.WriteLine("Nombre: "+miCliente.Nombre_completo);   
Console.WriteLine("Teléfono: "+miCliente.Telefono);   
Console.WriteLine("Dirección: " + miCliente.Direccion);   
Console.WriteLine("Email: " + miCliente.Email);
string es_nuevo = string.Empty;
switch (miCliente.Nuevo)
{
    case true : es_nuevo = "SI";
        break;
    case false: es_nuevo = "NO";
        break;
    default: es_nuevo = "NO";
        break;
}
Console.WriteLine("¿Es Nuevo?: " + es_nuevo);

public struct Cliente
{
    public Cliente(string nombre_completo, int telefono, string direccion, string email, bool nuevo)
    {
        Nombre_completo= nombre_completo;
        Telefono= telefono;
        Direccion= direccion;
        Email= email;
        Nuevo= nuevo;

    }

    public string Nombre_completo { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool Nuevo { get; set; }

    public override string ToString() => $"({Nombre_completo},{Telefono},{Direccion},{Email}, {Nuevo})";
 
}