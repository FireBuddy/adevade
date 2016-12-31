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

            #region Chogath

            Spells.Add(
            new SpellData
            {
                Angle = 30,
                CharName = "Chogath",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "FeralScream",
                Radius = 20,
                Range = 650,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "FeralScream",
                SpellType = SpellType.Cone,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Chogath",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Rupture",
                Radius = 250,
                Range = 950,
                SpellDelay = 1200,
                SpellKey = SpellSlot.Q,
                SpellName = "Rupture",
                SpellType = SpellType.Circular,
                ExtraDrawHeight = 45,
            });
            #endregion Chogath

            #region Corki

            Spells.Add(
            new SpellData
            {
                CharName = "Corki",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "MissileBarrageMissile2",
                Name = "Missile Barrage big",
                ProjectileSpeed = 2000,
                Radius = 40,
                Range = 1500,
                SpellDelay = 175,
                SpellKey = SpellSlot.R,
                SpellName = "MissileBarrage2",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Corki",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "PhosphorusBombMissile",
                Name = "Phosphorus Bomb",
                ProjectileSpeed = 1125,
                Radius = 270,
                Range = 825,
                SpellDelay = 500,
                SpellKey = SpellSlot.Q,
                SpellName = "PhosphorusBomb",
                SpellType = SpellType.Circular,
                ExtraDrawHeight = 110,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Corki",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "MissileBarrageMissile",
                Name = "Missile Barrage",
                ProjectileSpeed = 2000,
                Radius = 40,
                Range = 1300,
                SpellDelay = 175,
                SpellKey = SpellSlot.R,
                SpellName = "MissileBarrage",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Corki

            #region Darius

            Spells.Add(
            new SpellData
            {
                Angle = 25,
                CharName = "Darius",
                Dangerlevel = SpellDangerLevel.High,
                Name = "DariusAxeGrabCone",
                Radius = 20,
                Range = 570,
                SpellDelay = 320,
                SpellKey = SpellSlot.E,
                SpellName = "DariusAxeGrabCone",
                SpellType = SpellType.Cone,

            });
            #endregion Darius

            #region Diana

            Spells.Add(
            new SpellData
            {
                CharName = "Diana",
                Dangerlevel = SpellDangerLevel.High,
                Name = "DianaArc",
                ProjectileSpeed = 1400,
                Radius = 50,
                Range = 850,
                FixedRange = true,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "DianaArc",
                SpellType = SpellType.Arc,
                HasEndExplosion = true,
                SecondaryRadius = 195,
                ExtraEndTime = 250,
            });
            #endregion Diana

            #region DrMundo

            Spells.Add(
            new SpellData
            {
                CharName = "DrMundo",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "InfectedCleaverMissile",
                Name = "Infected Cleaver",
                ProjectileSpeed = 2000,
                Radius = 60,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "InfectedCleaverMissileCast",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion DrMundo

            #region Draven

            Spells.Add(
            new SpellData
            {
                CharName = "Draven",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "DravenR",
                Name = "DravenR",
                ProjectileSpeed = 2000,
                Radius = 160,
                Range = 25000,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "DravenRCast",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Draven",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "DravenDoubleShotMissile",
                Name = "Stand Aside",
                ProjectileSpeed = 1400,
                Radius = 130,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "DravenDoubleShot",
                SpellType = SpellType.Line,

            });
            #endregion Draven

            #region Ekko

            Spells.Add(
            new SpellData
            {
                CharName = "Ekko",
                Dangerlevel = SpellDangerLevel.High,
                Name = "EkkoQ",
                MissileName = "EkkoQMis",
                ProjectileSpeed = 1650,
                Radius = 60,
                Range = 950,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "EkkoQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions },
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ekko",
                Dangerlevel = SpellDangerLevel.High,
                Name = "EkkoW",
                Radius = 375,
                Range = 1600,
                SpellDelay = 3750,
                SpellKey = SpellSlot.W,
                SpellName = "EkkoW",
                SpellType = SpellType.Circular,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ekko",
                Dangerlevel = SpellDangerLevel.High,
                Name = "EkkoR",
                Radius = 375,
                Range = 1600,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "EkkoR",
                SpellType = SpellType.Circular,
                IsSpecial = true,
            });

            #endregion Ekko

            #region Elise

            Spells.Add(
            new SpellData
            {
                CharName = "Elise",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Cocoon",
                ProjectileSpeed = 1600,
                Radius = 70,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "EliseHumanE",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion Elise

            #region Evelynn

            Spells.Add(
            new SpellData
            {
                CharName = "Evelynn",
                Dangerlevel = SpellDangerLevel.High,
                Name = "EvelynnR",
                Radius = 350,
                Range = 650,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "EvelynnR",
                SpellType = SpellType.Circular,

            });
            #endregion Evelynn

            #region Ezreal

            Spells.Add(
            new SpellData
            {
                CharName = "Ezreal",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "EzrealMysticShotMissile",
                Name = "Mystic Shot",
                ProjectileSpeed = 2000,
                Radius = 60,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "EzrealMysticShot",
                ExtraSpellNames = new[] { "ezrealmysticshotwrapper", },
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ezreal",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Trueshot Barrage",
                ProjectileSpeed = 2000,
                Radius = 160,
                Range = 20000,
                SpellDelay = 1000,
                SpellKey = SpellSlot.R,
                SpellName = "EzrealTrueshotBarrage",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Ezreal",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "EzrealEssenceFluxMissile",
                Name = "Essence Flux",
                ProjectileSpeed = 1600,
                Radius = 80,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "EzrealEssenceFlux",
                SpellType = SpellType.Line,

            });

            //Testing purpose
            /*Spells.Add(
            new SpellData
            {
                CharName = "Ezreal",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "Essence Flux2",
                Radius = 250,
                Range = 1050,
                SpellDelay = 825,
                SpellKey = SpellSlot.W,
                SpellName = "EzrealEssenceFlux",
                SpellType = SpellType.Circular,

            });*/

            #endregion Ezreal

            #region Fiora

            Spells.Add(
            new SpellData
            {
                CharName = "Fiora",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "FioraWMissile",
                Name = "FioraW",
                ProjectileSpeed = 3200,
                Radius = 70,
                Range = 750,
                SpellDelay = 500,
                SpellKey = SpellSlot.W,
                SpellName = "FioraW",
                SpellType = SpellType.Line,

            });

            #endregion Fiora

            #region Fizz

            Spells.Add(
            new SpellData
            {
                CharName = "Fizz",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "FizzPiercingStrike",
                ProjectileSpeed = 1400,
                Radius = 150,
                Range = 550,
                SpellDelay = 0,
                SpellKey = SpellSlot.Q,
                SpellName = "FizzQ",
                SpellType = SpellType.Line,
                IsSpecial = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Fizz",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "FizzMarinerDoomMissile",
                Name = "Fizz ULT",
                ProjectileSpeed = 1350,
                Radius = 120,
                Range = 1300,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "FizzR",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, },
                //HasEndExplosion = true,
                SecondaryRadius = 250,
                UseEndPosition = true,
                //ExtraEndTime = 1000,

            });
            #endregion Fizz

            #region Galio

            Spells.Add(
            new SpellData
            {
                CharName = "Galio",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "GalioRighteousGust",
                ProjectileSpeed = 1300,
                Radius = 160,
                Range = 1280,
                SpellKey = SpellSlot.E,
                SpellName = "GalioRighteousGust",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Galio",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "GalioResoluteSmite",
                ProjectileSpeed = 1200,
                Radius = 235,
                Range = 1040,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "GalioResoluteSmite",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Galio",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "GalioIdolOfDurand",
                Radius = 600,
                Range = 600,
                SpellKey = SpellSlot.R,
                SpellName = "GalioIdolOfDurand",
                SpellType = SpellType.Circular,

            });
            #endregion Galio

            
        }
    }}
