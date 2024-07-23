using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Content.Shared.UndecidedLoadout;
using Robust.Client.GameObjects;

namespace Content.Client.UndecidedLoadout;

[GenerateTypedNameReferences]
public sealed partial class UndecidedLoadoutBackpackSet : Control
{
    public UndecidedLoadoutBackpackSet(UndecidedLoadoutBackpackSetInfo set, SpriteSystem spriteSystem)
    {
        RobustXamlLoader.Load(this);

        Icon.Texture = spriteSystem.Frame0(set.Sprite);
        SetName.Text = Loc.GetString(set.Name);
        SetDescription.Text = Loc.GetString(set.Description);
        SetButton.Text = Loc.GetString(set.Selected ? "undecided-loadout-button-deselect" : "undecided-loadout-button-select");
        SetButton.ModulateSelfOverride = set.Selected ? new Color(40, 84, 35) : new Color(68, 75, 103);
    }
}