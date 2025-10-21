using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class GameManager
    {
        public static void Destroy()
        {
        }

        public void Update(GameTime gameTime)
        {
            if (!isPaused)
            {
                gameplayEventHandler.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            gameplayEventHandler.Draw(spriteBatch);
        }

        public void SwapPause()
        {
            isPaused = !isPaused;
        }

        public void SetCurrentState(int state)
        {
            gameplayEventHandler.SetCurrentState(state);
        }

        public void AddObject(ref GameObject lil)
        {
            gameplayEventHandler.AddGameObject(ref lil);
        }

        public GameManager() 
        {
            gameplayEventHandler = new GameplayEventHandler();
        }

        GameplayEventHandler gameplayEventHandler;
        bool isPaused;
    }
}
