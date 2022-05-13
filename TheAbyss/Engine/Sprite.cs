//using Raylib_cs;
//using static Raylib_cs.Raylib;
using Raylib_CsLo;
using static Raylib_CsLo.Raylib;

using System.Numerics;

namespace TheAbyss.Engine
{
    static class Sprite
    {
        private static int frame = 0;
        private static float offset;
        public static void Draw(Texture texture, Vector2 position, Color color)
        {
            DrawTexture(texture, (int)position.X, (int)position.Y, color);
        }

        public static void Animate(Texture texture, Vector2 position, int width, int height, Color color, int framecount, float frametime)
        {
            //add x and y for the position on the sprite sheet
            offset += GetFrameTime();
            while(offset > frametime)
            {
                offset -= frametime;
                frame++;
            }

            frame %= framecount; //does the same thing as below
            //if (frame >= framecount)
            //    frame = 0;

            DrawTextureRec(texture, new Rectangle(0, height * frame, width, height), position, color);
        }

        public static void Draw(Texture texture, Rectangle textureLoc, Vector2 position, Color color)
        {
            DrawTextureRec(texture, textureLoc, position, color);
        }
    }
}