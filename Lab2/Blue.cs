using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            double s = 0.0;

            // code here

            for (int i = 0; i < n; i++)
            {
                s += Math.Sin((i + 1) * x) / Math.Pow(x, i);
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            double sum = 0.0;
            double p5 = 1.0;
            double fct = 1.0;

            
            if (n <= 0)
            {
                return 0;
            }

            for (int i = 1; i <= n; i++)
            {
                
                p5 *= 5;

                
                fct *= i;

                
                if (i % 2 != 0)
                {
                    
                    sum -= p5 / fct;
                }
                else
                {
                    // Четные члены (2, 4, ...) положительны
                    sum += p5 / fct;
                }
            }

            

            answer = sum;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0;
            int b = 1;
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                s += a;
                b = a + b;
                a = b - a;

            }
            answer = s;


            
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;



            // code here
            int n = 0;
            int s = 0;

            while (s <= L)
            {
                s += a + n * h;
                n += 1;
                
            }

            answer = n-1;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);


            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int c = S;
            int t = 0;

            while (c < L)
            {
                t += 1;
                if (t%h == 0)
                {
                    c *= 2;
                }
            }
            answer = t;
            // end

            return answer;
        }
        public  (double a, int b, int c) Task7(double S, double I)
        {
            double m = 1 + I / 100.0;

            double a = 0;
            double d = S;
            for (int i = 0; i < 7; i++)
            {
                a += d;
                d *= m;
            }

            int b = 0;
            double sum = 0;
            d = S;
            while (sum < 100)
            {
                sum += d;
                d *= m;
                b++;
            }

            int c = 0;
            d = S;
            while (d <= 42)
            {
                d *= m;
                c++;
            }

            return (a, b, c);
        }



        public (double SS, double SY) Task8(double a, double b, double h)
        {
            const double e = 0.0001;
            double ss = 0.0;
            double sy = 0.0;

            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0.0;
                double t = 1.0;
                int i = 0;
                double x2 = x * x;
                double p = 1.0;
                double f = 1.0;

                while (Math.Abs(t) >= e)
                {
                    t = (2 * i + 1) * p / f;
                    s += t;

                    i++;
                    p *= x2;
                    f *= i;

                    if (double.IsInfinity(f)) break;
                }

                ss += s;
                sy += (1 + 2 * x2) * Math.Exp(x2);
            }

            return (ss, sy);
        }

    }
}