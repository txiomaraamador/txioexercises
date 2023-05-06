
public class ClassPedido
{
    public int Mesa { get; set; }
    public List<string> Comidas { get; set; }
    public List<string> Bebidas { get; set; }
    public string Camarero { get; set; }

    public static List<ClassPedido> AgregarPedidosSimulados()
    {
        var pedidos = new List<ClassPedido>();

        // Agregar algunos pedidos simulados
        var pedido1 = new ClassPedido
        {
            Mesa = 1,
            Comidas = new List<string> { "Hamburguesa", "Papas fritas" },
            Bebidas = new List<string> { "Coca-Cola", "Agua" },
            Camarero = "Xiomara"
        };
        pedidos.Add(pedido1);

        var pedido2 = new ClassPedido
        {
            Mesa = 2,
            Comidas = new List<string> { "Pizza", "Ensalada" },
            Bebidas = new List<string> { "Cerveza", "Agua" },
            Camarero = "Evelin"
        };
        pedidos.Add(pedido2);

        var pedido3 = new ClassPedido
        {
            Mesa = 3,
            Comidas = new List<string> { "Taco", "Nachos" },
            Bebidas = new List<string> { "Margarita", "Agua" },
            Camarero = "Paola"
        };
        pedidos.Add(pedido3);

        var pedido4 = new ClassPedido
        {
            Mesa = 2,
            Comidas = new List<string> { "Enchiladas", "Nachos" },
            Bebidas = new List<string> { "Coca-cola", "Agua" },
            Camarero = "Paola"
        };
        pedidos.Add(pedido3);

        return pedidos;
    } 
}
