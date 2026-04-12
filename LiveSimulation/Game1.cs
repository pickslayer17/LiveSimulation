using LiveSimulation.BaseModels;
using LiveSimulation.GameModels;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LiveSimulation
{
    public class Game1 : Game
    {
        private const int PreferredWidth = 1283;
        private const int PreferredHeight = 720;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private World _world;

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
            var grid = CreateGrid();
            grid.InitializeCells();
            _world = new World(grid);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            var fly = new Fly();
            _world.AddGameObject(fly, 350, 100);
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

            DrawWorld();

            base.Draw(gameTime);
        }

        private void DrawWorld()
        {
            foreach (var gameObject in _world.GameObjects)
            {
                if (gameObject is Fly)
                {
                    DrawFly(gameObject);
                }
            }
        }

        private void DrawFly(GameObject gameObject)
        {
            var _pixel = new Texture2D(GraphicsDevice, 1, 1);
            _pixel.SetData(new[] { Color.White });

            var x = gameObject.X;
            var y = gameObject.Y;
            _spriteBatch.Begin();
            _spriteBatch.Draw(_pixel, new Rectangle((int)x, (int)y, 10, 10), Color.Red);
            _spriteBatch.End();
        }

        private Grid CreateGrid()
        {
            var grid = new Grid(PreferredWidth, PreferredHeight, 10);

            return grid;
        }
    }
}
