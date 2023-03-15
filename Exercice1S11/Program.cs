// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    
int[] arr = {5, 2, 7, 1, 3};
        
Console.WriteLine("Array antes de ordenar:");

foreach (int i in arr) {
            Console.Write(i + " ");
        }
        Console.WriteLine();

int n = arr.Length;
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

Console.WriteLine("Array después de ordenar:");

foreach (int i in arr) {
            Console.Write(i + " ");
        }
        Console.WriteLine();

