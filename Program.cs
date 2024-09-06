using System.ComponentModel;
using sistemaCadt;
using parteJson;

string ArchivoDeCadetes="Acadetes.csv";
string ArchivoDeCadeteria="Acadeteria.csv";

Cadeteria miCadeteria= Cadeteria.CargarCsv(ArchivoDeCadeteria,ArchivoDeCadetes);
List<Pedidos> ManejoLista= new List<Pedidos>();


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
    using(var reader = new StreamReader(archivoDePedidos)){
        var linea = reader.ReadLine();
        if(linea!= null){
            
        }
        while (!reader.EndOfStream)
        {
            var linea1= reader.ReadLine();
            if (linea1!= null)
            {
                var values = linea1.Split(",");
            
            }
        }
    }
    csv.GuardarPedidosEnCsv(archivoDePedidos, ManejoLista);



