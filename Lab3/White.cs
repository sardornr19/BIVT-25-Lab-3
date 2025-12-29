using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;
            double sum = 0;
						// code here
            for (int i = 0; i < n; i++)
            {
                double h = double.Parse(Console.ReadLine());
                sum += h;
            }

            averageHeight = sum / n;
						// end
            return averageHeight;
        }

        public double Task2(int n)
        {
            double bestResult = double.MaxValue;
						// code here
            for (int i = 0; i < n; i++)
            {
                double t = double.Parse(Console.ReadLine());
                if (t < bestResult)
                {
                    bestResult = t;
                }
            }
						// end
            return bestResult;
        }

        public int Task3(int n, double limit)
        {
            int count = 0;
						// code here
            for (int i = 0; i < n; i++)
            {
                double t = double.Parse(Console.ReadLine());
                if (t <= limit)
                {
                    count++;
                }
            }
					  // end
            return count;
        }

        public int Task4(int maxAmount)
        {
            int hours = 0;
            int amount = 0;
						// code here
            while (amount <= maxAmount)
            {
                if (hours % 5 == 4)
                {
                    amount += 1;
                }
                else
                {
                    amount += 2;
                }
                hours++;
            }
						// end
            return hours;
        }

        public double Task5(int r, int type)
        {
            double area = 0;
						// code here
            switch (type)
            {
                case 1:
                    area = r * r;
                    break;
                case 2:
                    area = Math.PI * r * r;
                    break;
                case 3:
                    area = Math.Sqrt(3) / 4 * r * r;
                    break;
            }
						// end
            return area;
        }
    }
}
