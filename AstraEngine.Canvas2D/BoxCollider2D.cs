using System.Diagnostics.CodeAnalysis;

using AstraEngine.Canvas2D;
using AstraEngine.Core;

/// <summary> BoxCollider Class that has a component </summary>
public class BoxCollider2D : Component
{

    /// <summary> a box with a getter and a setter </summary>
    [AllowNull]
    public Rectangle2D Box { get; set; }

    /// <summary>given a box collider, returns true if the boxes are colliding</summary>
    public bool CheckCollisions(BoxCollider2D otherCollider)
    {
        double x1 = Box.Position.X;
        double y1 = Box.Position.Y;
        double x2 = otherCollider.Box.Position.X;
        double y2 = otherCollider.Box.Position.Y;

        double right1 = x1 + Box.Width;
        double bottom1 = y1 + Box.Height;

        double right2 = x2 + otherCollider.Box.Width;
        double bottom2 = y2 + otherCollider.Box.Height;

        bool overlapX = x1 < right2 && x2 < right1;
        bool overlapY = y1 < bottom2 && y2 < bottom1;

        return overlapX && overlapY;
    }

    /*
    public Position2D TopLeft {get; set;}
    public Position2D BottomRight {get; set;}
    private bool IsOverlap(Position2D OtherTopLeft, Position2D OtherBottomRight) {
        if(TopLeft.X == BottomRight.X || TopLeft.Y == BottomRight.Y || OtherTopLeft.X == OtherBottomRight.X || OtherTopLeft.Y == OtherBottomRight.Y){
            return false;
        }
        if(TopLeft.X > OtherBottomRight.X || OtherTopLeft.X > BottomRight.X){
            return false;
        }
        if(BottomRight.Y > OtherTopLeft.Y || OtherBottomRight.Y > TopLeft.Y){
            return false;
        }
        return true;
    }
    public bool IsColliding(BoxCollider2D other) {
        return IsOverlap(other.TopLeft, other.BottomRight);
    }
    */

    // public bool CheckCollision(Rectangle2D otherBox) {

    // }
}