using System;
public class Program
{
    static int binary_search(int rght, int lft, int x)
    {
        int m = (rght + lft) / 2;
        while (rght - lft > 1)
        {
            if (m > x){
                rght = m;

            }
            if (m < x) {
                lft = m;
            }
            m = (rght + lft) / 2;
        }
        return rght;
    }
    static double cube_eq(double a, double b, double c, double d, double x)
    {
        return (a * x * x * x) + b * x * x + c *x +d;
    }
    static string cube_eq_sol(float a , float b, float c, float d)
    {
        double rght = 10000;
        double lft = -10000;
        double m = (rght + lft) / 2;
        while (cube_eq(a, b, c, d, m) != 0)
        {
                m = Math.Round(m, 4);
                if (cube_eq(a, b, c, d, m) > 0)
                {
                    rght = m;

                }
                if (cube_eq(a, b, c, d, m) < 0)
                {
                    lft = m;
                }
                if (cube_eq(a, b, c, d, m) == 0)
                {

                    break;
                }

                m = (rght + lft) / 2;
        }
        return $"{m:f2}";

    }
    public static void Main()
    {
        //frst:
        Console.WriteLine("Введите ваше число:");
        int n = int.Parse(Console.ReadLine());
        if (n == binary_search(0, 100, n)){
            Console.WriteLine($"Ваше число: {binary_search(0, 100, n)}");
        }

        // sec:
        float a = int.Parse(Console.ReadLine());
        float b = int.Parse(Console.ReadLine());
        float c = int.Parse(Console.ReadLine());
        float d = int.Parse(Console.ReadLine());
        string res = cube_eq_sol(a, b, c, d);
        Console.WriteLine(res); 
    }
}
