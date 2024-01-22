using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

Raylib.InitWindow(800, 600, "hello");
Raylib.SetTargetFPS(60);

Vector2 PlayerMovement = new Vector2(0, 0);
Vector2 EnemyMovement = new Vector2(0, 0);

Rectangle PlayerRect = new Rectangle(300, 300, 64, 64);

Rectangle EnemyRect = new Rectangle(550, 300, 64, 64);


// skapa lista med rektanglar (hinder)

float speed = 3;

string scene = "start";

int points = 0;

float timer = 0;

List<Rectangle> enemies = new List<Rectangle>();


while (!Raylib.WindowShouldClose())



{
    if (scene == "game")
    {
        timer += Raylib.GetFrameTime();

        // lägg till Raylb.GetFrameTime() till timer
        // om timer > 1
        //   (Lägg till ny fiende) cw
        //   Nollställ timer
        // enemies.Add(new Rectangle(2, 3 ,4,4))

        if (timer > 1)
        {
            Console.WriteLine("hej");
            int enemyY = 300;
            enemies.Add(new Rectangle(550, enemyY, 64, 64));
            timer = 0;
        }   
    


        PlayerMovement.X = 0;

        PlayerMovement.Y += 0.5f;

        EnemyMovement.X += 0.25f;

        

        if (PlayerRect.Y > 300)
        {
            PlayerMovement.Y = 0;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && PlayerRect.Y > 300)
        {
            PlayerMovement.Y = -12 ;
        }



        PlayerRect.X += PlayerMovement.X;
        PlayerRect.Y += PlayerMovement.Y;

        EnemyRect.X -= EnemyMovement.X;
        EnemyRect.Y -= EnemyMovement.Y;


    
        // foreach (var enemy in enemies)
        // {
        //     enemyRect.X -= EnemyMovement.X;
        //     enemyRect.Y -= EnemyMovement.Y;
        // }



    

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

        Raylib.DrawRectangleRec(EnemyRect, Color.RED);

        // foreach som går igenom listan med fiender

        foreach (var enemy in enemies)
        {
            Raylib.DrawRectangleRec(enemy, Color.RED);
        }

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