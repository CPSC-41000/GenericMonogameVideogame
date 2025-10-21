using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    internal class RightWallGraphics : Component
    {
        private Texture2D texture;
        private int index;
        private RectangleManager rectangleManager;
        private int v1;
        private float v2;

        public RightWallGraphics(ref Texture2D texture, int index, ref RectangleManager rectangleManager, int v1, float v2)
        {
            this.texture = texture;
            this.index = index;
            this.rectangleManager = rectangleManager;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}