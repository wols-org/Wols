namespace Wols.Core.Geometry.Transform;

public interface IMerger
{
    IMesh Merge(IEnumerable<IMesh> meshes);
}