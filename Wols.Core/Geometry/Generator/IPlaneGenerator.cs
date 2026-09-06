namespace Wols.Core.Geometry.Generator;

public interface IPlaneGenerator
{
    public IMesh Generate(float a = 1.0f);
}