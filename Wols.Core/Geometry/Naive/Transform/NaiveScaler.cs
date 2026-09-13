using System.Numerics;
using Wols.Core.Geometry.Transform;

namespace Wols.Core.Geometry.Naive.Transform;

public class NaiveScaler : IScaler
{
    public IMesh Scale(IMesh mesh, float scaleFactor)
    {
        var scaleFactorsVector = new Vector3(scaleFactor);
        return Scale(mesh, scaleFactorsVector);
    }
    
    public IMesh Scale(IMesh mesh, Vector3 scaleFactorVector)
    {
        NaiveMesh naiveMesh = NaiveMesh.Adapt(mesh);

        for (int idx = 0; idx < naiveMesh.Vertices.Count; idx++)
        {
            Vector3 vertex = naiveMesh.Vertices[idx];
            Vector3 scaledVertex = ScaleVertexFromCenter(vertex, naiveMesh.Center, scaleFactorVector);
            naiveMesh.MoveVertex(idx, scaledVertex);
        }

        return naiveMesh;
    }

    private Vector3 ScaleVertexFromCenter(Vector3 vertex, Vector3 center, Vector3 scaleFactorVector)
    {
        Vector3 vertexOffsetFromCenter = vertex - center;
        Vector3 scaledVertexOffsetFromCenter = vertexOffsetFromCenter * scaleFactorVector;
        Vector3 scaledVertex = scaledVertexOffsetFromCenter + center;
        return scaledVertex;
    }
}