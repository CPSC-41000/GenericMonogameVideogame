using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class SpinningDemo : Demo
    {
        public SpinningDemo(GraphicsDevice device) 
        : base(device, 5, 32, Name.Spinning)
        {

            

            Texture2D pixel = new Texture2D(device, 1, 1);
            pixel.SetData([Color.White]);
            this.textureManager.Add(3, pixel);

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

            //GameState gameState = new GameState(() => Debug.WriteLine("GameManager"));
            //Arrow arrow = new Arrow(6, 8, ref textureManager.Find(3));
            //Little_Guy lil = new(ref textureManager.Find(2),ref arrow,ref rectangleManager);
            //
            //GameObject obj = lil;
            //gameState.AddGameObject(ref obj);
            //
            //lil.SetBehavior((int)Little_Guy.Behaviors.Spinning);
            //lil.SetPosition(new Vector2(300, 300));
            //gameManager.AddGameState(ref gameState);
            //
            //gameState = new GameState(() => Debug.WriteLine("TimeManager"));
            //gameManager.AddGameState(ref gameState);
            //
            //gameManager.SetCurrentState(0);
            //
            //BindList bindList = new BindList(10);
            //
            //SpaceKey space = new(ref bindList);
            //LeftKey left = new(ref bindList);
            //
            //InputManager.AddBindList(ref bindList);
        }
    }
}
