using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms >= 35 && cms <= 38) {
			return "S";
            } else if(cms > 38 && cms <= 42) {
                return "M";
            } else if(cms > 42 && cms <= 44) {
                return "L";
            } else {
                return "INVALID";
		}
        }
        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Debug.Assert(Size(-14) == "INVALID");
            Debug.Assert(Size(0) == "INVALID");
            Debug.Assert(Size(120) == "INVALID");
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
