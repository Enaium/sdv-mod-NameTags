using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewValley;

namespace NameTags.Framework
{
    public class Config
    {
        public SButton OpenSetting { get; set; } = SButton.N;
        public bool RenderMonster = true;
        public bool RenderPet = true;
        public bool RenderChild = true;
        public bool RenderVillager = true;
    }
}