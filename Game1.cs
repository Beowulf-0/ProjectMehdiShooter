using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectMehdiShooter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //MovingSprite _sprite;

        //List<MovingSprite> sprites;

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
            Texture2D _texture = Content.Load<Texture2D>("player_static");
            //_sprite = new MovingSprite(_texture, Vector2.Zero, 1f);

            /*sprites = new List<MovingSprite>();

            for(int i = 0; i < 10; i++)
            {
                sprites.Add(new MovingSprite(_texture, new Vector2(0, 10*i), i));
            }*/
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //_sprite.Update();

            /*foreach(MovingSprite sprite in sprites)
             {
                 sprite.Update();
             }*/

            //Input

            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                Debug.WriteLine("Z key pressed");
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                Debug.WriteLine("Q key pressed");
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Debug.WriteLine("S key pressed");
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Debug.WriteLine("D key pressed");
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin(samplerState : SamplerState.PointClamp);
            //_spriteBatch.Draw(_sprite.texture, _sprite.rect, Color.Red);
            /*foreach (MovingSprite sprite in sprites)
            {
                _spriteBatch.Draw(sprite.texture, sprite.rect, Color.Red);
            }*/

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}