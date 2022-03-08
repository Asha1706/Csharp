using System;
class AbsChild : AbsParent
{
    public override void Div(int x, int y)
    {
        Console.WriteLine(x / y);
    }
    public override void Mul(int x, int y)
    {
        Console.WriteLine(x * y);
    }
}




