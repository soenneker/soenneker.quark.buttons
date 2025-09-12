using Intellenum;

namespace Soenneker.Quark.Buttons;

/// <summary>
/// Button type enumeration.
/// </summary>
[Intellenum<string>]
public partial class ButtonType
{
    public static readonly ButtonType Button = new("button");
    public static readonly ButtonType Submit = new("submit");
    public static readonly ButtonType Reset = new("reset");
    public static readonly ButtonType Link = new("link");
}
