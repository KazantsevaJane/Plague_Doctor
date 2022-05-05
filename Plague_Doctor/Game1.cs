using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Plague_Doctor
{
    public class Game1 : Game
    {
        enum GameState
        {
            Menu,
            Gameplay,
            EndOfGame
        }

        GameState state = GameState.Gameplay;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        static public int WindowWigth;
        static public int WindowHeight;
        static public KeyboardState keyboardState;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            WindowWigth = Window.ClientBounds.Width;
            WindowHeight = Window.ClientBounds.Height;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Player.PlayerStandSprite = Content.Load<Texture2D>("PlayerStand");
            Houses.House2 = Content.Load<Texture2D>("House-2");
            Houses.House3 = Content.Load<Texture2D>("House-3");
            Houses.House4 = Content.Load<Texture2D>("House-4");
            Level1.Init(_spriteBatch);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
            switch (state)
            {
                //case GameState.Menu:
                //    UpdateMenu(gameTime);
                //    break;
                case GameState.Gameplay:
                    GamePlay.UpDate();
                    break;
                //case GameState.EndOfGame:
                //    UpdateEndOfGame(gameTime);
                //    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            GamePlay.Draw(_spriteBatch);
            //_spriteBatch.Draw(Player.PlayerStandSprite, new Vector2(85, Game1.WindowHeight - Houses.House2.Height-Player.PlayerStandSprite.Height), Color.White);
            //_spriteBatch.Draw(Houses.House2, new Vector2(0, Game1.WindowHeight - Houses.House2.Height), Color.White);
            //_spriteBatch.Draw(Houses.House3, new Vector2(Houses.House2.Width, Game1.WindowHeight - Houses.House3.Height), Color.White);
            //_spriteBatch.Draw(Houses.House4, new Vector2(0, Game1.WindowHeight - Houses.House4.Height), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
