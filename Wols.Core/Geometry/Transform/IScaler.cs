using System.Numerics;

namespace Wols.Core.Geometry.Transform;

public interface IScaler
{
    IMesh Scale(IMesh mesh, float scaleFactor);
    IMesh Scale(IMesh mesh, Vector3 scaleFactorVector);
}