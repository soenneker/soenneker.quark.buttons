using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Buttons.Tests;

[Collection("Collection")]
public sealed class ButtonTests : FixturedUnitTest
{
    private readonly Button _button;

    public ButtonTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _button = Resolve<Button>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
