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
            
            #region Gnar

            Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Boulder Toss",
                MissileName = "GnarBigQMissile",
                ProjectileSpeed = 2000,
                Radius = 90,
                Range = 1150,
                SpellDelay = 500,
                SpellKey = SpellSlot.Q,
                SpellName = "GnarBigQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.High,
                Name = "GnarUlt",
                Radius = 500,
                Range = 500,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "GnarR",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Wallop",
                ProjectileSpeed = float.MaxValue,
                Radius = 100,
                Range = 600,
                SpellDelay = 600,
                SpellKey = SpellSlot.W,
                SpellName = "GnarBigW",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Boomerang Throw",
                MissileName = "GnarQMissile",
                ExtraMissileNames = new [] { "GnarQMissileReturn" },
                ProjectileSpeed = 2400,
                Radius = 60,
                Range = 1185,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "GnarQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            /*Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "GnarE",
                SpellName = "GnarE",
                Range = 475,
                SpellDelay = 0,
                Radius = 150,
                FixedRange = true,
                ProjectileSpeed = 900,
                SpellKey = SpellSlot.E,
                SpellType = SpellType.Circular,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gnar",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "GnarBigE",
                SpellName = "gnarbige",
                Range = 475,
                SpellDelay = 0,
                Radius = 100,
                FixedRange = true,
                ProjectileSpeed = 800,
                SpellKey = SpellSlot.E,
                SpellType = SpellType.Circular,
            });*/

            #endregion Gnar

            #region Gragas

            Spells.Add(
            new SpellData
            {
                CharName = "Gragas",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Barrel Roll",
                ProjectileSpeed = 1000,
                Radius = 250,
                Range = 975,
                SpellDelay = 500,
                SpellKey = SpellSlot.Q,
                SpellName = "GragasQ",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gragas",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Barrel Roll",
                ProjectileSpeed = 1200,
                Radius = 200,
                Range = 950,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "GragasE",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Gragas",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "GragasExplosiveCask",
                ProjectileSpeed = 1750,
                Radius = 350,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "GragasR",
                SpellType = SpellType.Circular,

            });
            #endregion Gragas

            #region Graves

            Spells.Add(
            new SpellData
            {
                CharName = "Graves",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "GravesQLineMis",
                ExtraMissileNames = new [] { "GravesQReturn" },
                Name = "Buckshot",
                ProjectileSpeed = 3000,
                Radius = 75,
                Range = 825,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "GravesQLineSpell",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Graves",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "GravesChargeShotShot",
                Name = "Collateral Damage",
                ProjectileSpeed = 2100,
                Radius = 100,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "GravesChargeShot",
                SpellType = SpellType.Line,

            });
            #endregion Graves
            
            
                #region Hecarim

            Spells.Add(
            new SpellData
            {
                CharName = "Hecarim",
                Dangerlevel = SpellDangerLevel.Extreme,
                Name = "HecarimR",
                MissileName = "hecarimultmissile",
                ProjectileSpeed = 1100,
                Radius = 300,
                Range = 1500,
                SpellDelay = 10,
                SpellKey = SpellSlot.R,
                SpellName = "HecarimUltMissile",
                SpellType = SpellType.Line,
                ExtraMissileNames = 
                        new []     
                        {
                        "HecarimUltMissileSkn4R1", "HecarimUltMissileSkn4c", "HecarimUltMissileSkn4R2",
                        "HecarimUltMissileSKn4L2", "HecarimUltMissileSkn4L1"
                        },

            });
            #endregion Hecarim

            #region Heimerdinger

            Spells.Add(
            new SpellData
            {
                CharName = "Heimerdinger",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "HeimerdingerESpell",
                Name = "HeimerdingerE",
                ProjectileSpeed = 1750,
                Radius = 135,
                Range = 925,
                SpellDelay = 325,
                SpellKey = SpellSlot.E,
                SpellName = "HeimerdingerE",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Heimerdinger",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "HeimerdingerW",
                MissileName = "HeimerdingerWAttack2",
                ProjectileSpeed = 2500,
                Radius = 35,
                Range = 1350,
                FixedRange = true,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "HeimerdingerW",
                SpellType = SpellType.Line,
                DefaultOff = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Heimerdinger",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Turret Energy Blast",
                ProjectileSpeed = 1650,
                Radius = 50,
                Range = 1000,
                SpellDelay = 435,
                SpellKey = SpellSlot.Q,
                SpellName = "HeimerdingerTurretEnergyBlast",
                SpellType = SpellType.Line,
                IsSpecial = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Heimerdinger",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Turret Energy Blast",
                ProjectileSpeed = 1650,
                Radius = 75,
                Range = 1000,
                SpellDelay = 350,
                SpellKey = SpellSlot.Q,
                SpellName = "HeimerdingerTurretBigEnergyBlast",
                SpellType = SpellType.Line,

            });
            #endregion Heimerdinger

            #region Illaoi

            Spells.Add(
            new SpellData
            {
                CharName = "Illaoi",
                Dangerlevel = SpellDangerLevel.High,
                Name = "IllaoiQ",
                Radius = 100,
                Range = 850,
                SpellDelay = 750,
                SpellKey = SpellSlot.Q,
                SpellName = "IllaoiQ",
                SpellType = SpellType.Line,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Illaoi",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "Illaoiemis",
                Name = "IllaoiE",
                ProjectileSpeed = 1900,
                Radius = 50,
                Range = 950,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "IllaoiE",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Illaoi",
                Dangerlevel = SpellDangerLevel.High,
                Name = "IllaoiR",
                Range = 0,
                Radius = 450,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "IllaoiR",
                SpellType = SpellType.Circular,
            });
            #endregion Illaoi
            
            #region Irelia

            Spells.Add(
            new SpellData
            {
                CharName = "Irelia",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "ireliatranscendentbladesspell",
                Name = "IreliaTranscendentBlades",
                ProjectileSpeed = 1600,
                Radius = 120,
                Range = 1200,
                SpellKey = SpellSlot.R,
                SpellDelay = 0,
                SpellName = "IreliaTranscendentBlades",
                SpellType = SpellType.Line,
                UsePackets = true,
                DefaultOff = true,
            });
            #endregion Irelia
            
            #region Ivern
         
            Spells.Add(
            new SpellData
            {
                CharName = "Ivern",                  
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Rootcaller",
                ProjectileSpeed = 1300,
                Radius = 65,
                Range = 1150,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "IvernQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyMinions, CollisionObjectType.EnemyChampions },
            });

            #endregion Ivern

            #region Janna

            Spells.Add(
            new SpellData
            {
                CharName = "Janna",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "HowlingGaleSpell",
                Name = "HowlingGaleSpell",
                ProjectileSpeed = 900,
                Radius = 120,
                Range = 1700,
                SpellKey = SpellSlot.Q,
                SpellName = "HowlingGale",
                SpellType = SpellType.Line,
                UsePackets = true,

            });
            #endregion Janna

            #region JarvanIV

            Spells.Add(
            new SpellData
            {
                CharName = "JarvanIV",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "JarvanIVDragonStrike",
                ProjectileSpeed = 2000,
                Radius = 80,
                Range = 845,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "JarvanIVDragonStrike",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "JarvanIV",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "JarvanIVDragonStrike",
                ProjectileSpeed = 1800,
                Radius = 120,
                Range = 845,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "JarvanIVDragonStrike2",
                SpellType = SpellType.Line,
                UseEndPosition = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "JarvanIV",
                Dangerlevel = SpellDangerLevel.High,
                Name = "JarvanIVCataclysm",
                ProjectileSpeed = 1900,
                Radius = 350,
                Range = 825,
                SpellDelay = 0,
                SpellKey = SpellSlot.R,
                SpellName = "JarvanIVCataclysm",
                SpellType = SpellType.Circular,

            });
            #endregion JarvanIV

            #region Jayce

            Spells.Add(
            new SpellData
            {
                CharName = "Jayce",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "JayceShockBlastMis",
                Name = "JayceShockBlastCharged",
                ProjectileSpeed = 1450,
                Radius = 70,
                Range = 1170,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "jayceshockblastmis",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                HasEndExplosion = true,
                SecondaryRadius = 210,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Jayce",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "JayceShockBlastMis",
                Name = "JayceShockBlast",
                ProjectileSpeed = 2350,
                Radius = 70,
                Range = 1600,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "jayceshockblastwallmis",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                HasEndExplosion = true,
                SecondaryRadius = 210,
                FixedRange = true,
            });
            #endregion Jayce

            #region Jinx

            Spells.Add(
            new SpellData
            {
                CharName = "Jinx",
                Dangerlevel = SpellDangerLevel.High,
                Name = "JinxR",
                ProjectileSpeed = 1700, //accelerates to 2600
                Radius = 140,
                Range = 25000,
                SpellDelay = 600,
                SpellKey = SpellSlot.R,
                SpellName = "JinxR",
                SpellType = SpellType.Line,
                FixedRange = true,
                //CollisionObjects = new[] { CollisionObjectType.EnemyChampions, },
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Jinx",
                Dangerlevel = SpellDangerLevel.High,
                //MissileName = "JinxWMissile",
                Name = "Zap",
                ProjectileSpeed = 3300,
                Radius = 60,
                Range = 1500,
                SpellDelay = 600,
                SpellKey = SpellSlot.W,
                SpellName = "JinxWMissile",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Jinx

            #region Jhin   

            Spells.Add(
            new SpellData
            {
                CharName = "Jhin",
                Dangerlevel = SpellDangerLevel.High,
                //MissileName = "JhinWMissile",
                Name = "JhinW",
                ProjectileSpeed = 2550,
                Radius = 40,
                Range = 2250,
                SpellDelay = 650,
                SpellKey = SpellSlot.W,
                SpellName = "JhinW",
                SpellType = SpellType.Line,
                FixedRange = true,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions }
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Jhin",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "JhinRShotMis",
                Name = "JhinR",
                ProjectileSpeed = 5000,
                Radius = 80,
                Range = 3500,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "JhinRShot",
                ExtraSpellNames = new [] { "JhinRShotFinal" },
                SpellType = SpellType.Line,
                FixedRange = true,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions },
                ExtraMissileNames = new[] { "JhinRShotMis4" }
            });

            #endregion

            #region Kalista

            Spells.Add(
            new SpellData
            {
                CharName = "Kalista",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "kalistamysticshotmistrue",
                Name = "KalistaQ",
                ProjectileSpeed = 1700,
                Radius = 45,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KalistaMysticShot",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Kalista

            #region Karma

            Spells.Add(
            new SpellData
            {
                CharName = "Karma",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "KarmaQMissile",
                Name = "KarmaQ",
                ProjectileSpeed = 1700,
                Radius = 60,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KarmaQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Karma",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "KarmaQMissileMantra",
                Name = "KarmaQMantra",
                ProjectileSpeed = 1700,
                Radius = 80,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KarmaQMissileMantra",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                SecondaryRadius = 250
            });
            #endregion Karma

            #region Karthus

            Spells.Add(
            new SpellData
            {
                CharName = "Karthus",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "Lay Waste",
                Radius = 190,
                Range = 875,
                SpellDelay = 625,
                SpellKey = SpellSlot.Q,
                SpellName = "KarthusLayWasteA1",
                SpellType = SpellType.Circular,
                ExtraSpellNames = new[] { "karthuslaywastea2", "karthuslaywastea3", "karthuslaywastedeada1", "karthuslaywastedeada2", "karthuslaywastedeada3" },

            });

            #endregion Karthus

            #region Kassadin

            Spells.Add(
            new SpellData
            {
                CharName = "Kassadin",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "RiftWalk",
                Radius = 270,
                Range = 700,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "RiftWalk",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                Angle = 40,
                CharName = "Kassadin",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "ForcePulse",
                Radius = 80,
                Range = 700,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "ForcePulse",
                SpellType = SpellType.Cone,

            });
            #endregion Kassadin

            #region Kennen

            Spells.Add(
            new SpellData
            {
                CharName = "Kennen",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "KennenShurikenHurlMissile1",
                Name = "Thundering Shuriken",
                ProjectileSpeed = 1700,
                Radius = 50,
                Range = 1050,
                SpellDelay = 125,
                SpellKey = SpellSlot.Q,
                SpellName = "KennenShurikenHurlMissile1",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Kennen

            #region Khazix

            Spells.Add(
            new SpellData
            {
                CharName = "Khazix",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "KhazixWMissile",
                Name = "KhazixW",
                ProjectileSpeed = 1700,
                Radius = 70,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "KhazixW",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                Angle = 22,
                CharName = "Khazix",
                Dangerlevel = SpellDangerLevel.Low,
                IsThreeWay = true,
                Name = "KhazixWLong",
                ProjectileSpeed = 1700,
                Radius = 70,
                Range = 1025,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "KhazixWLong",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Khazix",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "khazixe",
                Name = "Leap",
                ProjectileSpeed = 1200,
                Radius = 300,
                Range = 700,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "KhazixE",
                SpellType = SpellType.Circular,
            });
            Spells.Add(
            new SpellData
            {
                CharName = "Khazix",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "khazixelong",
                Name = "Leap Evolved",
                ProjectileSpeed = 1200,
                Radius = 300,
                Range = 900,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "khazixelong",
                SpellType = SpellType.Circular,
            });
            #endregion Khazix
                
            
            #region Kled

            Spells.Add(
            new SpellData
            {
                Angle = 5,
                CharName = "Kled",
                Dangerlevel = SpellDangerLevel.Normal,
                IsThreeWay = true,
                MissileName = "KledRiderQMissile",
                Name = "Pocket Pistol",
                ProjectileSpeed = 3000,
                Radius = 40,
                Range = 700,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KledRiderQ",
                SpellType = SpellType.Line,
                //splits = 5 this "splits" is not even implemented
            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Kled",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "KledQMissile",
                Name = "Beartrap on a Rope",
                ProjectileSpeed = 1600,
                Radius = 45,
                Range = 800,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KledQ",
                SpellType = SpellType.Line,
            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Kled",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Jousting",
                ProjectileSpeed = 945,
                Radius = 125,
                Range = 750,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "KledE",
                SpellType = SpellType.Line,
            });
            
            #endregion Kled

            #region KogMaw

            Spells.Add(
            new SpellData
            {
                CharName = "KogMaw",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Caustic Spittle",
                MissileName = "KogMawQ",
                ProjectileSpeed = 1650,
                Radius = 70,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "KogMawQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "KogMaw",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "KogMawVoidOoze",
                MissileName = "KogMawVoidOozeMissile",
                ProjectileSpeed = 1350,
                Radius = 120,
                Range = 1360,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "KogMawVoidOoze",
                SpellType = SpellType.Line,
                FixedRange = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "KogMaw",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "KogMawLivingArtillery",
                Name = "Living Artillery",
                Radius = 235,
                Range = 2200,
                SpellDelay = 1100,
                SpellKey = SpellSlot.R,
                SpellName = "KogMawLivingArtillery",
                SpellType = SpellType.Circular,

            });
            #endregion KogMaw

            #region Leblanc

            Spells.Add(
            new SpellData
            {
                CharName = "Leblanc",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Ethereal Chains R",
                MissileName = "LeblancSoulShackleM",
                ProjectileSpeed = 1750,
                Radius = 55,
                Range = 960,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "LeblancSoulShackleM",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Leblanc",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Ethereal Chains",
                MissileName = "LeblancEMissile",
                ProjectileSpeed = 1750,
                Radius = 55,
                Range = 960,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "LeblancE",
                ExtraMissileNames = new []{ "LeblancRE" },
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Leblanc",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "Distortion [Beta]",
                ProjectileSpeed = 1450,
                Radius = 250,
                Range = 600,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "LeblancW",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Leblanc",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "LeblancSlide",
                ProjectileSpeed = 1450,
                Radius = 250,
                Range = 725,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "LeblancSlide",
                SpellType = SpellType.Circular,

            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Leblanc",
                Dangerlevel = SpellDangerLevel.Low,
                Name = "LeblancSlideM",
                ProjectileSpeed = 1450,
                Radius = 250,
                Range = 725,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "LeblancSlideM",
                SpellType = SpellType.Circular,

            });
            #endregion Leblanc

            #region LeeSin

            Spells.Add(
            new SpellData
            {
                CharName = "LeeSin",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Sonic Wave",
                ProjectileSpeed = 1800,
                Radius = 60,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "BlindMonkQOne",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion LeeSin

            #region Leona

            Spells.Add(
            new SpellData
            {
                CharName = "Leona",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "LeonaSolarFlare",
                Name = "Leona Solar Flare",
                Radius = 250,
                Range = 1200,
                SpellDelay = 625,
                SpellKey = SpellSlot.R,
                SpellName = "LeonaSolarFlare",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Leona",
                Dangerlevel = SpellDangerLevel.High,
                ExtraDistance = 65,
                MissileName = "LeonaZenithBladeMissile",
                Name = "Zenith Blade",
                ProjectileSpeed = 2000,
                Radius = 70,
                Range = 975,
                SpellDelay = 200,
                SpellKey = SpellSlot.E,
                SpellName = "LeonaZenithBlade",
                SpellType = SpellType.Line,
                FixedRange = true,

            });
            #endregion Leona

            #region Lissandra

            Spells.Add(
            new SpellData
            {
                CharName = "Lissandra",
                Dangerlevel = SpellDangerLevel.High,
                Name = "LissandraW",
                ProjectileSpeed = float.MaxValue,
                Radius = 450,
                Range = 725,
                SpellDelay = 175,
                SpellKey = SpellSlot.W,
                SpellName = "LissandraW",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Lissandra",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "LissandraQMissile",
                Name = "Ice Shard",
                ProjectileSpeed = 2200,
                Radius = 75,
                Range = 825,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "LissandraQ",
                SpellType = SpellType.Line,
                FixedRange = true,

            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Lissandra",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Ice Shard Extended",
                ProjectileSpeed = 2200,
                Radius = 90,
                Range = 825,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "LissandraQShards",
                SpellType = SpellType.Line,

            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Lissandra",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Glacial Path",
                MissileName = "LissandraEMissile",
                ProjectileSpeed = 850,
                Radius = 125,
                Range = 1025,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "LissandraE",
                SpellType = SpellType.Line,
                FixedRange = true

            });
            #endregion Lissandra
             #region Lucian

            Spells.Add(
            new SpellData
            {
                CharName = "Lucian",
                Dangerlevel = SpellDangerLevel.Low,
                DefaultOff = true,
                MissileName = "lucianwmissile",
                Name = "LucianW",
                ProjectileSpeed = 1600,
                Radius = 80,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "LucianW",
                SecondaryRadius = 145,
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Lucian",
                Dangerlevel = SpellDangerLevel.Normal,
                //DefaultOff = true,
                MissileName = "LucianQ",
                IsSpecial = true,
                Name = "LucianQ",
                ProjectileSpeed = float.MaxValue,
                Radius = 65,
                Range = 1140,
                SpellDelay = 350,
                SpellKey = SpellSlot.Q,
                SpellName = "LucianQ",
                SpellType = SpellType.Line,

            });
            #endregion Lucian

            #region Lulu

            Spells.Add(
            new SpellData
            {
                CharName = "Lulu",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "LuluQMissile",
                ExtraMissileNames = new []{ "LuluQMissileTwo"},
                Name = "LuluQ",
                ProjectileSpeed = 1450,
                Radius = 80,
                Range = 925,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "LuluQ",
                ExtraSpellNames = new [] { "LuluQPix" },
                SpellType = SpellType.Line,
                IsSpecial = true,

            });
            #endregion Lulu

            #region Lux

            Spells.Add(
            new SpellData
            {
                CharName = "Lux",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "LuxLightStrikeKugel",
                Name = "LuxLightStrikeKugel",
                ProjectileSpeed = 1300,
                Radius = 330,
                Range = 1100,
                ExtraEndTime = 500,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "LuxLightStrikeKugel",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Lux",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Lux Malice Cannon",
                ProjectileSpeed = float.MaxValue,
                Radius = 190,
                Range = 3300,
                SpellDelay = 1000,
                SpellKey = SpellSlot.R,
                SpellName = "LuxMaliceCannon",
                SpellType = SpellType.Line,
                FixedRange = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Lux",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "LuxLightBindingMis",
                Name = "Light Binding",
                ProjectileSpeed = 1200,                
                Radius = 70,
                Range = 1300,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "LuxLightBinding",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Lux
            
            #region Maokai

            Spells.Add(
            new SpellData
            {
                CharName = "Maokai",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Arcane Smash",
                ProjectileSpeed = 1000,
                Radius = 110,
                Range = 600,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "MaokaiTrunkLine",
                SpellType = SpellType.Line,
            });

            //TODO: Fix detection
            //Spells.Add(
            //new SpellData
            //{
            //    charName = "Maokai",
            //    dangerlevel = 3,
            //    name = "Arcane Smash KnockBack",
            //    radius = 100,
            //    range = 100,
            //    spellDelay = 250,
            //    spellKey = SpellSlot.Q,
            //    spellName = "MaokaiTrunkLine",
            //    spellType = SpellType.Circular,
            //});

            Spells.Add(
            new SpellData
            {
                CharName = "Maokai",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Sapling Toss",
                ProjectileSpeed = 1000,
                Radius = 250,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "MaokaiSapling2",
                SpellType = SpellType.Circular,
            });

            #endregion Maokai

            #region Malphite

            Spells.Add(
            new SpellData
            {
                CharName = "Malphite",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "UFSlash",
                Name = "UFSlash",
                ProjectileSpeed = 2000,
                Radius = 300,
                Range = 1000,
                SpellDelay = 0,
                SpellKey = SpellSlot.R,
                SpellName = "UFSlash",
                SpellType = SpellType.Circular,

            });
            #endregion Malphite
            
            #region Malzahar

            Spells.Add(
            new SpellData
            {
                CharName = "Malzahar",
                Dangerlevel = SpellDangerLevel.Normal,
                //ExtraEndTime = 750,
                //DefaultOff = true,
                IsSpecial = true,
                IsWall = true,
                //MissileName = "AlZaharCalloftheVoidMissile",
                Name = "AlZaharCalloftheVoid",
                ProjectileSpeed = 1600,
                Radius = 85,
                Range = 900,
                SideRadius = 400,
                SpellDelay = 830,
                SpellKey = SpellSlot.Q,
                SpellName = "MalzaharQ",
                SpellType = SpellType.Line,

            });
            #endregion Malzahar

            #region MonkeyKing

            /*Spells.Add(
            new SpellData
            {
                CharName = "MonkeyKing",
                Dangerlevel = SpellDangerLevel.High,
                Name = "MonkeyKingSpinToWin",
                Radius = 225,
                Range = 300,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "MonkeyKingSpinToWin",
                SpellType = SpellType.Circular,
                DefaultOff = true,
            });*/
            #endregion MonkeyKing

            #region Morgana

            Spells.Add(
            new SpellData
            {
                CharName = "Morgana",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "DarkBindingMissile",
                Name = "Dark Binding",
                ProjectileSpeed = 1200,
                Radius = 80,
                Range = 1300,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "DarkBindingMissile",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Morgana

            #region Nami

            Spells.Add(
            new SpellData
            {
                CharName = "Nami",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "namiqmissile",
                Name = "NamiQ",
                Radius = 200,
                Range = 875,
                SpellDelay = 450,
                SpellKey = SpellSlot.Q,
                SpellName = "NamiQ",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Nami",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "NamiRMissile",
                Name = "NamiR",
                ProjectileSpeed = 850,
                Radius = 250,
                Range = 2750,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "NamiR",
                SpellType = SpellType.Line,
                FixedRange = true,
            });

            #endregion Nami

            #region Nautilus

            Spells.Add(
            new SpellData
            {
                CharName = "Nautilus",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "NautilusAnchorDragMissile",
                Name = "Dredge Line",
                ProjectileSpeed = 2000,
                Radius = 90,
                Range = 1250,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "NautilusAnchorDrag",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Nautilus

            #region Nidalee

            Spells.Add(
            new SpellData
            {
                CharName = "Nidalee",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Javelin Toss",
                MissileName = "JavelinToss",
                ProjectileSpeed = 1300,
                Radius = 40,
                Range = 1500,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "JavelinToss",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Nidalee

            #region Nocturne

            Spells.Add(
            new SpellData
            {
                CharName = "Nocturne",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "NocturneDuskbringer",
                Name = "NocturneDuskbringer",
                ProjectileSpeed = 1400,
                Radius = 60,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "NocturneDuskbringer",
                SpellType = SpellType.Line,

            });
            #endregion Nocturne

            #region Olaf

            Spells.Add(
            new SpellData
            {
                CharName = "Olaf",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "olafaxethrow",
                Name = "Undertow",
                ProjectileSpeed = 1600,
                Radius = 90,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "OlafAxeThrowCast",
                SpellType = SpellType.Line,

            });
            #endregion Olaf

            #region Orianna

            Spells.Add(
            new SpellData
            {
                CharName = "Orianna",
                Dangerlevel = SpellDangerLevel.Normal,
                //HasEndExplosion = true,
                MissileName = "OrianaIzunaCommand",
                Name = "OrianaIzunaCommand",
                ProjectileSpeed = 1200,
                Radius = 80,
                SecondaryRadius = 145,
                Range = 1650,
                SpellDelay = 0,
                SpellKey = SpellSlot.Q,
                SpellName = "OrianaIzunaCommand",
                SpellType = SpellType.Line,
                IsSpecial = true,
                UseEndPosition = true,
            });
            
            
            Spells.Add(
            new SpellData
            {
                CharName = "Orianna",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "OrianaDissonanceCommand",
                Name = "Command: Dissonance",
                Radius = 250,
                Range = 1825,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "OrianaDissonanceCommand",
                SpellType = SpellType.Circular,
                DefaultOff = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Orianna",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "OrianaDetonateCommand",
                Name = "OrianaDetonateCommand",
                Radius = 410,
                Range = 410,
                SpellDelay = 500,
                SpellKey = SpellSlot.R,
                SpellName = "OrianaDetonateCommand",
                SpellType = SpellType.Circular,
            });

            #endregion Orianna

            #region Pantheon

            Spells.Add(
            new SpellData
            {
                Angle = 35,
                CharName = "Pantheon",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "Heartseeker",
                Radius = 100,
                Range = 650,
                SpellDelay = 1000,
                SpellKey = SpellSlot.E,
                SpellName = "PantheonE",
                SpellType = SpellType.Cone,

            });
            #endregion Pantheon
            #region Poppy

            Spells.Add(
            new SpellData
            {
                CharName = "Poppy",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "PoppyQ",
                Name = "Hammer Shock",
                Radius = 100,
                Range = 450,
                SpellDelay = 500,
                SpellKey = SpellSlot.Q,
                SpellName = "PoppyQ",
                SpellType = SpellType.Line,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Poppy",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Keeper's Verdict",
                Radius = 200,
                Range = 450,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "PoppyRSpellInstant",
                SpellType = SpellType.Line,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Poppy",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Keeper's Verdict",
                Radius = 100,
                Range = 1150,
                ProjectileSpeed = 1750,
                SpellDelay = 300,
                SpellKey = SpellSlot.R,
                SpellName = "PoppyRSpell",
                MissileName = "PoppyRMissile",
                SpellType = SpellType.Line,
                FixedRange = true,
            });
            #endregion

            #region Quinn

            Spells.Add(
            new SpellData
            {
                CharName = "Quinn",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "QuinnQ",
                Name = "QuinnQ",
                ProjectileSpeed = 1550,
                Radius = 80,
                Range = 1050,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "QuinnQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            #endregion Quinn

            #region RekSai

            Spells.Add(
            new SpellData
            {
                CharName = "RekSai",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "RekSaiQBurrowedMis",
                Name = "RekSaiQ",
                ProjectileSpeed = 1950,
                Radius = 65,
                Range = 1500,
                SpellDelay = 125,
                SpellKey = SpellSlot.Q,
                SpellName = "ReksaiQBurrowed",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });
            #endregion RekSai

            #region Rengar
            
            
            Spells.Add(
            new SpellData
            {
                CharName = "Rengar",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Savagery [Beta]",
                Radius = 150,
                Range = 500,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "RengarQ2",
                ExtraSpellNames = new[] { "RengarQ2Emp" },
                SpellType = SpellType.Line,
            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Rengar",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "RengarEFinal",
                Name = "Bola Strike",
                ProjectileSpeed = 1500,
                Radius = 70,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "RengarE",
                SpellType = SpellType.Line,
                ExtraSpellNames = new []{ "RengarEEmp" },
                ExtraMissileNames = new []{ "RengarEFinalMAX","RengerEEmpMis", "RengarEMis" },
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            #endregion Rengar
                
             #region Riven

            Spells.Add(
            new SpellData
            {
                Angle = 15,
                CharName = "Riven",
                Dangerlevel = SpellDangerLevel.Normal,
                IsThreeWay = true,
                Name = "WindSlash",
                ProjectileSpeed = 1600,
                Radius = 100,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "RivenIzunaBlade",
                SpellType = SpellType.Line,
                IsSpecial = true,
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Riven",
                Dangerlevel = SpellDangerLevel.Normal,
                DefaultOff = true,
                MissileName = "RivenMartyr",
                Name = "RivenW",
                ProjectileSpeed = 1500,
                Radius = 280,
                Range = 650,
                SpellDelay = 0,
                SpellKey = SpellSlot.W,
                SpellName = "RivenMartyr",
                SpellType = SpellType.Circular,

            });
            #endregion Riven
            
  
            
            #region Rumble
            
            Spells.Add(
            new SpellData
            {
                CharName = "Rumble",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "RumbleGrenadeMissile",
                Name = "RumbleGrenade",
                ProjectileSpeed = 2000,
                Radius = 60,
                Range = 950,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "RumbleGrenade",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });
            
            
            Spells.Add(
            new SpellData
            {
                CharName = "Rumble",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "RumbleCarpetBombMissile",
                Name = "Carpet Bomb",
                ProjectileSpeed = 1600,
                Radius = 200,
                Range = 1200,
                SpellDelay = 0,
                SpellKey = SpellSlot.R,
                SpellName = "RumbleCarpetBomb",
                SpellType = SpellType.Line,
                UsePackets = true,
                FixedRange = true,
            });
            
            #endregion Rumble

            #region Ryze
            
            Spells.Add(
            new SpellData
            {
                CharName = "Ryze",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "RyzeQ",
                Name = "RyzeQ",
                ProjectileSpeed = 1700,
                Radius = 60,
                Range = 900,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "RyzeQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            #endregion Ryze
                


            
            #region Sejuani
            Spells.Add(
            new SpellData
            {
                CharName = "Sejuani",
                Dangerlevel = SpellDangerLevel.High,
                Name = "Arctic Assault",
                ProjectileSpeed = 1250,
                Radius = 70,
                Range = 850,
                SpellDelay = 0,
                SpellKey = SpellSlot.Q,
                SpellName = "SejuaniArcticAssault",
                SpellType = SpellType.Line,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Sejuani",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "SejuaniGlacialPrison",
                Name = "SejuaniR",
                ProjectileSpeed = 1600,
                Radius = 110,
                Range = 1200,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "SejuaniGlacialPrisonCast",
                ExtraSpellNames = new [] { "SejuaniGlacialPrison" },
                SpellType = SpellType.Line,

            });
            #endregion Sejuani


            
                
            #region Shen

            Spells.Add(
            new SpellData
            {
                CharName = "Shen",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "ShenE",
                Name = "ShadowDash",
                ProjectileSpeed = 1450,
                Radius = 50,
                Range = 600,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "ShenE",
                SpellType = SpellType.Line,

            });

            #endregion Shen

            
            #region Shyvana

            Spells.Add(
            new SpellData
            {
                CharName = "Shyvana",
                Dangerlevel = SpellDangerLevel.Low,
                MissileName = "ShyvanaFireballMissile",
                Name = "ShyvanaFireball",
                ProjectileSpeed = 1700,
                Radius = 60,
                Range = 950,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "ShyvanaFireball",
                SpellType = SpellType.Line,
                FixedRange = true,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Shyvana",
                Dangerlevel = SpellDangerLevel.High,
                IsThreeWay = true,
                MissileName = "ShyvanaFireballDragonFxMissile",
                Name = "Flame Breath Dragon",
                ProjectileSpeed = 2000,
                Radius = 70,
                Range = 850,
                SpellDelay = 250,
                ExtraEndTime = 200,
                SpellKey = SpellSlot.R,
                SpellName = "shyvanafireballdragon2",
                SpellType = SpellType.Line,

            });
            
            Spells.Add(
            new SpellData
            {
                CharName = "Shyvana",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "ShyvanaTransformCast",
                Name = "Dragon's Descent",
                ProjectileSpeed = 1250,
                Radius = 160,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "ShyvanaTransformCast",
                SpellType = SpellType.Line,

            });
            
            
            #endregion Shyvana
            
             #region Sion

            Spells.Add(
            new SpellData
            {
                CharName = "Sion",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "SionEMissile",
                Name = "SionE",
                ProjectileSpeed = 1800,
                Radius = 80,
                Range = 800,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "SionE",
                SpellType = SpellType.Line,
                IsSpecial = true,
                FixedRange = true,

            });
            #endregion Sion

            #region Sivir

            Spells.Add(
            new SpellData
            {
                CharName = "Sivir",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "SivirQMissile",
                Name = "Boomerang Blade",
                ProjectileSpeed = 1350,
                Radius = 100,
                Range = 1275,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "SivirQ",
                ExtraMissileNames = new[] { "SivirQMissileReturn" },
                ExtraSpellNames = new[] { "SivirQReturn" },
                SpellType = SpellType.Line,
                FixedRange = true,
            });

            #endregion Sivir

            #region Skarner

            Spells.Add(
            new SpellData
            {
                CharName = "Skarner",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "SkarnerFractureMissile",
                Name = "SkarnerFracture",
                ProjectileSpeed = 1400,
                Radius = 60,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.E,
                SpellName = "SkarnerFracture",
                SpellType = SpellType.Line,
                FixedRange = true,
            });
            #endregion Skarner

            #region Sona

            Spells.Add(
            new SpellData
            {
                CharName = "Sona",
                Dangerlevel = SpellDangerLevel.Extreme,
                MissileName = "SonaR",
                Name = "Crescendo",
                ProjectileSpeed = 2400,
                Radius = 150,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "SonaR",
                SpellType = SpellType.Line,
                FixedRange = true,
            });
            #endregion Sona

            #region Soraka

            Spells.Add(
            new SpellData
            {
                CharName = "Soraka",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "SorakaQ",
                ProjectileSpeed = 1100,
                Radius = 260,
                Range = 970,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "SorakaQ",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Soraka",
                Dangerlevel = SpellDangerLevel.High,
                DefaultOff = true,
                Name = "SorakaE",
                Radius = 275,
                Range = 925,
                SpellDelay = 1750,
                SpellKey = SpellSlot.E,
                SpellName = "SorakaE",
                SpellType = SpellType.Circular,

            });
            #endregion Soraka

            #region Swain

            Spells.Add(
            new SpellData
            {
                CharName = "Swain",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "SwainShadowGrasp",
                Name = "Nevermove",
                Radius = 250,
                Range = 900,
                SpellDelay = 1100,
                SpellKey = SpellSlot.W,
                SpellName = "SwainShadowGrasp",
                SpellType = SpellType.Circular,

            });
            #endregion Swain

            #region Syndra

            Spells.Add(
            new SpellData
            {
                Angle = 30,
                CharName = "Syndra",
                Dangerlevel = SpellDangerLevel.High,
                Name = "SyndraE",
                MissileName = "SyndraE",
                UsePackets = true,
                ProjectileSpeed = 2000,
                Radius = 90,
                Range = 850,
                SpellDelay = 0,
                SpellKey = SpellSlot.E,
                SpellName = "SyndraE",
                ExtraSpellNames = new []{ "syndrae5" },
                SpellType = SpellType.Line,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Syndra",
                Dangerlevel = SpellDangerLevel.Normal,
                Name = "SyndraW",
                MissileName = "syndrawcast",
                ProjectileSpeed = 1450,
                Radius = 220,
                Range = 925,
                SpellDelay = 250,
                SpellKey = SpellSlot.W,
                SpellName = "SyndraWCast",
                SpellType = SpellType.Circular,

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Syndra",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "SyndraQSpell",
                Name = "SyndraQ",
                Radius = 210,
                Range = 800,
                SpellDelay = 600,
                SpellKey = SpellSlot.Q,
                SpellName = "SyndraQ",
                MissileName = "SyndraQSpell",
                SpellType = SpellType.Circular,

            });
            #endregion Syndra
            
            #region TahmKench

            Spells.Add(
            new SpellData
            {
                CharName = "TahmKench",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "TahmkenchQMissile",
                Name = "TahmKenchQ",
                ProjectileSpeed = 2000,
                SpellDelay = 250,
                Radius = 70,
                Range = 800,
                SpellKey = SpellSlot.Q,
                SpellName = "TahmKenchQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            #endregion TahmKench
            
            #region Taliyah

            Spells.Add(
            new SpellData
            {
                CharName = "Taliyah",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "TaliyahQMis",
                Name = "TaliyahQ",
                ProjectileSpeed = 1450,
                Radius = 100,
                Range = 1000,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "TaliyahQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },

            });

            Spells.Add(
            new SpellData
            {
                CharName = "Taliyah",
                Dangerlevel = SpellDangerLevel.High,
                Name = "TaliyahW",
                Radius = 165,
                Range = 900,
                SpellDelay = 450,
                ExtraEndTime = 1000,
                SpellKey = SpellSlot.W,
                SpellName = "TaliyahWVC",
                ExtraSpellNames = new []{ "TaliyahW" },
                SpellType = SpellType.Circular,

            });
            #endregion Taliyah

            #region Talon

            Spells.Add(
            new SpellData
            {
                Angle = 14,
                CharName = "Talon",
                Dangerlevel = SpellDangerLevel.Normal,
                IsThreeWay = true,
                MissileName = "talonwmissile",
                Name = "TalonRake",
                ProjectileSpeed = 2300,
                Radius = 75,
                Range = 900,
                SpellKey = SpellSlot.W,
                SpellName = "talonw",
                SpellType = SpellType.Line,
                Splits = 3,
                IsSpecial = true,
                FixedRange = true,
            });
            
            Spells.Add(
            new SpellData
            {
                Angle = 14,
                CharName = "Talon",
                Dangerlevel = SpellDangerLevel.Normal,
                IsThreeWay = true,
                Name = "TalonRake",
                ProjectileSpeed = 3000,
                Radius = 75,
                Range = 900,
                SpellKey = SpellSlot.W,
                SpellName = "talonwmissiletwo",
                SpellType = SpellType.Line,
                Splits = 3,
                IsSpecial = true,
                FixedRange = true,
            });
            #endregion Talon

            #region Thresh

            Spells.Add(
            new SpellData
            {
                CharName = "Thresh",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "ThreshQMissile",
                Name = "ThreshQ",
                ProjectileSpeed = 1900,
                Radius = 70,
                Range = 1100,
                SpellDelay = 500,
                SpellKey = SpellSlot.Q,
                SpellName = "ThreshQ",
                SpellType = SpellType.Line,
                CollisionObjects = new[] { CollisionObjectType.EnemyChampions, CollisionObjectType.EnemyMinions },
                FixedRange = true,
            });

            Spells.Add(
            new SpellData
            {
                CharName = "Thresh",
                Dangerlevel = SpellDangerLevel.High,
                MissileName = "ThreshEMissile1",
                Name = "ThreshE",
                ProjectileSpeed = 2000,
                Radius = 110,
                Range = 1075,
                SpellDelay = 125,
                DefaultOff = true,
                SpellKey = SpellSlot.E,
                SpellName = "ThreshE",
                ExtraSpellNames = new [] { "ThreshEFlay" },
                SpellType = SpellType.Line,
                UsePackets = true,
                FixedRange = true,
                
            });
            #endregion Thresh

            #region TwistedFate

            Spells.Add(
            new SpellData
            {
                Angle = 28,
                CharName = "TwistedFate",
                Dangerlevel = SpellDangerLevel.Normal,
                IsThreeWay = true,
                MissileName = "SealFateMissile",
                Name = "Loaded Dice",
                ProjectileSpeed = 1000,
                Radius = 40,
                Range = 1450,
                SpellDelay = 250,
                SpellKey = SpellSlot.Q,
                SpellName = "WildCards",
                SpellType = SpellType.Line,
                IsSpecial = true,
            });
            #endregion TwistedFate

            #region Twitch

            Spells.Add(
            new SpellData
            {
                CharName = "Twitch",
                Dangerlevel = SpellDangerLevel.Normal,
                MissileName = "TwitchSprayandPrayAttack",
                Name = "Loaded Dice",
                ProjectileSpeed = 4000,
                Radius = 65,
                Range = 1100,
                SpellDelay = 250,
                SpellKey = SpellSlot.R,
                SpellName = "TwitchSprayandPrayAttack",
                SpellType = SpellType.Line
            });

            #endregion Twitch
           

            

           
            
   
        }
    }}
