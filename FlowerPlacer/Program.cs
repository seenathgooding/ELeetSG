using System;

public class Program
{

    public static void Main(string[] args)
    {
        FlowerPlacer flowerPlacer = new FlowerPlacer();
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 2;

        bool answer = flowerPlacer.CanPlaceFlowers(flowerbed, n);
        Console.WriteLine(answer);
    }
}

public class FlowerPlacer
{
    public bool CanPlaceFlowers(int[] flowerBed, int n)
    {
        bool result = false;
        int calc = 0;
        for (int index = 0; index < flowerBed.Length; index++)
        {
            if (index + 1 < flowerBed.Length)
            {
                if ( (flowerBed[index] ==0) && (index == 0 || flowerBed[index - 1] == 0) && (index == flowerBed.Length-1 || flowerBed[index + 1] == 0) )
                {
                    calc++;
                }
                //if (flowerBed[index] == 0 && (index ==0 ||flowerBed[index - 1] ==0) && (index == flowerBed.Length - 1) || flowerBed[index + 1] ==0)
                //{
                //    
                //}
            }
            if (calc == n)
            {
                return result = true;
            }
        }
        return result;
    }
}