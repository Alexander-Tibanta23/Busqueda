using System;
namespace Secuencial;

class Program{

    static void Main(string[] args){
        busquedaSecuancial();
    }

    static void busquedaSecuancial()
    {
        double porcentajeExito, porcentajetFracaso; 
        int nFracasos;
        int aux = 0; 
        int posicion;
        
        //Generar Array Randomico
        int[] array = new int[100];
        Random rnd = new Random();
        Console.Write("Array[]: \n");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 200);
            Console.Write(array[i]);
        }   

        for (int i = 0; i < array.Length; i++){
            aux = i + 1;
            Console.Write("Elemento: " + array[i] + "Posicion: " + aux + "\n");
        }
                
        int[] arrayAux = new int[50];
        Console.Write("\nLos 50 numeros a buscar (aleatoriamente): \n");

        for (int i = 0; i < arrayAux.Length; i++)
        {
            arrayAux[i] = rnd.Next(1, 200);
            Console.Write(arrayAux[i]+" ");
        }

        Console.Write("\n-----------BUSQUEDA SECUENCIAL-----------\n");
        
        Console.Write("ARRAY EN ORDEN CRECIENTE: \n");
        Array.Sort(array);

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < arrayAux.Length; j++)
            {
                if (array[i] == arrayAux[j])
                {
                    posicion = i + 1;
                    Console.Write("Elemento "+ array[i]+ " encontrado en la posicion "+ posicion + "\n");
                    aux++;
                }
            }
        }

        porcentajeExito = (((Convert.ToDouble(aux))/50)*100);
        porcentajetFracaso = (100-porcentajeExito);

        Console.Write("-----------RESULTADOS ESTADISTICOS-----------\n");
        Console.Write("NUMERO DE BUSQUEDAS CON EXITO: " + aux + "\n");
        Console.Write("PORCENTAJE DE EXITO: " + porcentajeExito + "%\n");
        nFracasos = arrayAux.Length - aux;
        Console.Write("NUMERO DE BUSQUEDAS FALLIDAS: " + nFracasos + "\n");
        Console.Write("PORCENTAJE DE FRACASO: " + porcentajetFracaso + "%\n");
    }
}