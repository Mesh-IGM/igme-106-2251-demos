using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MG_InputText
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Rectangle catPos;
        private Texture2D catImg;

        private SpriteFont defaultFont;
        private SpriteFont titleFont;

        private Vector2 direction = Vector2.Zero;
        private int speed = 150; // pixels per second

        private MouseState mPrevState;

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

            // TODO: use this.Content to load your game content here
            defaultFont = Content.Load<SpriteFont>("defaultFont");
            titleFont = Content.Load<SpriteFont>("titleFont");

            catImg = Content.Load<Texture2D>("cat");
            catPos = new Rectangle(10,10,catImg.Width/2,catImg.Height/2);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            MouseState mCurrentState = Mouse.GetState();

            if(mCurrentState.LeftButton == ButtonState.Released
                && mPrevState.LeftButton == ButtonState.Pressed)
            {
                catPos.X = mCurrentState.X;
                catPos.Y = mCurrentState.Y;
            }

            KeyboardState kbState = Keyboard.GetState();

            // reset direction base on current state
            direction = Vector2.Zero;

            // Up
            if(kbState.IsKeyDown(Keys.W))
            {
                direction.Y -= 1;
            }

            // Down
            if (kbState.IsKeyDown(Keys.S))
            {
                direction.Y += 1;
            }

            // Left
            if (kbState.IsKeyDown(Keys.A))
            {
                direction.X -= 1;
            }

            // right
            if (kbState.IsKeyDown(Keys.D))
            {
                direction.X += 1;
            }

            if (direction != Vector2.Zero)
            {
                direction.Normalize();
            }

            // Calc velocity based on direction & speed, then apply to the position based on delta time
            Vector2 velocity = direction * speed;
            catPos.X += (int)(velocity.X * gameTime.ElapsedGameTime.TotalSeconds);
            catPos.Y += (int)(velocity.Y * gameTime.ElapsedGameTime.TotalSeconds);


            // update cache of "previous" state last
            mPrevState = mCurrentState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(catImg, catPos, Color.White);

            _spriteBatch.DrawString(titleFont, "HELLO", new Vector2(5, 5), Color.Black);
            _spriteBatch.DrawString(defaultFont, string.Format($"{catPos.X}, {catPos.Y}"), new Vector2(400, 10), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
