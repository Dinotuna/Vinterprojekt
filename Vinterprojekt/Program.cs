using Raylib_cs;

Raylib.InitWindow(800, 600, "hello");
Raylib.SetTargetFPS(60);



string scene = "start";




while (!Raylib.WindowShouldClose());
{
    if (scene == "game");
    {
        
    }
    
    else if (scene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            scene = "game";
        }
    }

    // -----------Drawing-----------

    Raylib.BeginDrawing(); 
    if (scene == "game")
    {
        Raylib.ClearBackground(Color.WHITE);





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