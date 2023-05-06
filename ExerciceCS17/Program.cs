// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pedidos = ClassPedido.AgregarPedidosSimulados();


// Ordenar los pedidos por mesa
pedidos.Sort((p1, p2) => p1.Mesa.CompareTo(p2.Mesa));

// Mostrar los pedidos en la consola
foreach (var pedido in pedidos)
{
    Console.WriteLine($"Mesa: {pedido.Mesa}");
    Console.WriteLine($"Comidas: {string.Join(", ", pedido.Comidas)}");
    Console.WriteLine($"Bebidas: {string.Join(", ", pedido.Bebidas)}");
    Console.WriteLine($"Camarero: {pedido.Camarero}");
    Console.WriteLine();
}
    

