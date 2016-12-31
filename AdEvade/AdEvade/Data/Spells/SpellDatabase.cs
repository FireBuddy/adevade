using System.Collections.Generic;
using AdEvade.Data.Spells;
using EloBuddy;
using SpellData = EloBuddy.SpellData;

namespace AdEvade.Data.Spells
{
public static class SpellDatabase
    {
        public static List<SpellData> Spells = new List<SpellData>();

        static SpellDatabase()
        {
            #region AllChampions

            Spells.Add(
            new SpellData
            {
                CharName = "AllChampions",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "SummonerSnowball",
                Name = "Poro Throw",
                ProjectileSpeed = 1300,
                Radius = 60,
                Range = 1600,
                SpellDelay = 0,
                SpellKey = SpellSlot.Q,
                SpellName = "summonersnowball",
                ExtraSpellNames = new[] { "summonerporothrow", },
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            #endregion AllChampions

            #region Aatrox

            Spells.Add(
            new SpellData
            {
                CharName = "Aatrox",
                Dangerlevel = SpellDangerLevel.High,
                Name = "AatroxQ",
                ProjectileSpeed = 450,
                Radius = 285,
                Range = 650,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "AatroxQ",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Aatrox",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "Blade of Torment",
                ProjectileSpeed = 1200,
                Radius = 100,
                Range = 1075,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "AatroxEConeMissile",
                SpellType = SpellType.Line,

            });
            #endregion Aatrox

            #region Ahri

            Spells.Add(
            new SpellData
            {
                CharName = "Ahri",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "AhriOrbMissile",
                Name = "Orb of Deception",
                ProjectileSpeed = 1750,
                Radius = 100,
                Range = 925,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "AhriOrbofDeception",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ahri",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "AhriSeduceMissile",
                Name = "Charm",
                ProjectileSpeed = 1550,
                Radius = 60,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "AhriSeduce",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ahri",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Orb of Deception Back",
                ProjectileSpeed = 915,
                Radius = 100,
                Range = 925,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "AhriOrbofDeception2",
                SpellType = SpellType.Line,

            });
            #endregion Ahri

            #region Alistar

            Spells.Add(
            new SpellData
            {
                CharName = "Alistar",
                DefaultOff = true,
                Dangerlevel = SpellDangerLevel.High,
                Name = "Pulverize",
                Radius = 365,
                Range = 365,
                SpellKey = SpellSlot.Q,
                SpellName = "Pulverize",
                SpellType = SpellType.Circular,

            });
            #endregion Alistar

            #region Amumu

            Spells.Add(
            new SpellData
            {
                CharName = "Amumu",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "CurseoftheSadMummy",
                Radius = 560,
                Range = 560,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "CurseoftheSadMummy",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Amumu",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "SadMummyBandageToss",
                Name = "Bandage Toss",
                ProjectileSpeed = 2000,
                Radius = 80,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "BandageToss",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Amumu
            
            #region AurelionSol

            Spells.Add(
            new SpellData
            {
                CharName = "AurelionSol",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "AurelionSolQMissile",
                Name = "AurelionSolQ",
                ProjectileSpeed = 850,
                Radius = 180,
                Range = 1500,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "AurelionSolQ",
                SpellType = SpellType.Line,
               

            });

            Spells.Add(
            new SpellData
            {
                CharName = "AurelionSol",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "AurelionSolRBeamMissile",
                Name = "AurelionSolR",
                ProjectileSpeed = 4600,
                Radius = 120,
                Range = 1420,
                SpellDelay = 300,
                SpellKey = SpellSlot.R,
                SpellName = "AurelionSolR",
                SpellType = SpellType.Line,
               
            });
            #endregion AurelionSol

            #region Anivia

            Spells.Add(
            new SpellData
            {
                CharName = "Anivia",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "FlashFrostSpell",
                Name = "Flash Frost",
                ProjectileSpeed = 850,
                Radius = 110,
                Range = 1250,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "FlashFrostSpell",
                SpellType = SpellType.Line,

            });
            #endregion Anivia

            #region Annie

            Spells.Add(
            new SpellData
            {
                Angle = 25,
                CharName = "Annie",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Incinerate",
                Radius = 80,
                Range = 625,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "Incinerate",
                SpellType = SpellType.Cone,
            });

            //Spells.Add(
            //new SpellData
            //{
            //    CharName = "Annie",
            //    Dangerlevel = SpellDangerLevel.Extreme,
            //    Name = "InfernalGuardian",
            //    Radius = 290,
            //    Range = 600,
            //    SpellDelay = 250,
            //    SpellKey = SpellSlot.R,
            //    SpellName = "InfernalGuardian",
            //    SpellType = SpellType.Circular,
            //});

            #endregion Annie

            #region Ashe

            Spells.Add(
            new SpellData
            {
                CharName = "Ashe",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Enchanted Arrow",
                ProjectileSpeed = 1600,
                Radius = 130,
                Range = 25000,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "EnchantedCrystalArrow",
                SpellType = SpellType.Line,
                //CollisionObjects = new[] { CollisionObjectType.EnemyChampions, },
            });

            Spells.Add(
            new SpellData
            {
                Angle = 5,
                CharName = "Ashe",
                Dangerlevel = SpellDangerLevel.Normal,
                //MissileName = "VolleyAttack",
                Name = "Volley",
                ProjectileSpeed = 1500,
                Radius = 20,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "Volley",
                SpellType = SpellType.Line,
                IsSpecial = true,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
            });
            #endregion Ashe

            #region Azir

            Spells.Add(
            new SpellData
            {
                CharName = "Azir",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "AzirSoldierMissile",
                Name = "AzirQ",
                ProjectileSpeed = 1000,
                Radius = 200,
                Range = 850,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "AzirQWrapper",
                SpellType = SpellType.Line,



            });
            #endregion Azir

            #region Bard

            Spells.Add(
            new SpellData
            {
                CharName = "Bard",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "BardQ",
                MissileName = "BardQMissile",
                ProjectileSpeed = 1600,
                Radius = 60,
                Range = 950,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "BardQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Bard",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "BardR",
                MissileName = "BardR",
                ProjectileSpeed = 2100,
                Radius = 350,
                Range = 3400,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "BardR",
                SpellType = SpellType.Circular,
            });

            #endregion Bard

            #region Blitzcrank

            Spells.Add(
            new SpellData
            {
                CharName = "Blitzcrank",
                Dangerlevel = SpellDangerLevel.High,
                ExtraDelay = 75,
                MissileName = "RocketGrabMissile",
                Name = "Rocket Grab",
                ProjectileSpeed = 1800,
                Radius = 70,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "RocketGrab",
                ExtraSpellNames = new [] { "RocketGrabMissile" },
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Blitzcrank

            #region Brand

            Spells.Add(
            new SpellData
            {
                CharName = "Brand",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "BrandBlazeMissile",
                Name = "BrandBlaze",
                ProjectileSpeed = 2000, //1600
                Radius = 60,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "BrandQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },              
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Brand",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Pillar of Flame",
                Radius = 250,
                Range = 1100,
                SpellDelay = 850,
                SpellKey = SpellSlot.W,
                SpellName = "BrandW",
                SpellType = SpellType.Circular,

            });
            #endregion Brand

            #region Braum

            Spells.Add(
            new SpellData
            {
                CharName = "Braum",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "GlacialFissure",
                ProjectileSpeed = 1125,
                Radius = 100,
                Range = 1250,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "BraumRWrapper",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Braum",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "BraumQMissile",
                Name = "BraumQ",
                ProjectileSpeed = 1200,
                SpellDelay = 250,   
                Radius = 100,
                Range = 1000,             
                SpellKey = SpellSlot.Q,
                SpellName = "BraumQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Braum

            #region Caitlyn

            Spells.Add(
            new SpellData
            {
                CharName = "Caitlyn",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Piltover Peacemaker",
                ProjectileSpeed = 2200,
                Radius = 90,
                Range = 1300,
                SpellDelay = 625,
                SpellKey = SpellSlot.Q,
                SpellName = "CaitlynPiltoverPeacemaker",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Caitlyn",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "CaitlynEntrapmentMissile",
                Name = "Caitlyn Entrapment",
                ProjectileSpeed = 2000,
                Radius = 80,
                Range = 950,
                SpellDelay = 125,
                SpellKey = SpellSlot.E,
                SpellName = "CaitlynEntrapment",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Caitlyn

            #region Cassiopeia

            Spells.Add(
            new SpellData
            {
                Angle = 40,
                CharName = "Cassiopeia",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "CassiopeiaPetrifyingGaze",
                Radius = 145,
                Range = 825,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "CassiopeiaR",
                SpellType = SpellType.Cone,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Cassiopeia",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "CassiopeiaNoxiousBlast",
                Radius = 200,
                Range = 850,
                SpellDelay = 750,
                SpellKey = SpellSlot.Q,
                SpellName = "CassiopeiaQ",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Cassiopeia",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "CassiopeiaMiasma",
                Radius = 220,
                Range = 850,
                SpellDelay = 250,
                ProjectileSpeed = 2500,
                SpellKey = SpellSlot.W,
                SpellName = "CassiopeiaMiasma",
                SpellType = SpellType.Circular,

            });
            #endregion Cassiopeia

            
            

            

            
            
   
            
            

           

            
        }
    }}
o
