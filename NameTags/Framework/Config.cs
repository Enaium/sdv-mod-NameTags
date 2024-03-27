using EnaiumToolKit.Framework.Utils;
using StardewModdingAPI;

namespace NameTags.Framework;

public class Config
{
    public SButton OpenSetting { get; set; } = SButton.N;
    public ColorUtils.NameType TextColor = ColorUtils.NameType.White;
    public bool RenderMonster { get; set; } = true;
    public bool RenderPet { get; set; } = true;
    public bool RenderHorse { get; set; } = true;
    public bool RenderChild { get; set; } = true;
    public bool RenderVillager { get; set; } = true;
    public bool RenderJunimo { get; set; } = true;
}