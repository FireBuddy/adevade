﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EzEvade.Data;

namespace EzEvade.Config
{
    public class SpellConfigControl
    {

        public static readonly string[] DangerLevels = { "Low", "Normal", "High", "Extreme" };


        public DynamicCheckBox DodgeCheckBox;
        public DynamicCheckBox DrawCheckBox;
        public DynamicSlider SpellRadiusSlider;
        public StringSlider DangerLevelSlider;
        private readonly Menu _menu;
        private readonly SpellData _spell;
        public SpellConfigControl(Menu menu, string label, SpellData spell, bool enableSpell)
        {
            _menu = menu;
            _spell = spell;
            _menu.AddGroupLabel(label);

            DodgeCheckBox = new DynamicCheckBox(ConfigDataType.Spells, spell.SpellName, "Dodge", enableSpell, true, SpellConfigProperty.Dodge);
            DrawCheckBox = new DynamicCheckBox(ConfigDataType.Spells, spell.SpellName, "Draw", enableSpell, true, SpellConfigProperty.Draw);
            SpellRadiusSlider = new DynamicSlider(ConfigDataType.Spells, spell.SpellName, "Radius", (int)spell.Radius, (int)spell.Radius - 100, (int)spell.Radius + 100, true, SpellConfigProperty.Radius);
            DangerLevelSlider = new StringSlider(ConfigDataType.Spells, spell.SpellName, "Danger Level", spell.Dangerlevel - 1,SpellConfigProperty.DangerLevel, DangerLevels);
        }

        public void AddToMenu()
        {
            _menu.Add(_spell.SpellName + "_Dodge", DodgeCheckBox.CheckBox);
            _menu.Add(_spell.SpellName + "_Draw", DrawCheckBox.CheckBox);
            _menu.Add(_spell.SpellName + "_Raduis", SpellRadiusSlider.Slider);
            _menu.Add(_spell.SpellName + "_DangerLevel", DangerLevelSlider.Slider.Slider);
        }
    }
}