using System;
using System.Diagnostics;

namespace AlerterSpace {
    public class Alerter {
        static int alertFailureCount = 0;
            public virtual int networkAlert(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if(celcius < 200) return 200;
            else return 500;
        }
        public void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlert(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
                Debug.Assert(alertFailureCount > 0);
            }
        }
        public static void Main(string[] args) {
            Alerter alerter = new Alerter();
            alerter.alertInCelcius(400.5f);
            alerter.alertInCelcius(303.6f);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
            
            AlerterStub stub = new AlerterStub();
			stub.alertInCelcius(400.5f);
        }
    }
}
