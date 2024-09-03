namespace parteJson;
using sistemaCadt;

public class csv{
public static void GuardarPedidosEnCsv(string archivo, List<Pedidos> listaPedidos)
        {
        using (StreamWriter writer = new StreamWriter(archivo)){
            // Escribe la cabecera del archivo CSV si lo deseas.
            writer.WriteLine("NumPedido,NombreCliente,EstadoPedido,Observacion");

            // Escribe cada pedido en una línea del archivo CSV.
            foreach (var pedido in listaPedidos)
            {
                string linea = $"{pedido.NumPedido},{pedido.Cliente.Nombre},{pedido.EstadoPedido},{pedido.Observacion}";
                writer.WriteLine(linea);
        }
        
        }
 }
}
             