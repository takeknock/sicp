using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sicp
{
    public class questions
    {
        public double question_1_3(double x, double y, double z)
        {
            // Question 1.3
            List<double> target = new List<double> { x, y, z };
            List<double> ordered = target.OrderByDescending(v => v).ToList();
            double max = ordered[0];
            double second = ordered[1];
            return square_sum(max, second);
        }

        double square_sum(double x, double y)
        {
            return x * x + y * y;
        }


    }
}
