using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class TextureManager
    {
        public static void Create(int size, GraphicsDevice graphicsDevice)
        {
        }

        public static void Destroy()
        {
        }

        public TextureManager(int size, GraphicsDevice graphicsDevice) 
        {
            _Textures = new Texture2D[size];
            _graphicsDevice = graphicsDevice;
        }

        public void Add(int index, Texture2D texture)
        {
            _Textures[index] = texture;
        }

        public ref Texture2D Find(int index)
        {
            return ref _Textures[index];
        }

        public ref GraphicsDevice GetGraphicsDevice()
        {
            return ref _graphicsDevice;   
        }

        private Texture2D[] _Textures;
        GraphicsDevice _graphicsDevice;
    }
}
