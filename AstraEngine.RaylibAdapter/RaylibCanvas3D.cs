using Raylib_cs;

namespace AstraEngine.Canvas3D;

/// <summary>
/// An implementation of the <see cref="ICanvas3D"/> that is compatible with Raylib-cs.
/// </summary>
public sealed class RaylibCanvas3D : ICanvas3D
{
    /// <inheritdoc/>
    public void BeginDrawing() => Raylib.BeginDrawing();
    /// <inheritdoc/>

    /// <inheritdoc/>
    public void EndDrawing() => Raylib.EndDrawing();
}