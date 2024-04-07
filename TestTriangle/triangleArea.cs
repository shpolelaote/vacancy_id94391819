namespace AreaCalculate
{
    public static class AreaCalculator
    {
        public static double ShapeArea(double[] Measurements)
        {
            foreach (double m in Measurements)
            {
                if (m < 0) throw new Exception("Only positive input measurements are allowed.");
            }
            switch (Measurements.Length)
            {
                // circle
                case 1:
                    return Math.PI * Measurements[0] * Measurements[0];
                // triangle
                case 3:
                    double a, b, c;
                    a = Measurements[0];
                    b = Measurements[1];
                    c = Measurements[2];

                    // check if triangle with given measurements exists
                    if (!(a + b >= c && a + c >= b && b + c >= a))
                        throw new Exception("the triangle doesn't exists");

                    // check if the triangle is right
                    if (a * a + b * b == c * c) return 0.5 * a * b;
                    else if (a * a + c * c == b * b) return 0.5 * a * c;
                    else if (c * c + b * b == b * b) return 0.5 * c * b;
                    // else use Heron's formula
                    else
                    {
                        double p = (a + b + c) / 2;
                        double result = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
                        return result;
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}