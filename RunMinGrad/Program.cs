using MinGrad;

Variable val1 = new Variable(10);
Variable val2 = new Variable(20);
Variable val3 = new Variable(30);

Sum val = new Sum(val1.Value, val2.Value);
Mult multVal = new Mult(val.Evaluate(), val3.Value);


Console.WriteLine(multVal.Evaluate());