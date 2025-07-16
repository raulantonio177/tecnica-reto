using WeightedUniformStrings.Core;
using Xunit;

namespace WeightedUniformStrings.Tests;

public class WeightedUniformStringsUT
{
    private readonly WeightedUniformStringSolver _solver = new();

    [Fact]
    public void Test_Ejemplo_Oficial()
    {
        var s = "abbcccdddd";
        var queries = new List<int> { 1, 7, 5, 4, 15 };
        var expected = new List<string> { "Yes", "No", "No", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_TodoUnCaracter()
    {
        var s = "aaaaa";
        var queries = new List<int> { 1, 2, 3, 4, 5, 6 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_CaracteresAlternados()
    {
        var s = "ababab";
        var queries = new List<int> { 1, 2, 3 };
        var expected = new List<string> { "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_CadenaVacia()
    {
        var s = "";
        var queries = new List<int> { 1, 2 };
        var expected = new List<string> { "No", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaVacia()
    {
        var s = "abc";
        var queries = new List<int>();
        var expected = new List<string>();
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ValoresGrandes()
    {
        var s = "zzzz";
        var queries = new List<int> { 26, 52, 78, 104, 130 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_SubcadenasDeLongitudUno()
    {
        var s = "abcde";
        var queries = new List<int> { 1, 2, 3, 4, 5, 6 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaNoExistente()
    {
        var s = "aabbcc";
        var queries = new List<int> { 10, 12 };
        var expected = new List<string> { "No", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaLimiteInferior()
    {
        var s = "a";
        var queries = new List<int> { 1, 0 };
        var expected = new List<string> { "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaLimiteSuperior()
    {
        var s = new string('z', 100);
        var queries = new List<int> { 2600, 26, 52, 78, 104 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "Yes" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }
    [Fact]
    public void Test_TodosLosCaracteres()
    {
        var s = "abcdefghijklmnopqrstuvwxyz";
        var queries = new List<int> { 1, 13, 26, 27 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaRepetida()
    {
        var s = "bbb";
        var queries = new List<int> { 2, 4, 6, 2, 4 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "Yes" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaNegativa()
    {
        var s = "ccc";
        var queries = new List<int> { -3, 0, 3 };
        var expected = new List<string> { "No", "No", "Yes" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }

    [Fact]
    public void Test_ConsultaConValoresGrandesYPequeños()
    {
        var s = "mmmmm";
        var queries = new List<int> { 13, 26, 39, 52, 65, 1 };
        var expected = new List<string> { "Yes", "Yes", "Yes", "Yes", "Yes", "No" };
        Assert.Equal(expected, _solver.WeightedUniformStrings(s, queries));
    }
}