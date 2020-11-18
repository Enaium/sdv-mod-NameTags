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
        public NameTagsScreen()
        {
            ToggleButton renderMonster = new ToggleButton(Get("nameTags.toggle.renderMonster"),
                Get("nameTags.toggle.renderMonster.description"))
            {
                Toggled = ModEntry.Config.RenderMonster
            };
            renderMonster.OnLeftClicked = () =>
            {
                ModEntry.Config.RenderMonster = renderMonster.Toggled;
                ModEntry.ConfigReload();
            };

            ToggleButton renderPet = new ToggleButton(Get("nameTags.toggle.renderPet"),
                Get("nameTags.toggle.renderPet.description"))
            {
                Toggled = ModEntry.Config.RenderPet
            };
            renderPet.OnLeftClicked = () =>
            {
                ModEntry.Config.RenderPet = renderPet.Toggled;
                ModEntry.ConfigReload();
            };

            ToggleButton renderChild = new ToggleButton(Get("nameTags.toggle.renderChild"),
                Get("nameTags.toggle.renderChild.description"))
            {
                Toggled = ModEntry.Config.RenderChild
            };
            renderChild.OnLeftClicked = () =>
            {
                ModEntry.Config.RenderChild = renderChild.Toggled;
                ModEntry.ConfigReload();
            };

            ToggleButton renderVillager = new ToggleButton(Get("nameTags.toggle.renderVillager"),
                Get("nameTags.toggle.renderVillager.description"))
            {
                Toggled = ModEntry.Config.RenderVillager
            };
            renderVillager.OnLeftClicked = () =>
            {
                ModEntry.Config.RenderVillager = renderVillager.Toggled;
                ModEntry.ConfigReload();
            };
            AddElementRange(renderMonster, renderPet, renderChild, renderVillager,
                new Button(Get("nameTags.button.nameTagColor"), Get("nameTags.button.nameTagColor.description"))
                {
                    OnLeftClicked = () => { Game1.activeClickableMenu = new SettingColorScreen(); }
                });
        }

        public string Get(string key)
        {
            return ModEntry.GetInstance().Helper.Translation.Get(key);
        }
    }
}