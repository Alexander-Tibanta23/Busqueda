using System;
namespace Binario;

class Program{

    static void Main(string[] args){
        menu();
    }

    static void menu(){
        int[] array = new int[25];
        int opcion;
	    int x;
        do{
            Console.Write("\n -----------Menu----------- \n" +
                "1. Vector \n" +
                "2. Busqueda Binaria \n" +
                "3. Salir \n" +
                "Seleccione: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion){
                case 1:
                    Console.Write("Generar Array\n");
                    llenaArray(array);
                    Console.Write("Array[]: \n");
                    imprimirArray(array);
                    break;
                case 2:
                    Console.Write("Busqueda Binaria\n");
                    Console.Write("Ingrese el elemento a buscar: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    busquedaBinaria(array, x);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;                
                default:
                    Console.Write("\n SE HA GENERADO UN ERROR \n");
                    break;
            }
        } while (opcion != 3);
    }

    static void llenaArray(int[] array){
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++){
            array[i] = rnd.Next(1, 50);
        }
    }

    static void imprimirArray(int[] array){
        int aux;
        for (int i = 0; i < array.Length; i++){
            aux = i + 1;
            Console.Write("Elemento: " + array[i] + "Posicion: " + aux + "\n");
        }
    }

    static void busquedaBinaria(int[] array, int valor)
    {
        int tiempoInicio, tiempoFinal, total;
        int central, bajo = 0, alto = (array.Length - 1), valorCentral;
        Array.Sort(array);
        tiempoInicio = int.Parse($"{DateTime.Now:fffff}");
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            valorCentral = array[central];
            if (array[central] == valor)
            {
                Console.Write("El elemento " + valor + " fue encontrado en la posicion: " + central + " \n");
                tiempoFinal = int.Parse($"{DateTime.Now:fffff}");
                total = tiempoFinal - tiempoInicio;
                Console.Write("----------TIEMPO DE EJECUCION----------- \n");
                Console.Write("HORA INICIO EJECUCION: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempoInicio + "\n");
                Console.Write("HORA INICIO FINALIZACION: " + $"{DateTime.Now:HH:mm:ss}" + ":" + tiempoFinal + "\n");
                Console.Write("TIEMPO TOTAL DE EJECUCION (BUSQUEDA BINARIA): " + total + " ms\n");
                break;
            }
            else if (valor < array[central])
            {
                alto = central - 1;
            }
            else
            {
                bajo = central + 1;
            }
        }
    }
}