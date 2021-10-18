using System;

namespace Hybrid_Inheritance
{
    public interface IA //ineterface  1    
    {
        string setFlag(int a);
    }
    public interface IB:IA //ineterface  2  
    {
        string setImgs(string a);
    }
    public interface IC : IA  //Interface 3  
    {
        int getAmount(int Amt);
    }
    public class Car : IB, IC //implementatin    
    {
        public string setFlag(int a)
        {
            return "this is the car";
        }
        public int getAmount(int Amt)
        {
            return 100;
        }
        public string setImgs(string a)
        {
            return "this is the car";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.getAmount(1000);
            c.setImgs("Text");
        }
    }
}
