using System.Numerics;
using Wols.Core.Geometry.Generator;

namespace Wols.Core.Geometry.Naive.Generator;

public class NaivePlaneGenerator : IPlaneGenerator
{
    public IMesh Generate(float a = 1.0f)
    {
        float x = a / 2.0f;
        
        IReadOnlyList<Vector3> vertices =
        [
            new(-x, 0, -x), // 0
            new( x, 0, -x), // 1
            new( x, 0,  x), // 2
            new(-x, 0,  x), // 3
        ];

        IReadOnlyList<Triangle> triangles =
        [
            new(0, 1, 2),
            new(2, 3, 0),
        ];
        
        var mesh = new NaiveMesh(vertices, triangles);
        return mesh;
    }
}