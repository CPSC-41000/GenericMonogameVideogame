using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GamePlayState
    {
        public GamePlayState(string name)
        {
            _objects = new();
            this.name = name;
        }

        public void Update(GameTime gametime)
        {
            foreach (var item in this._objects)
            {
                item.Update(gametime);
            }
        }

        public void Draw(SpriteBatch batch)
        {
            foreach (var item in this._objects)
            {
                item.Draw(batch);
            }
        }

        public void AddGameObject(ref GameObject gameObject)
        {
            _objects.Add(gameObject);
        }


        protected List<GameObject> _objects;
        String name;
    }
}
