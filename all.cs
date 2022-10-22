using System;
public class Program
{
    static int binary_search(int rght, int lft, int x)
    {
        int m = (rght + lft) / 2;
        while (rght - lft > 2)
        {
            if (m > x){
                rght = m;

            }
            if (m < x) {
                lft = m;
            }
            m = (rght + lft) / 2;
        }
        return m;
    }
    static double cube_eq(double a, double b, double c, double d, double x)
    {
        return (a * x * x * x) + b * x * x + c *x +d;
    }
    static double cube_eq_sol(float a , float b, float c, float d)
    {
        double rght = 10000;
        double lft = -10000;
        double m = (rght + lft) / 2;
        while (cube_eq(a, b, c, d, m) != 0 )
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
        return m;

    }
    static int parents_council(int n, int k)
    {
        int to_add = n;
        int all = n+k;
        while (all / to_add < (float)1 / 3)
        {
            to_add++;
        }
        return to_add - n;
    }

    public static void Main()
    {
        //frst:
        Console.WriteLine("Введите ваше число:");
        int n = int.Parse(Console.ReadLine());
        if (n == binary_search(100, 0, n)){
            Console.WriteLine($"Ваше число: {binary_search(100, 0, n)}");
        }

        // sec:
        float a = int.Parse(Console.ReadLine());
        float b = int.Parse(Console.ReadLine());
        float c = int.Parse(Console.ReadLine());
        float d = int.Parse(Console.ReadLine());
        double res = cube_eq_sol(a, b, c, d);
        Console.WriteLine($"Корень кубического уравнения: {a}x^3+{b}x^2+{c}x+{d}: {res}"); 
        // thrd
        int n1 = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Чтобы количество родителей в совете лицея превосходило треть от общего нужно добавить {parents_council(n1,k)}");
    }   
}
// 2 -11 12 9
