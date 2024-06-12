using AstraEngine.Canvas2D;
using AstraEngine.Canvas2D.RaylibAdapter;
using AstraEngine.Core;

namespace AstraEngine.Examples.Pong;

public static class PongExample
{
    public static void Run()
    {
        Entity player1 = CreatePlayer1();
        Rectangle2D rectangle1 = player1.GetComponent<Rectangle2D>()!;
        Entity player2 = CreatePlayer2();
        Rectangle2D rectangle2 = player2.GetComponent<Rectangle2D>()!;
        // Create a Windowed Game
        WindowedGame game = new();
        // Add player 1 to the game
        game.Root.AddChild(player1);
        // Add player 2 to the game
        game.Root.AddChild(player2);
        // Add the ball to the game
        game.Root.AddChild(CreateBall(rectangle1, rectangle2));
        // Run the game
        Engine.Run(game);
    }
    private static Entity CreateBall(Rectangle2D player1, Rectangle2D player2)
    {
        Entity ball = new();
        // The ball is a white cube
        ball.AttachComponent(new Rectangle2D() { Width = 25, Height = 25, Color = Color.White });
        // The ball starts in the middle
        ball.AttachComponent(new Position2D { X = 320, Y = 240 });
        // The ball moves every tick
        ball.AttachComponent(new Ball(player1, player2));
        return ball;
    }
    private static Entity CreatePlayer2()
    {
        // The player has a score
        Entity player = new();
        player.AttachComponent(new DrawText2d() { PosX = 65, PosY = 50, FontSize = 50, Message = "Number0", Color = Color.White });
        player.AttachComponent(new ScoreComponent());
        // The player is a white rectangle
        player.AttachComponent(new Rectangle2D() { Width = 25, Height = 125, Color = Color.White, });
        // The player starts at the left
        player.AttachComponent(new Position2D { X = 25, Y = 50 });
        return player;
    }
    private static Entity CreatePlayer1()
    {
        Entity player = new();
        // The player has a score
        player.AttachComponent(new DrawText2d() { PosX = 550, PosY = 50, FontSize = 50, Message = "Number0", Color = Color.White });
        player.AttachComponent(new ScoreComponent());
        // The player is a white rectangle
        player.AttachComponent(new Rectangle2D() { Width = 25, Height = 125, Color = Color.White, });
        // The player starts at the right
        player.AttachComponent(new Position2D { X = 590, Y = 50 });
        // The player can be controlled
        player.AttachComponent(new Player1Controller());
        return player;
    }

}