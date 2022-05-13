using Raylib_CsLo;
using static Raylib_CsLo.Raylib;

using TheAbyss.Engine;

using System.Numerics;

namespace TheAbyss
{
    class Entity
    {
        private Texture texture;
        private string name;
        private int x;
        private int y;
        private Vector2 position;

        public Entity()
        {
            Game.entityList.Add(this);
        }

        public Entity(Texture texture, string name, int x, int y)
        {
            this.texture = texture;
            this.name = name;
            this.x = x;
            this.y = y;
            position = new Vector2(x, y);
        }

        public virtual void Update()
        {

            PreDraw(texture, position, WHITE);   
        }

        public virtual void PreDraw(Texture texture, Vector2 position, Color color)
        {
            Draw(texture, position, color);
        }

        public virtual void Draw(Texture texture, Vector2 position, Color color)
        {
            Sprite.Draw(texture, position, color);

            PostDraw(texture, position, color);
        }

        public virtual void PostDraw(Texture texture, Vector2 position, Color color)
        {

        }

        public virtual void Animate(Texture texture, Vector2 position, int width, int height, Color color, int framecount, float frametime)
        {
            Sprite.Animate(texture, position, width, height, color, framecount, frametime);
        }
    }
}
