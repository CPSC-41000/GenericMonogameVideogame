using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public abstract class GraphicsComponent : Component
    {
        public abstract void Draw(SpriteBatch spriteBatch, Vector2 position);
    }


}
