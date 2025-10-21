using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Animation : GraphicsComponent
    {
        Texture2D       _texture;
        protected Rectangle       _CurrentSprite;
        protected List<Rectangle> _Sprites;
        protected int             _index;
        TimeSpan        _CumulativeTime;
        float           _UniformScale;

        public Animation(ref Texture2D texture, 
            int index,
            float uniformScale)
        {
            _texture = texture;
            _index = index;
            _CumulativeTime = TimeSpan.Zero;
            _UniformScale = uniformScale;
        }

        public override void Update(GameTime gameTime)
        {
            _CumulativeTime += gameTime.ElapsedGameTime;
            if (_CumulativeTime > TimeSpan.FromSeconds(1.0))
            {
                _index += 1;
                if (_index >= _Sprites.Count)
                {
                    _index = 0;
                }
                _CurrentSprite = _Sprites[_index];
                _CumulativeTime = TimeSpan.Zero;
            }
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(_texture, position, _CurrentSprite, 
                Color.White, 0, new Vector2(0, 0), _UniformScale, SpriteEffects.None,
                0.0f);
        }
    }
}
