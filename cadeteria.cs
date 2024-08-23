public enum Estado
{
    Aceptado,
    Cancelado,
    CambioDeCadete,
    
}
public class Cliente{
    private string nombre;
    private string direccion;
    private int telefono;
    private string datosDirecc;
    public Cliente(String nombre,string direccion,int telefono,string datosDirecc){
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.datosDirecc = datosDirecc;  
    }
}

public class Pedidos{
    private int numPedido;
    private string observacion;
    public Cliente Cliente{get; set;}
    private  Estado EstadoPedido{get;set;}
    public Pedidos(int numPedido,string observacion,Cliente cliente, Estado estadoPedido){
        this.numPedido = numPedido;
        this.observacion = observacion;
        this.Cliente = cliente; // Composición: se inicializa en el constructor
        this.EstadoPedido = estadoPedido;
    }

public class VerDireccionCliente(){
    
}
    
}
public class Cadete{
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    public List<Pedidos> listadoPedidos{get;set;}
    public Cadete(int id, string nombre,string direccion,int telefono){
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        listadoPedidos = new List<Pedidos>(); // Inicializa la lista de pedidos
    }
   
}

public class Cadeteria{
    private string nombre;
    private int telefono;
    public List<Cadete> listaCadetes{get;set;}
     public Cadeteria(string nombre, int telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        listaCadetes = new List<Cadete>(); // Inicializa la lista de cadetes
    }
     
 }