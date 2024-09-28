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
      

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
          Window.SetTitle("Sword.v2");
          Window.SetSize(800, 600);

            Color Brown = new Color(113, 56, 56);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(color:Color.OffWhite);

            //Blade
             
          Draw.Rectangle(350,180,100,220);
          Draw.FillColor = Color.LightGray;

            
            
            //Crossguard
            
          Draw.Rectangle(300,150,200,30);
          Draw.FillColor = Color.Black;

            
            
            //Handle
            
          Draw.Rectangle(380, 50, 40, 100);
          Draw.FillColor = Color.Brown;
            
            
            //Tip
            
          Draw.Triangle(350, 400, 400, 450, 450, 400);
            

            //Fuller
            
          Draw.Capsule(400, 210, 400, 400, 20);
          Draw.FillColor = Color.DarkGray;

            //Blood droplet
            
                Draw.Circle(400, 480, 10);
                Draw.Triangle(400, 450, 390, 480, 410, 480);

            //Pommel and jewels

            DrawJewel(280, 165);
            DrawJewel(520, 165);
            DrawJewel(400, 35);

            void DrawJewel(int x, int y)
            {
                Draw.LineSize = 1;
                Draw.FillColor = Color.Brown;
                Draw.LineColor = Color.Black;

                Draw.Circle(x, y, 30);

            }

        }
    }
}
