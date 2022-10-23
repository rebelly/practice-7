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
            if (m < x)
            {   
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
            if (cube_eq(a, b, c, d, m) > 0){
                rght = m;
            }
            if (cube_eq(a, b, c, d, m) < 0){
                lft = m;
            }
            if (cube_eq(a, b, c, d, m) == 0){
                break;
            }
            m = (rght + lft) / 2;
        }
        return m;

    
    }
    static float par_lyc(int parents, int everybody)
    {
        return (float)everybody/parents;
    }
    static int parents_council(int n, int k)
    {
        int m = n;
        int check = k;
        while (par_lyc(m, check) <= 1 / (float)3)
        {
            m ++;
            check++;
        }
        return m-n;
    }
    static double sqrt_sqr(double x)
    {
        return x*x + Math.Sqrt(x);
    }
    static double sqrt_sqr_sol(double y)
    {
        double lft = 1;
        double rght = Math.Pow(10, 10);
        double m = (rght + lft) / 2;
        while (sqrt_sqr(m)!= y)
        {
            m = Math.Round(m, 2);
            if (sqrt_sqr(m) > y)
            {
                rght = m;
            }
            if (sqrt_sqr(m) < y)
            {
                lft = m;
            }
            m = (rght + lft) / 2;
        }
        return m;

    }
    public static void Main()
    {
        /*zer:
        Console.WriteLine("Введите ваше число:");
        int n = int.Parse(Console.ReadLine());
        if (n == binary_search(100, 0, n)){
            Console.WriteLine($"Ваше число: {binary_search(100, 0, n)}");
        }
        */


        /*frst:
               float a = int.Parse(Console.ReadLine());
               float b = int.Parse(Console.ReadLine());
               float c = int.Parse(Console.ReadLine());
               float d = int.Parse(Console.ReadLine());
               double res = cube_eq_sol(a, b, c, d);
               Console.WriteLine($"Корень кубического уравнения: {a}x^3+{b}x^2+{c}x+{d}: {res}");
         */

        /* sec
         float y = int.Parse(Console.ReadLine());
         double res1 = sqrt_sqr_sol(y);
        Console.WriteLine($"Корень уравнения вида x^2 + sqrt(x): {res1}"); */


        /* thrd
        int n1 = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Чтобы количество родителей в совете лицея превосходило треть от общего нужно добавить {parents_council(n1,k)} родителя(-ей)");
        */
    }
}
// 2 -11 12 9  solv: -0.5
