using System.Numerics;

namespace Wols.Core.Geometry.Naive;

public class NaiveMesh : IMesh
{
    public MeshType MeshType => MeshType.Naive;
    
    public IReadOnlyList<Vector3> Vertices => _vertices;
    public IReadOnlyList<Triangle> Triangles => _triangles;
    public Vector3 Center => _center;

    private List<Vector3> _vertices;
    private List<Triangle> _triangles;
    private Vector3 _center;
    
    public NaiveMesh(IReadOnlyList<Vector3> vertices, IReadOnlyList<Triangle> triangles, Vector3? center = null)
    {
        _vertices = vertices.ToList();
        _triangles = triangles.ToList();

        _center = center ?? new Vector3(0, 0, 0);
    }

    public static NaiveMesh Adapt(IMesh mesh)
    {
        if (mesh.MeshType == MeshType.Naive)
        {
            return (NaiveMesh)mesh;
        }

        return new NaiveMesh(mesh.Vertices, mesh.Triangles, mesh.Center);
    }

    #region Modifiers

    public void MoveVertex(int idx, Vector3 newPosition)
    {
        _vertices[idx] = newPosition;
    }

    #endregion
}