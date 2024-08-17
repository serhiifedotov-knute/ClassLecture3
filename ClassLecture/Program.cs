namespace ClassLecture {

    internal class Program {

        // 2.8kb - For big Structure better to use References or convert into Class
        struct VeryBigStructure {
            public int[] x; // 100 array count  100 * 4 * 7 = 2.8kb
            public int[] a;
            public int[] b;
            public int[] c;
            public int[] d;
            public int[] e;
            public int[] y;
        }
        class VeryBigStructureClass {
            public int[] x; // 100 array count  100 * 4 * 7 = 2.8kb
            public int[] a;
            public int[] b;
            public int[] c;
            public int[] d;
            public int[] e;
            public int[] y;
        }


        struct CharacterFromGame {
            public string name;
            public Position position;
            public string pathToTexture;

            public CharacterFromGame(string name, Position position, string pathToTexture = "") {
                this.name = name;
                this.position = position;
                this.pathToTexture = pathToTexture;
            }
        }

        class PositionClass {
            public int x;
            public int y;

        }

        class Human {
            public string name;
            public int age;
            public string gender;
        }

        static void Attack(CharacterFromGameClass attacker, CharacterFromGameClass enemy) {
            enemy.healthPoints -= attacker.damagePoints;
        }

        class FootballGame {
            public int goalTeamA;
            public int goalTeamB;
        }

        static void TeamAScoreGoal(FootballGame footballGame) {
            footballGame.goalTeamA += 1;
        }

        static void TeamBScoreGoal(FootballGame footballGame) {
            footballGame.goalTeamB += 1;
        }



        private static void Main(string[] args) {



            // Класс чи Структура
            CharacterFromGame characterFromGame = new CharacterFromGame {
                name = "Serhii",
                position = new Position { x = 10, y = 15 },
                pathToTexture = "C:\\Game\\Texture\\Characater.png"
            };


            // Змінна класу - називається об'єктом , а сам клас - також називають шаблоном, чертеж, BluePrint, макет, опис реального об'єкту
            Human serhii = new Human { name = "Serhii", age = 30, gender = "male" };
            Human max = new Human { name = "Max", age = 27, gender = "male" };


            // COPY by VALUE
            // FULL COPY
            CharacterFromGame enemy = characterFromGame;
            enemy.name = "ENEMY";


            // Об'єкт класу
            CharacterFromGameClass objectCharacter = new CharacterFromGameClass("Serhii", new Position { x = 10, y = 10 }, new SquareRenderer(10,10));
            // COPY by Reference за посиланням
            CharacterFromGameClass enemyObjectCharacter = objectCharacter;
            enemyObjectCharacter.name = "Enemy";
            // objectCharacter => name = Enemy


            FootballGame footballGame = new FootballGame();

            TeamAScoreGoal(footballGame);
            TeamAScoreGoal(footballGame);
            TeamAScoreGoal(footballGame);
            TeamBScoreGoal(footballGame);
            Console.WriteLine($"Final score = {footballGame.goalTeamA} vs {footballGame.goalTeamB}");



            //class CharacterFromGameClass {
            //    public string name;
            //    public PositionClass position;
            //    public string pathToTexture;


            //    public CharacterFromGameClass(string name, PositionClass position, string pathToTexture = "") {
            //        this.name = name;
            //        this.position = position;
            //        this.pathToTexture = pathToTexture;
            //    }

            //    public void Move(int dx, int dy) {
            //        this.position.x = this.position.x + dx;
            //        this.position.y += dy;
            //    }
            //}


            Position startingPosition = new Position { x = 5, y = 5 };

            SquareRenderer renderer = new SquareRenderer(3,3);

            CharacterFromGameClass demonHunter = new CharacterFromGameClass("DemonHunter", startingPosition, renderer);
            CharacterFromGameClass demonSlayer = new CharacterFromGameClass("DemonSlayer", startingPosition, renderer);


            //demonHunter.position.x += 10;
            //demonHunter.position.y += 5;

            demonHunter.Move(5, 2);

            demonHunter.Attack(demonSlayer);
            demonHunter.Attack(demonSlayer);
            demonHunter.Attack(demonSlayer);
            Attack(demonSlayer, demonHunter);
            // Why position for DemonSlayer also was  changed ???? => because we use "class" for position as reference







            // Коли що використовувати структуру чи класс? 
            // 1. Чи хочу я коли я передаю зміні у функція щоб створювалася нова копія чи я хочу поширювати лише посилання?
            // 2. наскільки багато змінних всередині?


            // Класи: об'єкти та статичні

            //Math math = new Math();
            //Math math2 = new Math();
            //Math math3 = new Math();
            //Math math4 = new Math();
            //Math math5 = new Math();

            //int result = math.AddWithObject(5, 10);

            //float area = math.AreaCircle(10);

            int result2 = Math.AddStatic(10, 15);

            //math2.Move(5);

            Console.WriteLine($"mathPosition = {Math.positionX}");


            Random random = new Random();
            random.Next(10);
            /*
             * Якщо у Вас у класі є багато змінних, і функція постійно змінюють зміні в середині - то скоріш за все 
             * Вам потрібно використовувати об'єкти і не використовувати static
             * Чи навпаки, у Вашому класі відсутні поля, Ваші функції лише роблять операція, при цьому не змінюючи нічого в середні класу
             */

            // No effect inside class => use static functions
            for(int i =0;i < 1000;i++) {
                Math.AddStatic(5 , 10);
            }

            // I want effects inside class => use non-static functions
            for(int i =0;i < 1000;i++) {
                demonHunter.Move(5, 2);
            }


            // Написати функцію яка при виклику виводить в консоль 
            // ######
            // #    #
            // #    #
            // #    #
            // #    #
            // #    #
            // ######
            // Class name = SquareRenderer
            // Render

            // OptionA 
            // SquareRenderer renderer = new SquareRendederer();
            // renderer.Render(); // виклик у об'єкта
            SquareRenderer renderer2 = new SquareRenderer(5,10);
            renderer2.Render();

            SquareRendererStatic.Render(10, 5);
            // OptionB 
            // SquareRenderer.Render(); // static виклик

            demonHunter.Render();


            // Принципи ООП:
            // 1. інкапсуляція
            // 2. наслідування
            // 3. абстракція
            // 4. поліморфізм
        }
    }
}