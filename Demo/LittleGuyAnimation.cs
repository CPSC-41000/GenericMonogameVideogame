using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class LittleGuyAnimation : Animation
    {
      
        List<List<Rectangle>> _AnimationLists;
        private float _angle;
        //Arrow _arrow;
        LittleGuyDirection _currentState;

        public LittleGuyAnimation(ref Texture2D texture,
            List<int> indices,
            ref RectangleManager rectMan, 
            int index,
            float uniformScale) 
            : base(ref texture,index, uniformScale)
        {
            _AnimationLists = new List<List<Rectangle>>();
            int i = 0;
            foreach (var ind in indices) 
            {
                if(i % 4 == 0)
                {
                    _AnimationLists.Add(new List<Rectangle>());
                }
                
                _AnimationLists[i / 4].Add(rectMan.Find(ind));
                i++;
            };

            SetActiveList(6, 0);
            _angle = 0.0f;
            //_arrow = arrow;
            _currentState = LittleGuyDirection.RIGHT;
        }

        public void SetActiveList(int listIndex, int activeSprite)
        {
            _Sprites = _AnimationLists[listIndex];
            _CurrentSprite = _Sprites[activeSprite];
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            base.Draw(spriteBatch, position);

            //Vector2 direction = new Vector2((float)Math.Cos(_angle), (float)Math.Sin(_angle));
        }

        public void Rotate(float degrees)
        {
            _angle += degrees * MathF.PI / 180f;
            this._currentState = ConvertAngleToDirection((int)degrees); 
            this.SwapAnimation();
        }

        public void SwapAnimation()
        {
            //this._currentState = ConvertAngleToDirection(((int)_angle) % 360);
            this.SetActiveList((int)this._currentState, this._index);
        }

        private LittleGuyDirection ConvertAngleToDirection(int v)
        {
            LittleGuyDirection direction = LittleGuyDirection.LEFT;

            int mul = v / 45;

            int newDirection = mul + (int)this._currentState;
            if(newDirection > 7)
            {
                newDirection = newDirection % 8;
            }
            else if(newDirection < 0)
            {
                newDirection = 7 - newDirection % 8;
            }
            return (LittleGuyDirection)newDirection;
        }

        public LittleGuyDirection GetDirection()
        {
            return this._currentState;
        }
    }
}
