using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace ToeJamAndEarlFirstBatch
{
    public class Little_Guy : GameObject
    {
        BehaviorLists blist;
        int moveCount = 0;

        public enum Behaviors
        {
            Spinning,
            PerimeterRun,
            Perimeter,
            RunIntoWall
        }

        public Little_Guy(
            ref ComponentArrayMap map,
            ref Texture2D texture,
            ref RectangleManager rectangleManager)
            : base(ref map)
        { 
            List<int> list = new List<int>();
            for(int i = 0; i < 32; ++i)
            {
                list.Add(i);
            }

            Component _GraphicsComponent = new LittleGuyAnimation(ref texture, list,
            ref rectangleManager, 0, 4.0f);
            map.AddComponent(Component.TypeID.Graphics, ref _GraphicsComponent);
            blist = new BehaviorLists();

            Component _GameplayComponent = new LittleGuyMovement(ref blist);
            GameplayComponent obj = (GameplayComponent)map
                .AddComponent(Component.TypeID.Gameplay,ref _GameplayComponent);

            //Component _CollisionComponent = new CollisionAABB();
            //CollisionComponent collisionComponent = (CollisionComponent)map
            //    .AddComponent(Component.TypeID.Collision,ref _CollisionComponent);
        }

        public void SetPosition(Vector2 position)
        {
            ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay)).position = position;
        }

        public Vector2 GetPosition()
        {
            return ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay)).position;
        }

        private void RotateCW(float degrees)
        {
            ((LittleGuyAnimation)this.GetComponent((int)Component.TypeID.Graphics)).Rotate(degrees);
        }

        private void MoveTillSeeCollision()
        {
            this.Move(((LittleGuyAnimation)this.GetComponent((int)Component.TypeID.Graphics)).GetDirection());
            this.moveCount++;
        }

        private void Move750Times()
        {
            if (this.moveCount < 750)
            {
                this.Move(((LittleGuyAnimation)this.GetComponent((int)Component.TypeID.Graphics)).GetDirection());
                this.moveCount++;
            }
            else
            {
                this.moveCount = 0;
                this.blist.SetNextAction(1);
            }
        }

        public void SetBehaviorSpinning()
        {
            blist.AddBehavior(MoveTillSeeCollision);
            blist.AddBehavior(() => {
                this.RotateCW(90.0f);
                blist.SetNextAction(0);
            });
        }

        public void SetBehaviorPerimeterRun()
        {
            //blist = new BehaviorLists();
            blist.AddBehavior(Move750Times);
            blist.AddBehavior(() => {
                this.RotateCW(90.0f);
                blist.SetNextAction(0);
            });

            blist.SetNextAction(0);
        }

        public void SetBehaviorRunIntoWall()
        {
            //blist = new BehaviorLists();
            blist.AddBehavior(() =>
            {
                this.Move(((LittleGuyAnimation)this.GetComponent((int)Component.TypeID.Graphics)).GetDirection());
            });
            blist.AddBehavior(() => {
                this.RotateCW(90.0f);
                blist.SetNextAction(0);
            });

            blist.SetNextAction(0);
        }

        public void SetNextAction(int i)
        {
            blist.SetNextAction(i);
        }

        public void SetBehavior(int behaviorState)
        {
            Behaviors beh = (Behaviors)behaviorState;
            switch (beh)
            {
                case Behaviors.Spinning:
                {
                    SetBehaviorSpinning();
                    break;
                }
                case Behaviors.PerimeterRun:
                {
                    SetBehaviorPerimeterRun();
                    break;
                }
                case Behaviors.RunIntoWall:
                {
                    SetBehaviorRunIntoWall();
                    break;
                }
            }
        }

        void Move(LittleGuyDirection LittleGuyDirection)
        {
            switch (LittleGuyDirection)
            {
                case LittleGuyDirection.RIGHT:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        .position += new Vector2(1,0);
                    return;
                case LittleGuyDirection.FRONT:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        .position += new Vector2(0, 1);
                    return;
                case LittleGuyDirection.BACK:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        .position -= new Vector2(0, 1);
                    return;
                case LittleGuyDirection.LEFT:
                    ((GameplayComponent)this.GetComponent((int)Component.TypeID.Gameplay))
                        .position -= new Vector2(1, 0);
                    return;
                default:
                    return;
            }
        }

        public void AddArrow(Arrow arrow)
        {
            throw new NotImplementedException();
        }
    }
}
