using Intellenum;

namespace Soenneker.Quark.Buttons.Enums;

/// <summary>
/// Button type enumeration.
/// </summary>
[Intellenum<string>]
public sealed partial class ButtonType
{
    public static readonly ButtonType Button = new("button");

    public static readonly ButtonType Submit = new("submit");

    public static readonly ButtonType Reset = new("reset");

    public static readonly ButtonType Link = new("link");
}
