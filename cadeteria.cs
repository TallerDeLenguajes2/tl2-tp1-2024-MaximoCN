enum Estado
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
    public Cliente(){

    }
}

public class Pedidos{
    private int numPedido;
    private string observacion;
    public Cliente Clientes{get; set;}
    private enum Estado;
    public Pedidos(){

    }

}
public class Cadete{
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    public List<Pedidos> listadoPedidos{get;set;}
    public Cadete(){

    }
}

public class cadeteria{
    private string nombre;
    private int telefono;
    public List<Cadete> listaCadetes{get;set;}
}