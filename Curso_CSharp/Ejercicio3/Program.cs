Cliente cliente = new Cliente("Cristian C", "+593897xxxx2", "Quito, Ecuador", "cristianc.developer@example.com", "Si");

Console.WriteLine(cliente.Nombre);
Console.WriteLine(cliente);


public struct Cliente
{
    public Cliente(string nombre, string telefono, string direccion, string email, string esNuevoCliente)
    {
        Nombre=nombre;
        Telefono=telefono;
        Direccion=direccion;
        Email=email;
        EsNuevoCliente=esNuevoCliente;
    }

    public string Nombre{ get; set;}
    public string Telefono{ get; set;}
    public string Direccion{ get; set;}
    public string Email{ get; set;}
    public string EsNuevoCliente{ get; set;}

    public override string ToString() => $"CLIENTE\nNombre Completo; {Nombre}\nTelefono: {Telefono}\nDireccion: {Direccion}\nEmail: {Email}\nEsNuevoCliente: {EsNuevoCliente}";

}
