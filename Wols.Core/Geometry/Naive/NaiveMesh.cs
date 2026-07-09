using System.Numerics;

namespace Wols.Core.Geometry.Naive;

public class NaiveMesh : IMesh
{
    public NaiveMesh(IReadOnlyList<Vector3> vertices, IReadOnlyList<Triangle> triangles)
    {
        Vertices = vertices;
        Triangles = triangles;
    }

    public IReadOnlyList<Vector3> Vertices { get; }
    public IReadOnlyList<Triangle> Triangles { get; }
}