using System;
using Raylib_cs;

setup();

void setup()
{
    Raylib.InitWindow(1280, 720, "Game yes");

    Texture2D playerIcon = Raylib.LoadTexture(@"stonks_pic.png");

    double playerX = 10, playerY = 10;
    double speed = 0.3;
    int goalPosX = 1080, goalPosY = 310;



    while (!Raylib.WindowShouldClose())
    {
        Rectangle player = new Rectangle((int)playerX, (int)playerY, 100, 100);
        Rectangle goal = new Rectangle(goalPosX, goalPosY, 100, 100);
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawRectangleRec(player, Color.BLUE);
        Raylib.DrawRectangleRec(goal, Color.GOLD);
        Raylib.DrawTexture(playerIcon, (int)playerX, (int)playerY, Color.WHITE);
        Raylib.EndDrawing();



        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && playerY > 0)
        {
            playerY -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerY + 100 < Raylib.GetScreenHeight())
        {
            playerY += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerX > 0)
        {
            playerX -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerX + 100 < Raylib.GetScreenWidth())
        {
            playerX += speed;
        }
    }
}
