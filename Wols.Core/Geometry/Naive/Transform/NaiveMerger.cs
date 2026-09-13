using System.Numerics;
using Wols.Core.Geometry.Transform;

namespace Wols.Core.Geometry.Naive.Transform;

public class NaiveMerger : IMerger
{
    public IMesh Merge(IEnumerable<IMesh> meshes)
    {
        Vector3 centerSum = new Vector3(0);
        List<Vector3> newVertices = [];
        List<Triangle> newTriangles = [];
        
        IEnumerable<NaiveMesh> naiveMeshes = meshes.Select(NaiveMesh.Adapt);

        int count = 0;
        foreach (var naiveMesh in naiveMeshes)
        {
            int offset = newVertices.Count;
            var triangles = naiveMesh.Triangles.Select(t => OffsetTriangle(t, offset));
            newTriangles.AddRange(triangles);
            
            newVertices.AddRange(naiveMesh.Vertices);

            centerSum += naiveMesh.Center;
            count++;
        }

        return new NaiveMesh(newVertices, newTriangles, centerSum / count);
    }


    private Triangle OffsetTriangle(Triangle triangle, int offset)
    {
        return new Triangle(triangle.A + offset, triangle.B + offset, triangle.C + offset);
    }
}