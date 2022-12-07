using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static string printColorMap(int number) {
            string result = "";
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    if(number == (i * 5 + j))
                    {
                        result = String.Format("{0} | {1}", majorColors[i], minorColors[j]);
                    }
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[j]);
                }
            }
            return result;
        }
        static void Main(string[] args) {
            string result = printColorMap(4);
            Debug.Assert(result == "White | Slate");
            
            result = printColorMap(22);
            Debug.Assert(result == "Violet | Blue");
            
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
