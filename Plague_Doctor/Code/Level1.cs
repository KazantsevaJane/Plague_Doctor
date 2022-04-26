using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Plague_Doctor
{
    class Level1
    {
        static public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Houses.House2, new Vector2(0, Game1.WindowHeight), Color.White);
            spriteBatch.Draw(Player.PlayerStandSprite, new Vector2(85, Game1.WindowHeight - Houses.House2.Height), Color.White);
            
            //spriteBatch.Draw(Houses.House3, new Vector2(Houses.House2.Width, Game1.WindowHeight), Color.White);
            //spriteBatch.Draw(Houses.House4, new Vector2(Houses.House3.Width + Houses.House2.Width, Game1.WindowHeight), Color.White);
        }
        static public void Update()
        { }
    }
}
