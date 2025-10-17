using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic; // Add manually for access to .NET collections!

namespace MG_StructsDemo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Store everywhere that I want to place a duck
        private List<Vector2> gridLocs = new List<Vector2>();

        // Use a constant to define the size of the ducky grid I want to make
        private const int NumDuckies = 4;  // More than 10 and they overlap each other because this demo
                                            // doesn't dynamically scale the texture size

        // The ducky texture
        private Texture2D ducky;

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
            System.Diagnostics.Debug.WriteLine("NumDuckies = " + NumDuckies);

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ducky = Content.Load<Texture2D>("ducky");

            // Once we've loaded the texture, we can setup our grid based on its size

            // Calculate the max dimensions we can start a ducky within
            int maxX = _graphics.GraphicsDevice.Viewport.Width - ducky.Width;
            int maxY = _graphics.GraphicsDevice.Viewport.Height - ducky.Height;

            // Calculate the grid offsets based on the # of duckys we want to draw and
            // the max dimension.
            // (NumDuckies-1) in each direction because we need the number of gaps, not the
            // number of duckies (1 ducky gets drawn in the first iteration at 0,0)
            int xOffset = maxX / (NumDuckies - 1);
            int yOffset = maxY / (NumDuckies - 1);

            // For each row/col increment Y/X based on the number of grid spots over we are
            // Stop when y/x goes past the maximum value where we can start drawing a
            // duck and have it still fully on the canvas
            for (int y = 0; y <= maxY; y += yOffset)
            {
                for (int x = 0; x <= maxX; x += xOffset)
                {
                    gridLocs.Add(new Vector2(x, y));
                }
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            for (int i=0; i<gridLocs.Count; i++)
            {
                // IMPORTANT! - The assignment operator (=) makes COPIES
                // when working with all value types

                // This LOOKS like it should work, but it won't even compile!
                // gridLocs[i] is "not a variable". It's a confusing error
                // message, but it's right. Because this is a List of value
                // types (Vector2's are structs!), the [i] returns us a COPY of 
                // the element, NOT a reference to an object we can then edit.
                //gridLocs[i].X += 1;
                //gridLocs[i].Y += 1;

                // INSTEAD, To update the locations, we have to:
                
                // 1. Get a copy of the one to change
                Vector2 loc = gridLocs[i];

                // 2. Update our copy
                loc.X += 1;
                loc.Y += 1;

                // 3. Overwrite the value element in the list with our new value
                gridLocs[i] = loc;
                
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            foreach(Vector2 loc in gridLocs)
            {
                _spriteBatch.Draw(ducky, loc, Color.Yellow);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
