using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture {

    struct Position {
        public int x;
        public int y;
    }    

    internal class CharacterFromGameClass {
        public string name;
        public Position position;
        public string pathToTexture;

        public int healthPoints;
        public int damagePoints;

        public SquareRenderer squareRenderer;

        public CharacterFromGameClass(string name, Position position, SquareRenderer view,string pathToTexture = "",int health = 100, int damage=10) {
            this.name = name;
            this.position = position;
            this.pathToTexture = pathToTexture;
            this.healthPoints = health;
            this.damagePoints = damage;
            this.squareRenderer = view;
        }

        public void Move(int dx, int dy) {
            this.position.x = this.position.x + dx;
            this.position.y += dy;
        }

        public void Attack(CharacterFromGameClass enemyCharecter) {
            enemyCharecter.healthPoints -= this.damagePoints;
        }

        public void Render() {
            Console.WriteLine("Character Render start");
            this.squareRenderer.Render();
            Console.WriteLine("Character Render end");
        }
    }
}
