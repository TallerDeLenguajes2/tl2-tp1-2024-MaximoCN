using System.ComponentModel;
using sistemaCadt;

string ArchivoDeCadetes="Acadetes.csv";
string ArchivoDeCadeteria="Acadeteria.csv";

Cadeteria miCadeteria= Cadeteria.CargarCsv(ArchivoDeCadeteria,ArchivoDeCadetes);

Cliente cliente=new Cliente(){
    Nombre="MAXI",
    Direccion="su casa"
};

List<Pedidos> pedidos= new List<Pedidos>();





while (true)
{
    Console.WriteLine("1) DAR DE ALTA UN PEDIDO");
    Console.WriteLine("2) Asigarlo a un cadete");
    Console.WriteLine("3) Cambiarlo de Estado");
    Console.WriteLine("4) Reasignar el pedido");
    Console.WriteLine("Seleccione La Opcion:");
    var Opcion= Console.ReadLine();

    
    switch (Opcion)
    {
        case "1":
                Pedidos nuevoPe= Pedidos.crearPedido(1,"PIZZ",cliente,Estado.Aceptado);
                pedidos.Add(nuevoPe);
                
        break;

    }
}



