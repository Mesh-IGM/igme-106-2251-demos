using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MG_HelloWorld
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D raccoonImg;

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
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            raccoonImg = Content.Load<Texture2D>("raccoon");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape)
            )
            {
                Exit();
            }

            // TODO: Add your update logic here
            //System.Diagnostics.Debug.WriteLine("Hello!");

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.OrangeRed);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();


            _spriteBatch.Draw(
                raccoonImg,
                new Rectangle(25, 25, raccoonImg.Width / 2, raccoonImg.Height / 2),
                Color.Violet
                );

            _spriteBatch.Draw(raccoonImg, new Vector2(50, 50), Color.White);

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
