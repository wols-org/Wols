using System.Numerics;

namespace Wols.Core.Geometry.Transform;

public interface ITranslator
{
    IMesh Translate(IMesh mesh, Vector3 changeVector);
}