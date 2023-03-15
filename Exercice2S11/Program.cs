// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    
int[] arr = {1, 3, 5, 7, 9, 11, 13};
int x = 7;

static int BusquedaBinaria(int[] arr, int x) {
    int inicio = 0;
    int fin = arr.Length - 1;

    while (inicio <= fin) {
        int medio = inicio + (fin - inicio) / 2;

        if (arr[medio] == x) {
            return medio;
        }

        if (arr[medio] < x) {
            inicio = medio + 1;
        } else {
            fin = medio - 1;
        }
    }
        return -1;
    }

int resultado = BusquedaBinaria(arr, x);

if (resultado == -1) {
    Console.WriteLine("El elemento no se encuentra en la matriz.");
} else {
    Console.WriteLine("El elemento se encuentra en el índice " + resultado);
    }
    



