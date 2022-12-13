namespace MinGrad;

public class Variable
{
    public int Value { get; set; }

    public Variable(int value)
    {
        Value = value;
    }

    public int Evaluate()
    {
        return Value;
    }
}

public class Sum
{
    public int Left { get; set; }
    public int Right { get; set; }

    public Sum(int left, int right)
    {
        Left = left;
        Right = right;
    }

    public int Evaluate()
    {
        return Left + Right;
    }
}

public class Mult {
    public int Left { get; set; }
    public int Right { get; set; }

    public Mult(int left, int right) {
        Left = left;
        Right = right;
    }

    public int Evaluate() {
        return Left * Right;
    }
}