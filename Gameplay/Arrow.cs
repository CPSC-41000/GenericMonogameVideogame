
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Arrow : GraphicsComponent
    {
        public Arrow(Vector2 position, Vector2 direction)
        {

        }

        public Arrow(int length, int squareSize, ref Texture2D pixel)
        {
            _length = length;
            _squareSize = squareSize;

            _pixel = pixel;
            _pixel.SetData(new[] { Color.White });
        }

        Vector2 OFFSET = new Vector2(8, 8);

        public void Draw(SpriteBatch spriteBatch, Vector2 origin, Vector2 direction, Color color)
        {
            direction.Normalize();
            for (int i = 1; i <= _length; i++)
            {
                Vector2 pos = origin + (4*OFFSET) + direction * _squareSize * i;
                spriteBatch.Draw(_pixel,
                                 new Rectangle((int)pos.X, (int)pos.Y, _squareSize, _squareSize),
                                 color);
            }
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public bool HasCollisionAtTarget()
        {
            bool res = false;



            return res;

        }

        public Texture2D _pixel;
        public int _length;
        public int _squareSize;
    }
}
