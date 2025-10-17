using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D ducky;

        private Vector2 duckyLoc = Vector2.Zero;
        private float speed = 2f;
        private Vector2 direction = new Vector2(1, 1);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            // NOTE: Using System.Diagnostics.Debug.WriteLine puts the output 
            // in the Debug window since we don't have a console!
            System.Diagnostics.Debug.WriteLine("Hello GDAPS2!");

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ducky = Content.Load<Texture2D>("ducky");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            direction.Normalize();
            Vector2 velocity = direction * speed;
            duckyLoc += velocity;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Regular size
            // Positioned at (20, 20) 
            // No color overlay
            _spriteBatch.Draw(ducky,
                             duckyLoc,
                             Color.White);

            // Resized to 100 x 100 - must use Rectangle overload
            // Positioned at (500, 300)
            // Red color overlay
            _spriteBatch.Draw(ducky,
                             new Rectangle(500, 300, 100, 100),
                             Color.Yellow);

            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
