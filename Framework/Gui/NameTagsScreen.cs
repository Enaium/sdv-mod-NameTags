using System.Linq;
using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using StardewModdingAPI;
using StardewValley;
using StardewValley.Characters;
using StardewValley.Monsters;

namespace NameTags.Framework.Gui
{
    public class NameTagsScreen : ScreenGui
    {
        private Config _config;

        public NameTagsScreen()
        {
            _config = ModEntry.GetInstance().Helper.ReadConfig<Config>();
            ToggleButton renderMonster = new ToggleButton(Get("nameTags.toggle.renderMonster"),
                Get("nameTags.toggle.renderMonster.description"), _config.RenderMonster);
            renderMonster.OnLeftClicked = () =>
            {
                _config.RenderMonster = renderMonster.GetToggled();
                Reload();
            };

            ToggleButton renderPet = new ToggleButton(Get("nameTags.toggle.renderPet"),
                Get("nameTags.toggle.renderPet.description"), _config.RenderPet);
            renderPet.OnLeftClicked = () =>
            {
                _config.RenderPet = renderPet.GetToggled();
                Reload();
            };

            ToggleButton renderChild = new ToggleButton(Get("nameTags.toggle.renderChild"),
                Get("nameTags.toggle.renderChild.description"), _config.RenderChild);
            renderChild.OnLeftClicked = () =>
            {
                _config.RenderChild = renderChild.GetToggled();
                Reload();
            };

            ToggleButton renderVillager = new ToggleButton(Get("nameTags.toggle.renderVillager"),
                Get("nameTags.toggle.renderVillager.description"), _config.RenderVillager);
            renderVillager.OnLeftClicked = () =>
            {
                _config.RenderVillager = renderVillager.GetToggled();
                Reload();
            };
            AddElementRange(renderMonster, renderPet, renderChild, renderVillager);
        }

        public void Reload()
        {
            ModEntry.GetInstance().Helper.WriteConfig(_config);
            ModEntry.Config = ModEntry.GetInstance().Helper.ReadConfig<Config>();
        }

        public string Get(string key)
        {
            return ModEntry.GetInstance().Helper.Translation.Get(key);
        }
    }
}