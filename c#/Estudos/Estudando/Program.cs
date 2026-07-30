using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Tamanho da matriz:");


        var matriz = CriarMatriz(int.Parse(Console.ReadLine()));
        
        matriz = PreencherMatriz(matriz);

        PrintaDiagonalMatriz(matriz);  

        PrintaNumeroNegativo(matriz);     
    }
    


















    static int[,] CriarMatriz(int tamanho)
    {
       int[,] matriz = new int[tamanho, tamanho];
        
        return matriz;
    }

    static int[,] PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {

            
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                
            matriz[i,j] = int.Parse(Console.ReadLine());
            
            }
        }
        return matriz;
    }

    static void PrintaDiagonalMatriz(int[,] matriz)
    {
        Console.WriteLine("Main diagonal:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                if(j == i) Console.Write(matriz[i,j]+ " "); 
            }
        }
    }

    static void PrintaNumeroNegativo(int[,] matriz)
    {

        int negativeNumbers = 0;
        
        foreach (var item in matriz)
        {
            if(item < 0) negativeNumbers++;
        }

        System.Console.WriteLine("\nNegative numbers = " + negativeNumbers);
    }
     
}