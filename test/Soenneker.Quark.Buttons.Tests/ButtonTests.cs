using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Buttons.Tests;

[Collection("Collection")]
public sealed class ButtonTests : FixturedUnitTest
{
    public ButtonTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
