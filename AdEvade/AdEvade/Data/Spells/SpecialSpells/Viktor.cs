using System;
using EloBuddy;
using EloBuddy.SDK;

namespace AdEvade.Data.Spells.SpecialSpells
{
    class Viktor : IChampionPlugin
    {
        static Viktor()
        {

        }
        public const string ChampionName = "Viktor";
        public string GetChampionName()
        {
            return ChampionName;
        }
        public void LoadSpecialSpell(SpellData spellData)
        {
            if (spellData.SpellName == "ViktorDeathRay")
            {
                 Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast3;
            }
        }

        private static void Obj_AI_Base_OnProcessSpellCast3(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {

  

            if (sender != null && sender.Team != ObjectManager.Player.Team &&
                args.SData.Name != null && args.SData.Name == "ViktorDeathRay")
            
            {
               . var End = new vector3 => enemy.GetWaypoints().Last();
            //    var missileDist = End.To2D().Distance(args.Start.To2D());
              //  var delay = missileDist / 1.5f + 600;
        
             //   spellData.SpellDelay = delay;

             //   SpellDetector.CreateSpellData(sender, args.Start, End, spellData);
            }
        }
    }
}
