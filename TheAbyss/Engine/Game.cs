//using Raylib_cs;
//using static Raylib_cs.Raylib;
using Raylib_CsLo;
using static Raylib_CsLo.Raylib;

using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace TheAbyss.Engine
{
    class Game
    {
        //Texture2D DivineFlame;
        Texture DivineFlame;
        public static List<Entity> entityList = new List<Entity>();
        

        public void LoadGame()
        {
            //load assets here
            //make a sprite sheet for every texture in the game at some point
            //one for 16x16 textures, 32x32, 48x48 etc etc, that way only have to load those files and then ocassionally larger files that break
            //the average sprite size
            DivineFlame = LoadTexture("Sprites/DivineFlame.png");
        }

        public void Update(float DeltaTime)
        {
            for (int x = 0; x < entityList.Count; x++)
                entityList[x]?.Update();
            
            // have logic handeled here
            PreDraw();
        }

        public void PreDraw()
        {
            //this happens before draw
            BeginDrawing();
            ClearBackground(WHITE);
            //code to happen before draw
            Draw();
        }

        public void Draw()
        {
            //this happens after PreDraw but before PostDraw, used for drawing most things
            DrawText("Hello World", 10, 10, 32, BLACK);
            //Sprite.Draw(DivineFlame, new Vector2(250, 250), Color.WHITE);
            Sprite.Animate(DivineFlame, new Vector2(250, 250), 32, 32, WHITE, 8, 0.1f);
            PostDraw();
        }

        public void PostDraw()
        {
            //do some thing before the drawing is done.
            EndDrawing();
        }
    }
}
