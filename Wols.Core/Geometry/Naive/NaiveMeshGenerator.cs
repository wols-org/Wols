using System.Numerics;

namespace Wols.Core.Geometry.Naive;

public static class NaiveMeshGenerator
{
    public static IMesh CreateCube(float a = 1.0f)
    {
        float x = a / 2.0f;
        
        IReadOnlyList<Vector3> vertices =
        [
            new(-x, -x, -x), // 0
            new( x, -x, -x), // 1
            new( x, -x,  x), // 2
            new(-x, -x,  x), // 3
            new(-x,  x, -x), // 4
            new( x,  x, -x), // 5
            new( x,  x,  x), // 6
            new(-x,  x,  x), // 7
        ];

        IReadOnlyList<Triangle> triangles =
        [
            //bottom
            new(0, 1, 2),
            new(2, 3, 0),
            
            //top
            new(4, 7, 6),
            new(6, 5, 4),
            
            //front
            new(7, 3, 2),
            new(2, 6, 7),
            
            //back
            new(4, 5, 1),
            new(1, 0, 4),
            
            //left
            new(7, 4, 0),
            new(0, 3, 7),
            
            //right
            new(6, 2, 1),
            new(1, 5, 6),
        ];
        
        var mesh = new NaiveMesh(vertices, triangles);
        return mesh;
    }
}