using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Plague_Doctor
{
    class Level1
    {
        static List<Texture2D> HousesArray = new List<Texture2D>();
        static Player player = new Player();
        static Rectangle rect;
        static public void Init(SpriteBatch spriteBatch)
        {
            HousesArray = new List<Texture2D> { Houses.House2, Houses.House3, Houses.House4 };
            player.Init(spriteBatch, 0, Game1.WindowHeight - Houses.House2.Height - Player.PlayerStandSprite.Height);
        }
        static public void Draw(SpriteBatch spriteBatch)
        { 
            var x = 0;
            foreach(var house in HousesArray)
            {
                var y = Game1.WindowHeight;
                spriteBatch.Draw(house, new Vector2(x, y - house.Height), Color.White);
                x += house.Width;
            }
            player.Draw(spriteBatch);
            //spriteBatch.Draw(Houses.House2, new Vector2(0, Game1.WindowHeight - Houses.House2.Height), Color.White);
            //spriteBatch.Draw(Houses.House3, new Vector2(Houses.House2.Width, Game1.WindowHeight - Houses.House3.Height), Color.White);
            //spriteBatch.Draw(Houses.House4, new Vector2(Houses.House3.Width + Houses.House2.Width, Game1.WindowHeight), Color.White);            
        }
        static public void Update()
        {
            player.Update();
        }
    }
}
