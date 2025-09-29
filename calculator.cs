class Add
{
    public int Execute(int a, int b)
    {
        return a + b;
    }
}

class Subtract
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}
class Multiply
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}
class Divide
{
    public int Execute(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}
