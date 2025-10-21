using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ToeJamAndEarlFirstBatch.Core;

namespace ToeJamAndEarlFirstBatch
{
    public class ComponentArrayMap
    {
        Component.TypeID[] componentMap;
        protected Component[] components;
        public int size;

        public ComponentArrayMap(int size, Component.TypeID[] map)
        {
            this.size = size;
            components = new Component[size];
            componentMap = map;
        }

        public void FillWithNull(ref Component[] components)
        {
            for (int i = 0; i < size; i++)
            {
                components[i] = ComponentFactory.CreateNullComponent(componentMap[i]);
            }
        }

        public Component.TypeID GetComponentIDAt(int i)
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            GameplayComponent game_Component =
                (GameplayComponent)components[(int)componentMap[(int)Component.TypeID.Gameplay]];

            GraphicsComponent graphics_Component =
                (GraphicsComponent)components[(int)componentMap[(int)Component.TypeID.Graphics]];

            CollisionComponent collision_Component =
            (CollisionComponent)components[(int)componentMap[(int)Component.TypeID.Collision]];

            graphics_Component.Draw(spriteBatch, game_Component.position);
            
            collision_Component.Draw(spriteBatch, game_Component.position);
        }

        internal void FillComponent(Component.TypeID iD, ref Component component)
        {
            components[(int)iD] = component; 
        }

        public void Update(GameTime gameTime)
        {
            GameplayComponent game_Component =
                (GameplayComponent)components[(int)componentMap[(int)Component.TypeID.Gameplay]];
            game_Component.Update(gameTime);
            
            GraphicsComponent graphics_Component =
                (GraphicsComponent)components[(int)componentMap[(int)Component.TypeID.Graphics]];
            graphics_Component.Update(gameTime);
        }

        // --------------------------------------------------------------------
        // TODO - Change how these return components
        public ref Component GetComponentOf(Component.TypeID id)
        {
            return ref components[(int)componentMap[(int)id]];
        }

        public ref Component GetComponentOf(int id)
        {
            return ref components[(int)componentMap[id]];
        }

        public ref Component AddComponent(Component.TypeID id, ref Component component)
        {
            components[(int)componentMap[(int)id]]= component;
            return ref components[(int)componentMap[(int)id]];
        }
        // --------------------------------------------------------------------
    }
}