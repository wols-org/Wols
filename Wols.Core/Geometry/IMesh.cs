using System.Numerics;

namespace Wols.Core.Geometry;

public interface IMesh
{
    IReadOnlyList<Vector3> Vertices { get; }
    IReadOnlyList<Triangle> Triangles { get; }
    MeshType MeshType { get; }
}