using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800, 600, "hello");
Raylib.SetTargetFPS(60);

Vector2 movement = new Vector2(0, 0);

Rectangle PlayerRect = new Rectangle(300, 100, 64, 64);

// skapa lista med rektanglar (hinder)

float speed = 3;

string scene = "start";

int points = 0;


while (!Raylib.WindowShouldClose())

{
    if (scene == "game")
    {
        movement.X = 0;

        movement.Y += 0.5f;

        if (PlayerRect.Y > 300)
        {
            movement.Y = 0;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            movement.Y = -10;
        }
        

        PlayerRect.X += movement.X;
        PlayerRect.Y += movement.Y;




    }

    else if (scene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            scene = "game";
        }
    }



// -----------Drawing----------- \\

    Raylib.BeginDrawing(); 
    if (scene == "game")
    {
        Raylib.ClearBackground(Color.WHITE);

        Raylib.DrawRectangleRec(PlayerRect, Color.BLUE);

    }

    else if (scene == "start")
    {
        Raylib.ClearBackground(Color.GRAY);
        Raylib.DrawText("TRYCK SPACE FÖR ATT BÖRJA", 10, 10, 32, Color.BLACK);
    }

    else if (scene == "finished")
    {
        Raylib.ClearBackground(Color.BROWN);
    }

    Raylib.EndDrawing();
}