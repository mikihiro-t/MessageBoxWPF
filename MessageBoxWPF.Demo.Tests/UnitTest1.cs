using CommunityToolkit.Mvvm.DependencyInjection;
using MessageBoxWPF.Demo.Service;
using Microsoft.Extensions.DependencyInjection;

namespace MessageBoxWPF.Demo.Tests;

public class UnitTestFixture
{
    public UnitTestFixture()
    {
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
            .AddTransient<IDialogService, TestDialogService>()
            .BuildServiceProvider());
    }
}

public class UnitTest1 : IClassFixture<UnitTestFixture>
{
    private readonly UnitTestFixture fixture;

    public UnitTest1(UnitTestFixture fixture)
    {
        //https://xunit.net/xunit.analyzers/rules/xUnit1033
        this.fixture = fixture;
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 3, 5)]
    public void CaluculateTest(int a, int b, double expected)
    {
        var cls = new CaluculateModel("");
        var actual = cls.Add(a, b);

        Assert.Equal(expected, actual);
    }
}