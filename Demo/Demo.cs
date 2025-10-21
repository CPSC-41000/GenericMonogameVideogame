using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Demo
    {
        public enum Name : int
        {
            Spinning = 0,
            PerimeterRun = 1,
            SoundEffect = 2,
            SoundChain = 3,
            Collision = 4,
            Physics = 5,
            SIZE = 6,
        }

        Name _name;
        public TextureManager   textureManager;
        public RectangleManager rectangleManager;
        public GameManager      gameManager;
        public CollisionManager collisionManager;

        public Demo(GraphicsDevice graphics, int textureManagerSize, int rectangleManagerSize, Name name) 
        {
            textureManager = new(textureManagerSize, graphics);
            rectangleManager = new(rectangleManagerSize);
            gameManager = new();
            collisionManager = new CollisionManager();
            _name = name;
        }

        public int getName()
        {
            return (int)_name;
        }

        public void Update(GameTime gameTime)
        {
            gameManager.Update(gameTime);
            collisionManager.ResolveCollisions(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gameManager.Draw(spriteBatch);
        }
    }
}
