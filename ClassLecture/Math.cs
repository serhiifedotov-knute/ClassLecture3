using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture {
    internal class Math {

        public static float staticPi = 3.14f;

        public static int positionX;

        // Static works without objects
        public static int AddStatic(int a, int b) {
            return a + b;
        }

        // THIS doesn't work in static function
        public static float AreaStaticCircle(float radius) {
            return radius * radius * staticPi;
        }

    }
}
