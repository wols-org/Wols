using Wols.Core.Geometry;

namespace Wols.Core.Tests.Geometry;

public class MeshTypeTests
{
    [Fact]
    public void MeshType_HasNaiveElementWithValueOne()
    {
        const string valueNaive = "Naive";
        const int valueNaiveIndex = 1;
        Type typeMeshType = typeof(MeshType);
        
        Assert.True(Enum.GetNames(typeMeshType).Contains(valueNaive));
        Assert.Equal(valueNaiveIndex, (int)Enum.Parse<MeshType>(valueNaive));
    }
}