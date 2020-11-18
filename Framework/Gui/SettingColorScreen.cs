using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using EnaiumToolKit.Framework.Utils;

namespace NameTags.Framework.Gui
{
    public class SettingColorScreen : ScreenGui
    {
        public SettingColorScreen()
        {
            foreach (var variable in ColorUtils.Instance.Colors)
            {
                AddElement(new ColorButton($"{Get("nameTags.button.nameTagColor")}:{variable.Name}",
                    Get("nameTags.button.nameTagColor.description"))
                {
                    Color = ColorUtils.Instance.Get(variable.Name),
                    OnLeftClicked = () =>
                    {
                        ModEntry.Config.TextColor = variable.Name;
                        ModEntry.ConfigReload();
                    }
                });
            }
        }

        public string Get(string key)
        {
            return ModEntry.GetInstance().Helper.Translation.Get(key);
        }
    }
}