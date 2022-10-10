using System.Drawing;

Ostrova O = new Ostrova();
O.matrix();
O.print();
O.printReal();
O.Proverka();
Console.WriteLine("Количество всех островоу->>" + O.KolO()); 

class Ostrova
{
    public int[,] mas;
    int str = 8;
    int stb = 8;
    public Ostrova()
    {
        mas = new int[str, stb];
    }
    public void matrix()
    {
        Random random = new Random();

        for (int i = 1; i < mas.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < mas.GetLength(1) - 1; j++)
            {
                mas[i, j] = random.Next(0, 2);
            }
        }
    }
    public void print()
    {
        for (int i = 1; i < mas.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < mas.GetLength(1) - 1; j++)
            {
                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void printReal()
    {
        int q = mas.GetLength(0);

        Console.WriteLine("\n");
    
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i,j]==1)
                {
                    Console.ForegroundColor=ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Black;
                }
                Console.Write(" " + mas[i, j] + " ");
            }
            Console.WriteLine(" \n");
        }
        Console.WriteLine();
    }
    public void Proverka()
    {
        int kol = 0;
        for (int i = 1; i < mas.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < mas.GetLength(1) - 1; j++)
            {
                if (mas[i, j] == 1)
                {

                    if (mas[i + 1, j] != 1 && mas[i - 1, j] != 1 && mas[i, j + 1] != 1 && mas[i, j - 1] != 1)
                    {
                        Console.WriteLine("Coord: " + (i) + " = " + (j));
                        kol++;
                    }
                }
            }
        }
        Console.WriteLine("Количество маленьких островоу = " + kol);
    }
    public int KolO()
    {
        int kol = 0;
        
        Console.WriteLine("");
        for (int i = 1; i < mas.GetLength(0)-1; i++)
        {
            for (int j = 1; j < mas.GetLength(1)-1; j++)
            {
                if (mas[i,j] == 1)
                {
                    kol++;
                    prov(mas,i,j);
                }
            }
        }
        return kol;
    }
    private void prov(int[,] mas, int i, int j)
    {
        if (mas[i,j] == 0)
            return;
        mas[i,j] = 0;

        prov(mas, i, j + 1);
        prov(mas, i + 1, j);
        prov(mas, i, j - 1);
        prov(mas, i - 1, j);
    }
}
