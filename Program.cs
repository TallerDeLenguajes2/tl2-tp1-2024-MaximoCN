using System.ComponentModel;
using sistemaCadt;
using parteJson;

string ArchivoDeCadetes="Acadetes.csv";
string ArchivoDeCadeteria="Acadeteria.csv";

Cadeteria miCadeteria= Cadeteria.CargarCsv(ArchivoDeCadeteria,ArchivoDeCadetes);
List<Pedidos> ManejoLista= new List<Pedidos>();
csv listas= new csv();

while (true)
{
   string salida;
    Console.WriteLine("1) DAR DE ALTA UN PEDIDO");
    Console.WriteLine("2) Asigarlo a un cadete");
    Console.WriteLine("3) Cambiarlo de Estado");
    Console.WriteLine("4) Reasignar el pedido");
    Console.WriteLine("Seleccione La Opcion:");
    var Opcion= Console.ReadLine();
    Estado estadoInicial = Estado.Aceptado;

    
    switch (Opcion)
    {
        case "1":
        Pedidos NuevoPedido=Pedidos.crearPedido("obs incial",estadoInicial);
        ManejoLista.Add(NuevoPedido);
        
        
        break;

        case "2":
        
        break;

        case "3":

        break;

        case "4":

        break;
    }


    Console.WriteLine("escriba salir para salir:");
    salida=Console.ReadLine();

    if(salida== "salir"){
        break;
    }


}
    string archivoDePedidos = "pedidos.csv";
    csv.GuardarPedidosEnCsv(archivoDePedidos, ManejoLista);



