namespace sistemaCadt; 
using Microsoft.Win32.SafeHandles;

public enum Estado
{
    Aceptado,
    Cancelado,
    CambioDeCadete,
    
}
public class Cliente{
    private string nombre;
    private string direccion;
    private string telefono;
    private string datosDirecc;
   
     public Cliente(string Nombre, string Direccion)
    {
        nombre = Nombre;
        direccion = Direccion;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string DatosDirecc { get => datosDirecc; set => datosDirecc = value; }
}

public class Pedidos{
   public static List<Pedidos> listaPedidos= new List<Pedidos>();
    private static int numpedidosS=0;
    private int numPedido;
    private string observacion;
    public Cliente Cliente{get; set;}
    public  Estado EstadoPedido{get;set;}
    public int NumPedido { get => numPedido; set => numPedido = value; }
    public string Observacion { get => observacion; set => observacion = value; }

    public Pedidos(string observacion,Cliente cliente, Estado estadoPedido){
        this.NumPedido = ++numpedidosS;
        this.Observacion = observacion;
        this.Cliente = cliente; // Composición: se inicializa en el constructor
        this.EstadoPedido = estadoPedido;
        listaPedidos.Add(this);
    }
    public static Pedidos crearPedido( string observacion, Estado estado){
        
        Console.WriteLine("Ingrese Nombre del cliente :");
        string nombrePe=Console.ReadLine();

        Console.WriteLine("Ingrese la direccion del cliente:");
        string direcPe=Console.ReadLine();
        
        Cliente cliente = new Cliente(nombrePe,direcPe);

        Console.WriteLine("Ingrese observacion del pedido :");
        observacion=Console.ReadLine();

        return new Pedidos(observacion,cliente,estado);
    }



public string VerDireccionCliente(){
      return Cliente.Direccion;
}
public void VerDatosCliente(){
   Console.WriteLine(Cliente.Nombre);
   Console.WriteLine(Cliente.Telefono);
   Console.WriteLine(Cliente.Direccion);
}
    
}
public class Cadete{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    public List<Pedidos> listadoPedidos{get;set;}
    public Cadete(int id, string nombre,string direccion,string telefono){
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        listadoPedidos = new List<Pedidos>(); // Inicializa la lista de pedidos
    }
    public int JornalAcobrar(){
        return 0;

    }
   
}

public class Cadeteria{
    private string nombre;
    private string telefono;
    public List<Cadete> Cadetes{get;set;}
    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
     
    }
    
     public Cadeteria()
    {
        Cadetes = new List<Cadete>();
    }
    

    public static Cadeteria CargarCsv(string Acadeteria,string Acadetes){
        Cadeteria cadeteria =null;
//LEER CADETERIA
        using(StreamReader sr = new StreamReader(Acadeteria)){//inicializa el archivo
           string linea= sr.ReadLine();
           string strr =sr.ReadLine();
           linea= strr;
        while (linea!=null)
        {
            string[] datos =linea.Split(',');
            string nombre = datos[0];
            string telefono = datos[1];
            cadeteria = new Cadeteria(nombre, telefono);
             strr=sr.ReadLine();
             linea= strr;
        }
 }
 //Leer cadetes
        using(StreamReader sr = new StreamReader(Acadetes)){
            string linea= sr.ReadLine();
           string str=sr.ReadLine();
            linea=str;
            while (linea!=null)
            {
                string[] datos= linea.Split(',');
                int id= int.Parse(datos[0]);
                string nombre= datos[1];
                string direccion= datos[2];
                string telefono= datos[3];
                Cadete cadete = new Cadete(id, nombre, direccion, telefono);
                cadeteria.Cadetes.Add(cadete);
                str= sr.ReadLine();
                linea=str;
            }
        
        }
        return cadeteria;

    }
    public static bool CambiarCadete(int numPedido,int id, List<Pedidos> listapedidos){
        Pedidos pedido=null;
        Cadete cadete = null;
        foreach (var p in listapedidos)
        {
            p.NumPedido= numPedido;
            pedido=p; 

        }

        foreach (var c in Cadete)
        {
            
        }

    }
}
 