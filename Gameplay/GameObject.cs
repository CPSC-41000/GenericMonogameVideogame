using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ToeJamAndEarlFirstBatch.Core;

namespace ToeJamAndEarlFirstBatch
{
    public class GameObject
    {
        protected ComponentArrayMap _map;

        public GameObject(ref ComponentArrayMap map)
        {
            _map = map;
        }

        public void AddComponent(Component.TypeID ID, ref Component component)
        {
            _map.FillComponent(ID, ref component);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _map.Draw(spriteBatch);
        }

        public void Update(GameTime gameTime)
        {
            _map.Update(gameTime);
        }

        // Todo Change this to be more inclusive of multiple types of component returns
        public ref Component GetComponent(int componentID)
        {
            return ref _map.GetComponentOf(componentID);
        }
    }
}
