using System;


namespace PartialClass
{
    class Class3
    {
        static void Main()
        {
            Hotel h = new Hotel();
            h.CoffeePreparation();
            h.TeaPreparation();
            h.FoodPreparation();
            h.SnacksPreparation();
            Console.ReadLine();
        }
    }
}
