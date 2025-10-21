using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ToeJamAndEarlFirstBatch;

class PauseState : GamePlayState
{
    public PauseState()
        : base("Pause State")
    {
        _justDrawList = new List<GameObject>();
    }
    
    public void AddDrawableObject(ref GameObject obj)
    {
        _justDrawList.Add(obj);
    }

    public new void Draw(SpriteBatch spriteBatch)
    {
        foreach (var item in this._justDrawList)
        {
            item.Draw(spriteBatch);
        }

        foreach (var item in this._objects)
        {
            item.Draw(spriteBatch);
        }
    }

    protected List<GameObject> _justDrawList;
}