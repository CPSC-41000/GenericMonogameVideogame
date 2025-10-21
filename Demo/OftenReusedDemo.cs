using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;
using SharpDX.Win32;

namespace ToeJamAndEarlFirstBatch
{
    public class OftenReusedDemo
    {
        public static void AddTextures0(TextureManager textureManager, GraphicsDevice device)
        {
            FileStream stream = FileManager.GetFile("ToeJam_Transparent.png");
            textureManager.Add(0, Texture2D.FromStream(device, stream));

            stream = FileManager.GetFile("Floor_path_tiles.png");
            textureManager.Add(1, Texture2D.FromStream(device, stream));

            stream = FileManager.GetFile("Little_guy_sprites.png");
            textureManager.Add(2, Texture2D.FromStream(device, stream));
        }

        public static void AddRectangles_16pxby16px_4by4(RectangleManager rectangleManager)
        {
            int n = 32;
            int x = 0;
            int y = 0;
            for (int i = 0; i < n; ++i)
            {
                rectangleManager.Add(i, new Rectangle(x * 16, y * 16, 16, 16));
                ++x;
                if ((i + 1) % 4 == 0)
                {
                    ++y;
                    x = 0;
                }
            }
        }

        public static void AddTexturesHelpers(TextureManager textureManager, GraphicsDevice device)
        {
            Texture2D pixel = new Texture2D(device, 1, 1);
            pixel.SetData([Color.White]);
            textureManager.Add(3, pixel);
        }


        public static ref Arrow AddArrow(GameManager gameManager)
        {
            throw new NotImplementedException();
        }

        internal static Little_Guy AddLilGuy(ref ComponentArrayMap map, ref TextureManager textureManager,
            ref RectangleManager rectangleManager)
        {
            Little_Guy lil = new(ref map, ref textureManager.Find(2), ref rectangleManager);
            
            Vector2 pos = new Vector2(0, 0);
            lil.SetPosition(pos);
            
            Vector2 dimensions = new Vector2(16, 16);
            Component box0 = new CollisionAABB(ref textureManager.Find(4), ref rectangleManager.Find(33),() => lil.GetPosition(), dimensions);
            lil.AddComponent(Component.TypeID.Collision, ref box0);
            return lil;
        }

        public static Wall AddWall(ref ComponentArrayMap map, ref TextureManager textureManager, ref RectangleManager rectangleManager)
        {
            Vector2 pos = new Vector2(300, 0);
            Vector2 dimensions = new Vector2(400, 400);

            rectangleManager.Add(32, new Rectangle((int)pos.X, (int)pos.Y,
                (int)dimensions.X, (int)dimensions.Y));
            Wall wall = new Wall(ref map, ref textureManager.Find(3), ref rectangleManager.Find(32), ref pos);

            Component box1 = new CollisionAABB(ref textureManager.Find(4), ref rectangleManager.Find(32),() => wall.GetPosition(), dimensions);
            wall.AddComponent(Component.TypeID.Collision, ref box1);
            return wall;
        }

        public static void AddRectangle_Wall(RectangleManager rectangleManager)
        {
        }

        public static void AddTextureCollisionBox(TextureManager textureManager, GraphicsDevice device)
        {
            FileStream stream = FileManager.GetFile("BlackBorder.png");
            textureManager.Add(4, Texture2D.FromStream(device, stream));
        }
    }
}
