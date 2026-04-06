using LiveSimulation.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LiveSimulation
{
    public class Game1 : Game
    {
        private const int PreferredWidth = 1280;
        private const int PreferredHeight = 720;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = PreferredWidth;
            _graphics.PreferredBackBufferHeight = PreferredHeight;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            DrawGameObjects();

            base.Draw(gameTime);
        }

        private void DrawGameObjects()
        {
            var _pixel = new Texture2D(GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });
            _spriteBatch.Begin();
            _spriteBatch.Draw(_pixel, new Rectangle(100, 100, 10, 10), Color.Red);
            _spriteBatch.End();
        }

        private void InitGameObjects()
        {
            var grid = new Grid();
        }
    }
}
