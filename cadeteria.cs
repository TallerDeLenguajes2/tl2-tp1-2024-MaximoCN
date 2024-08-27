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
    public Cliente(string nombre,string direccion,string telefono,string datosDirecc){
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.DatosDirecc = datosDirecc;  
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string DatosDirecc { get => datosDirecc; set => datosDirecc = value; }
}

public class Pedidos{
    private int numPedido;
    private string observacion;
    public Cliente Cliente{get; set;}
    public  Estado EstadoPedido{get;set;}
    public Pedidos(int numPedido,string observacion,Cliente cliente, Estado estadoPedido){
        this.numPedido = numPedido;
        this.observacion = observacion;
        this.Cliente = cliente; // Composición: se inicializa en el constructor
        this.EstadoPedido = estadoPedido;
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
    public List<Cadete> listaCadetes{get;set;}
     public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        listaCadetes = new List<Cadete>(); // Inicializa la lista de cadetes
    }

    public static Cadeteria CargarCsv(string Acadeteria,string Acadetes){
        Cadeteria cadeteria =null;
//LEER CADETERIA
        using(StreamReader sr = new StreamReader(Acadeteria)){//inicializa el archivo

        string linea= sr.ReadLine();

        sr.ReadLine();
        linea=sr.ReadLine();

        while (linea!=null)
        {
            string[] datos =linea.Split(',');
            string nombre = datos[0];
            string telefono = datos[1];
            cadeteria = new Cadeteria(nombre, telefono);
        }
 }
 //Leer cadetes
        using(StreamReader sr = new StreamReader(Acadetes)){
            string linea= sr.ReadLine();
            sr.ReadLine();
            linea=sr.ReadLine();
            while (linea!=null)
            {
                string[] datos= linea.Split(',');
                int id= int.Parse(datos[0]);
                string nombre= datos[1];
                string direccion= datos[2];
                string telefono= datos[3];
                Cadete cadete = new Cadete(id, nombre, direccion, telefono);
                cadeteria.listaCadetes.Add(cadete);
            }
        
        }
        return cadeteria;

    }
     
 }