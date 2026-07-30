using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Tamanho da matriz:");


         var matriz = CriarMatriz(int.Parse(Console.ReadLine()),
                                     int.Parse(Console.ReadLine()));
        
        

        matriz = PreencherMatriz(matriz);

        // PrintaDiagonalMatriz(matriz);  

        // PrintaNumeroNegativo(matriz);   
        System.Console.WriteLine("Escreva o item: ");
        int item = int.Parse(Console.ReadLine());
       
        PrintaArredores(matriz,item);  
    }


    static void PrintaArredores(int[,] matriz,int item)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] == item)
                {
                    Console.WriteLine("Position " + i +","+ j+":");
                    Left(i,j,matriz);
                    Right(i,j,matriz);
                    Up(i,j,matriz);
                    Down(i,j,matriz);
                }
            }
        }
    }
    static void Up(int i, int j, int[,] matriz)
    {
        try
        {
            Console.WriteLine("Up: " + matriz[i-1,j]);
            
        }
        catch (System.IndexOutOfRangeException)
        {
            
            return;
        }
        
    }

    static void Down(int i, int j, int[,] matriz)
    {
        try
        {
            Console.WriteLine("Down: " + matriz[i+1,j]);
            
        }
        catch (System.IndexOutOfRangeException)
        {
            
            return;
        }
        
    }

    static void Left(int i, int j, int[,] matriz)
    {
        try
        {
            Console.WriteLine("Left: " + matriz[i,j-1]);
            
        }
        catch (System.IndexOutOfRangeException)
        {
            
            return;
        }
        
    }

    static void Right(int i, int j, int[,] matriz)
    {
        try
        {
            Console.WriteLine("Right: " + matriz[i,j + 1]);
        }
        catch (System.Exception)
        {
            
            return;
        }
        
    }


    static int[,] CriarMatriz(int tamanhoLinha, int tamanhoCol)
    {
        int[,] matriz = new int[tamanhoLinha, tamanhoCol];
        return matriz;
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