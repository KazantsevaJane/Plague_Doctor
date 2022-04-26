using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plague_Doctor
{
    class GamePlay
    {
        enum Levels
        {
            Level1,
            Level2
        }
        static Levels Level;
        void SetLevelNumber(Levels level)
        {
            Level = Levels.Level1;
        }
        static public void Draw(SpriteBatch spriteBatch)
        {
            switch (Level)
            {
                case Levels.Level1:
                    Level1.Draw(spriteBatch);
                        break;
            }

        }
        static public void UpDate()
        {
            switch (Level)
            {
                case Levels.Level1:
                    Level1.Update();
                    break;
            }
        }
    }
}

