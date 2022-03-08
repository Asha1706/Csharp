using System;
namespace Interface
{
    public class CodeFile1
    {
        abstract class AbsParent
        {
            public void Add(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public void Sub(int x, int y)
            {
                Console.WriteLine(x - y);
            }
            public abstract void Mul(int x, int y);
            public abstract void Div(int x, int y);
        }

        


        interface IMath1
        {
            void Add(int a, int b);
            void Sub(int a, int b);
        }
        interface IMath2
        {
            void Mul(int a, int b);
            void Div(int a, int b);

        }

        
       
    }
    
}
