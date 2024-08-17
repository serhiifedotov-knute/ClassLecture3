using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture {
    internal class SquareRenderer2 {

        public int width;
        public int height;

        public SquareRenderer2(int width, int height) {
            this.width = width;
            this.height = height;
        }

        public void Render() {
            for(int row = 0; row < height; row++) {
                for (int column = 0; column < width; column++) {

                    if (row == 0 || row == height - 1) {
                        Console.Write("#");
                    } else if (column == 0 || column == width - 1) {
                        Console.Write("#");
                    } else { Console.Write(" "); }
                }
                Console.WriteLine();
            }

            Console.WriteLine("finished render");
        }
    }
}
