using FuncApp;

namespace Tests;

public class TestSumOfTwoMins
{
    [Fact]
    public void SumOfTwoMins_InputIsEmptyArr_Return0()
    {
        int ans = Utils.SumOfTwoMins([]);

        Assert.Equal(0, ans);
    }

    [Fact]
    public void SumOfTwoMins_InputIsSingleElement_ReturnElement()
    {
        int ans = Utils.SumOfTwoMins([3]);

        Assert.Equal(3, ans);
    }

    [Fact]
    public void SumOfTwoMins_InputWithMinDuplicates_ReturnSumOfDuplicates()
    {
        int ans = Utils.SumOfTwoMins([-2, -2, 0, 10]);

        Assert.Equal(-4, ans);
    }

    [Fact]
    public void SumOfTwoMins_NormalInput_ReturnSum()
    {
        int ans = Utils.SumOfTwoMins([4, 0, 3, 19, 492, -10, 1]);

        Assert.Equal(-10, ans);
    }
}