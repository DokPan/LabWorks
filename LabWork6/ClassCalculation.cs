class Calculations
{
    public double GetSquare(double side)
    {
        if (side < 0)
            return -1;

        return side * side;
    }

    public double GetSquare(double length, double width)
    {
        if (length < 0 || width < 0)
            return -1;

        return length * width;
    }

    public double GetRationalFunction(double x, int n)
    {
        if (x == 0 || n < 0) 
            return -1;

        double result = 1;
        for (int i = 0; i < n; i++)
            result *= x;
        return 1/result;
    }

    public double GetRationalFunction(double x)
    {
        if (x == 0) 
            return -1;

        return 1 / x;
    }
}
