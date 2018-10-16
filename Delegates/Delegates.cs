using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    delegate void delegatewithLamdaStatement(int x);
    delegate int? delegatewithLamdaExpression(int x);
    delegate void delegatewithAnonymous(int x);
    delegate void GetDetails();
    class Program
    {
        public void Details()
        {
            Console.WriteLine("Hello");
        }
        public static void Main()
        {
            delegatewithLamdaStatement dlwithLamdastateme = (int x) => { Console.WriteLine(x); };
            dlwithLamdastateme(10);


            delegatewithLamdaExpression dlwithLambdaexpression = (x) => (null);
            int? y = dlwithLambdaexpression(10) ?? -1;
            Console.WriteLine(y);


            delegatewithAnonymous getAnonymous = delegate (int x)
            {
                Console.WriteLine(x);
            };
            getAnonymous(510);


            GetDetails callfuncwithDelegate = new GetDetails(new Program().Details);
            callfuncwithDelegate();
            Console.ReadKey();
            
        }
    }
}
