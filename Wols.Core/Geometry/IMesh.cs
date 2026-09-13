using System.Numerics;

namespace Wols.Core.Geometry;

public interface IMesh
{
    MeshType MeshType { get; }
    
    IReadOnlyList<Vector3> Vertices { get; }
    IReadOnlyList<Triangle> Triangles { get; }
    Vector3 Center { get; }
}