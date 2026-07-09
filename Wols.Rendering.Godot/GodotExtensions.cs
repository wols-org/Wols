using Godot;
using Wols.Core.Geometry;
using Array = Godot.Collections.Array;

namespace Wols.Rendering.Godot;

public static class GodotExtensions
{
    public static ArrayMesh ToGodotMesh(this IMesh mesh)
    {
        var vertices = new Vector3[mesh.Vertices.Count];

        for (int i = 0; i < mesh.Vertices.Count; i++)
        {
            var v = mesh.Vertices[i];
            vertices[i] = new Vector3(v.X, v.Y, v.Z);
        }

        var indices = new int[mesh.Triangles.Count * 3];

        for (int i = 0; i < mesh.Triangles.Count; i++)
        {
            var triangle = mesh.Triangles[i];

            // If your mesh uses CCW winding and you want Godot's default CW front face,
            // swap B and C here.
            indices[i * 3 + 0] = triangle.A;
            indices[i * 3 + 1] = triangle.C;
            indices[i * 3 + 2] = triangle.B;

            // If your mesh already uses CW winding, use:
            //
            // indices[i * 3 + 0] = triangle.A;
            // indices[i * 3 + 1] = triangle.B;
            // indices[i * 3 + 2] = triangle.C;
        }

        var arrays = new Array();
        arrays.Resize((int)Mesh.ArrayType.Max);

        arrays[(int)Mesh.ArrayType.Vertex] = vertices;
        arrays[(int)Mesh.ArrayType.Index] = indices;

        var result = new ArrayMesh();
        result.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrays);

        return result;
    }
}