using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace NameTags.Framework;

public class Config
{
    public KeybindList OpenSetting { get; set; } = new(SButton.N);
    public Color Color { get; set; } = Color.White;
    public Color BackgroundColor { get; set; } = Color.Black;
    public bool RenderMonster { get; set; } = true;
    public bool RenderPet { get; set; } = true;
    public bool RenderHorse { get; set; } = true;
    public bool RenderChild { get; set; } = true;
    public bool RenderVillager { get; set; } = true;
    public bool RenderJunimo { get; set; } = true;
    public bool TargetLine { get; set; } = false;
}