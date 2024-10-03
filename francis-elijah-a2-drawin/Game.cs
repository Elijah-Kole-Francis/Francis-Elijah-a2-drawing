// Include code libraries you need here:
using System;
using System.Data;
using System.Numerics;

// Where your code is placed.
namespace francis_elijah_a2_drawin
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color colorRandom = Random.Color();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
          Window.SetTitle("Sword, new and improved");
          Window.SetSize(800, 600);

            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        
        /// The shape is coming up incorrectly coloured
        /// investigate and seek out the issue as to why
        /// positions are fine and update well
        public void Update()
        {
            Window.ClearBackground(color:Color.OffWhite);

            //Blade
          
          Draw.FillColor = Color.LightGray;
          Draw.Quad(450,200,500,250,250,450,200,400);
          Draw.FillColor = Color.LightGray;

            //Crossguard
            
          Draw.Quad(420,130,570,280,550,300,400,150);
          Draw.FillColor = new Color(113,56,56);


            //Handle

            Draw.FillColor = new Color(113, 56, 56);
            Draw.Quad(580,100,610,130,510,220,480,190);

            
            Draw.LineSize = 5; 
            Draw.LineColor = Color.Black;
            Draw.Line(510,220,510,165);
            Draw.Line(510, 165, 565, 165);
            Draw.Line(565, 165, 565, 115);
            

            //Tip and blood smear
            Draw.LineSize = 1;
            Draw.FillColor = Color.Red;
            Draw.Triangle(200,400,250,450,170,470);
            Draw.Triangle(230, 430, 300, 410, 250, 450);

            //Pommel and jewels
            DrawJewel(410, 145);
            DrawJewel(600, 110);
            DrawJewel(570, 300);

            //Fuller
            Draw.FillColor = Color.DarkGray;
            Draw.Capsule(450,240, 240,410, 10);


            //Blood droplet
            void DrawDroplet(int x, int y)
            {
                Draw.FillColor = Color.Red;
                Draw.LineSize = 1;
                Draw.Triangle(x, y + 20, x - 10, y + 50, x + 10, y + 50);
                Draw.Circle(x, y + 50, 10);
            }

            DrawDroplet(170,470);
            

            void DrawJewel(int x, int y)
            {
                Draw.LineSize = 1;
                Draw.FillColor = Color.LightGray;
                Draw.LineColor = Color.Black;
                Draw.Circle(x, y, 20);

                Draw.FillColor = colorRandom;
                Draw.Circle(x, y, 10);

                Draw.FillColor = Color.White;
                Draw.Circle(x + 5, y - 3, 3);

            }
            
            //Gonna see if I can draw a blood droplet in a certain area equal to the input number
            //maybe I'll just do console interactivity
            
            Console.WriteLine("How many enemies have been felled by the sword?");
            int enemyFelled = int.Parse(Console.ReadLine());
            for (int i = 0; i <= enemyFelled; i++)
            {
                int bloodiedBlade = enemyFelled * i + 100;
                Console.WriteLine($"What a mighty warrior you are! You felled" + bloodiedBlade +" enemies!");
                
            }

        }
    }
}
