using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plague_Doctor
{
    class Player
    {
        public int lifeСounter;
        public int XCoordinate { get { return xCoordinate; } }
        private int xCoordinate;
        private int yCoordinate;
        public int YCoordinate { get { return yCoordinate; } }
        private int Speed = 3;

        public static Texture2D PlayerStandSprite { get; set; }

        public void Init(SpriteBatch spriteBatch, int x, int y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Player.PlayerStandSprite, new Vector2(XCoordinate, YCoordinate), Color.White);
        }

        public bool CanMove(int DirX, int DirY)
        {
            if (xCoordinate + DirX >= 0 
                && yCoordinate + DirY >= 0 
                && xCoordinate + DirX < Game1.WindowWigth - PlayerStandSprite.Width 
                && yCoordinate + DirY < Game1.WindowHeight - PlayerStandSprite.Height)
                return true;
            return false;
        }

        public void Update()
        {
            if (Game1.keyboardState.IsKeyDown(Keys.D) && CanMove(Speed, 0)) /*&& Intersects(otherSprite))*/
            {
                xCoordinate += Speed;
            }
            if (Game1.keyboardState.IsKeyDown(Keys.A) && CanMove(-Speed, 0))
            {
                xCoordinate -= Speed;
            }
            if (Game1.keyboardState.IsKeyDown(Keys.S) && CanMove(0, Speed))
            {
                yCoordinate += Speed;
            }
            if (Game1.keyboardState.IsKeyDown(Keys.W) && CanMove(0, -Speed))
            {
                yCoordinate -= Speed;
            }
        }
    }
}
