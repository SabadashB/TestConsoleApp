namespace TestLibrary
{
    public class Homework2
    {
        public static int Task1(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else if (A > B)
            {
                result = A - B;
            }
            return result;

        }
        public static double Task2(double X, double Y)
        {
            int result = 0;
            if (X > 0 && Y > 0)
            {
                result = 1;
            }
            else if (X < 0 && Y > 0)
            {
                result = 2;
            }
            else if (X < 0 && Y < 0)
            {
                result = 3;
            }
            else if (X > 0 && Y < 0)
            {
                result = 4;
            }
            return result;

        }
    }
}