using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BasicCSharp
{
    public interface SmartPhone
    {
        void OperatingSystem();
        void Name();
    }
    public class Iphone : SmartPhone
    {
        public void Name()
        {
            Console.WriteLine("IPhone 23");
        }

        public void OperatingSystem()
        {
            Console.WriteLine("IOS");
        }
    }
    public class Samsung : SmartPhone
    {
        public void Name()
        {
            Console.WriteLine("Samsung S50");
        }

        public void OperatingSystem()
        {
            Console.WriteLine("Android");
        }
    }
}