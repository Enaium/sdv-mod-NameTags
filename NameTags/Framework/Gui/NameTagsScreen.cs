﻿using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using StardewValley;

namespace NameTags.Framework.Gui;

public class NameTagsScreen : ScreenGui
{
    public NameTagsScreen()
    {
        var renderMonster = new ToggleButton(Get("nameTags.toggle.renderMonster"),
            Get("nameTags.toggle.renderMonster.description"))
        {
            Toggled = ModEntry.Config.RenderMonster
        };
        renderMonster.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderMonster = renderMonster.Toggled;
            ModEntry.ConfigReload();
        };

        var renderPet = new ToggleButton(Get("nameTags.toggle.renderPet"),
            Get("nameTags.toggle.renderPet.description"))
        {
            Toggled = ModEntry.Config.RenderPet
        };
        renderPet.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderPet = renderPet.Toggled;
            ModEntry.ConfigReload();
        };

        var renderHorse = new ToggleButton(Get("nameTags.toggle.renderHorse"),
            Get("nameTags.toggle.renderHorse.description"))
        {
            Toggled = ModEntry.Config.RenderHorse
        };
        renderHorse.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderHorse = renderHorse.Toggled;
            ModEntry.ConfigReload();
        };

        var renderChild = new ToggleButton(Get("nameTags.toggle.renderChild"),
            Get("nameTags.toggle.renderChild.description"))
        {
            Toggled = ModEntry.Config.RenderChild
        };
        renderChild.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderChild = renderChild.Toggled;
            ModEntry.ConfigReload();
        };

        var renderVillager = new ToggleButton(Get("nameTags.toggle.renderVillager"),
            Get("nameTags.toggle.renderVillager.description"))
        {
            Toggled = ModEntry.Config.RenderVillager
        };
        renderVillager.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderVillager = renderVillager.Toggled;
            ModEntry.ConfigReload();
        };

        var renderJunimo = new ToggleButton(Get("nameTags.toggle.renderJunimo"),
            Get("nameTags.toggle.renderJunimo.description"))
        {
            Toggled = ModEntry.Config.RenderJunimo
        };
        renderJunimo.OnLeftClicked = () =>
        {
            ModEntry.Config.RenderJunimo = renderJunimo.Toggled;
            ModEntry.ConfigReload();
        };
        AddElementRange(renderMonster, renderPet, renderHorse, renderChild, renderVillager, renderJunimo,
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