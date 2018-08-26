using System;
namespace RandomNumber
{
    public class MyClass
    {
       public int GetRandom()
        {
            Random rand = new Random();
            return rand.Next();
        }
    }
}
