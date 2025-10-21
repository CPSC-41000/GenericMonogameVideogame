using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace ToeJamAndEarlFirstBatch
{
    public class RectangleManager
    {
        public static void Destroy()
        {
        }

        public RectangleManager(int size)
        {
            _Rectangles = new Rectangle[size];
        }

        public void Add(int index, Rectangle texture)
        {
            _Rectangles[index] = texture;
        }

        public ref Rectangle Find(int index)
        {
            return ref _Rectangles[index];
        }

        private Rectangle[] _Rectangles;
    }
}
