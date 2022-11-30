using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlerterSpace
{
    public class AlerterStub : Alerter
    {
        public override int networkAlert(float celcius)
        {
            Console.WriteLine("This is a stub code");
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if (celcius < 200) return 200;
            else return 500;
        }
    }
}
