using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using Wols.Core.Geometry.Transform;

namespace Wols.Core.Geometry.Naive.Transform;

public class NaiveTranslator : ITranslator
{
    public IMesh Translate(IMesh mesh, Vector3 changeVector)
    {
        NaiveMesh naiveMesh = NaiveMesh.Adapt(mesh);

        Vector3 translatedCenter = naiveMesh.Center + changeVector; 
        naiveMesh.MoveCenterTo(translatedCenter);

        for (int idx = 0; idx < naiveMesh.Vertices.Count; idx++)
        {
            Vector3 vertex = naiveMesh.Vertices[idx];
            Vector3 translatedVertex = vertex + changeVector;
            naiveMesh.MoveVertexTo(idx, translatedVertex);
        }

        return naiveMesh;
    }
}