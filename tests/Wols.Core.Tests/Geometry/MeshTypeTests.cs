using Wols.Core.Geometry;

namespace Wols.Core.Tests.Geometry;

public class MeshTypeTests
{
    [Fact]
    public void MeshType_HasNaiveElementWithValueOne()
    {
        const string valueNaive = "Naive";
        const int valueNaiveIndex = 1;
        
        Assert.True(Enum.GetNames<MeshType>().Contains(valueNaive));
        Assert.Equal(valueNaiveIndex, (int)Enum.Parse<MeshType>(valueNaive));
    }
}