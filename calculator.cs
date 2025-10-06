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
/// <summary>
/// Calculator class that uses composition to perform basic arithmetic operations.
/// </summary>

class Calculator
{

    private Add add;
    private Subtract subtract;
    private Multiply multiply;
    private Divide divide;

    private int result;



    public Calculator()
    {
        add = new Add();
        subtract = new Subtract();
        multiply = new Multiply();
        divide = new Divide();

    }

    public int Add(int a, int b)
    {
        return add.Execute(a, b);
    }

    public int Subtract(int a, int b)
    {
        return subtract.Execute(a, b);
    }

    public int Multiply(int a, int b)
    {
        return multiply.Execute(a, b);
    }

    public int Divide(int a, int b)
    {
        return divide.Execute(a, b);
    }


}