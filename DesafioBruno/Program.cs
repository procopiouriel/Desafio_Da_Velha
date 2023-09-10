using System;

class Program
{
    public static int[,] array = new int[4, 4];
    public static List<int> contador = new List<int>();
    public static Random random = new Random();
    public static int valorSorteado;
    public static List<int> listExatos = new List<int>();
    public static bool resposta = false;



    static void Main()
    {

      
        NumerosExatos();

       
                
                        
           
        while (resposta != true)
        {
            

            foreach (int x in listExatos)
            {
                Sorteio();

                int linha1 = 1;
                int coluna1 = 1;
                array[linha1, coluna1] = valorSorteado;

                Sorteio();
                int linha2 = 1;
                int coluna2 = 2;
                array[linha2, coluna2] = valorSorteado;

                Sorteio();
                int linha3 = 1;
                int coluna3 = 3;
                array[linha3, coluna3] = valorSorteado;








                Sorteio();
                int linha4 = 2;
                int coluna4 = 1;
                array[linha4, coluna4] = valorSorteado;

                Sorteio();
                int linha5 = 2;
                int coluna5 = 2;
                array[linha5, coluna5] = valorSorteado;

                Sorteio();
                int linha6 = 2;
                int coluna6 = 3;
                array[linha6, coluna6] = valorSorteado;















                Sorteio();
                int linha7 = 3;
                int coluna7 = 1;
                array[linha7, coluna7] = valorSorteado;

                Sorteio();
                int linha8 = 3;
                int coluna8 = 2;
                array[linha8, coluna8] = valorSorteado;

                Sorteio();
                int linha9 = 3;
                int coluna9 = 3;
                array[linha9, coluna9] = valorSorteado;
                Grade();     
            }
            int somaColunas1 = array[1, 1] + array[2, 1] + array[3, 1];

            int somaColunas2 = array[1, 2] + array[2, 2] + array[3, 2];
            int somaColunas3 = array[1, 3] + array[2, 3] + array[3, 3];

            int somaLinha1 = array[1, 1] + array[1, 2] + array[1, 3];
            int somaLinha2 = array[2, 1] + array[2, 2] + array[2, 3];
            int somaLinha3 = array[3, 1] + array[3, 2] + array[3, 3];

            int somaDiagonal1 = array[1, 1] + array[2, 2] + array[3, 3];
            int somaDiagonal2 = array[1, 3] + array[2, 2] + array[3, 1];



            if (somaColunas1 == somaColunas2 && somaColunas2 == somaColunas3 && somaColunas3 == somaColunas1)
            {
                Console.WriteLine("Coluna 1: " + somaColunas1);
                Console.WriteLine("Coluna 2: " + somaColunas2);
                Console.WriteLine("Coluna 3: " + somaColunas3);

                if (somaLinha1 == somaLinha2 && somaLinha2 == somaLinha3 && somaLinha3 == somaLinha1)
                {
                    
                    Console.WriteLine("Linha 1: " + somaLinha1);
                    Console.WriteLine("Linha 2: " + somaLinha2);
                    Console.WriteLine("Linha 3: " + somaLinha3);

                    if (somaDiagonal1 == somaDiagonal2)
                    {
                        Console.WriteLine("Diagonal 1: " + somaDiagonal1);
                        Console.WriteLine("Diagonal 2: " + somaDiagonal2);
                        resposta = true;
                        Console.WriteLine("executou");
                    }
                   
                }
               
            }



        }
        // Console.WriteLine("achou: ");
        // Grade();

    }

    public static void Sorteio()
    {
   
        try
        {
            foreach (int x in listExatos)
            {
           
                int indiceSorteado = random.Next(0, listExatos.Count);
                valorSorteado = listExatos[indiceSorteado];
            }      
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    public static void Grade()
    {
        

        Console.WriteLine("  " + array[1,1] + " |"+ "  " + array[1, 2] + "  |" + "  " + array[1, 3] + "  ");
        Console.WriteLine("------------------");
        Console.WriteLine("  " + array[2, 1] + "  |" + "  " + array[2, 2] + "  |" + "  " + array[2, 3] + "  ");
        Console.WriteLine("------------------");
        Console.WriteLine("  " + array[3, 1] + "  |" + "  " + array[3, 2] + "  |" + "  " + array[3, 3] + "  ");
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        


    }

    public static void NumerosExatos()
    {
        

        for (int i = 1; i <= 1000; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)//VERIFICAR SE O NUMERO E EXATO (1,1)
            {
                listExatos.Add(i);
            }
        }
    }
}
