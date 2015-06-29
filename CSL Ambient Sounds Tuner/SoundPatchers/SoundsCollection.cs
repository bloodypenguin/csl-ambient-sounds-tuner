﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmbientSoundsTuner.SoundPatchers
{
    /// <summary>
    /// A static class that holds references to various sounds within the game.
    /// </summary>
    public static class SoundsCollection
    {
        private const string ID_COW_INFO = "Cow";
        private const string ID_PIG_INFO = "Pig";
        private const string ID_SEAGULL_INFO = "Seagull";
        private const string ID_SEAGULL_SCREAM = "Seagull Scream";

        private const string ID_ADVANCED_WIND_TURBINE_INFO = "Advanced Wind Turbine";
        private const string ID_AIRPORT_BUILDING = "Building Airport";
        private const string ID_BUS_DEPOT_BUILDING = "Building Bus Depot";
        private const string ID_CEMETERY_INFO = "Cemetery";
        private const string ID_COAL_POWER_PLANT_INFO = "Coal Power Plant";
        private const string ID_COMMERCIAL_BUILDING = "Building Commercial";
        private const string ID_CREMATORY_INFO = "Crematory";
        private const string ID_ELEMENTARY_SCHOOL_INFO = "Elementary School";
        private const string ID_ELEMENTARY_SCHOOL_EU_INFO = "Elementary_School_EU";
        private const string ID_FIRE_STATION_BUILDING = "Building Fire Station";
        private const string ID_FUSION_POWER_PLANT_INFO = "Fusion Power Plant";
        private const string ID_HARBOR_BUILDING = "Building Harbor";
        private const string ID_HIGH_SCHOOL_INFO = "High School";
        private const string ID_HIGH_SCHOOL_EU_INFO = "highschool_EU";
        private const string ID_HOSPITAL_BUILDING = "Building Hospital";
        private const string ID_HYDRO_POWER_PLANT_INFO = "Dam Power House";
        private const string ID_INCINERATION_PLANT_INFO = "Combustion Plant";
        private const string ID_INDUSTRIAL_BUILDING = "Building Industrial";
        private const string ID_METRO_STATION_BUILDING = "Building Metro Station";
        private const string ID_NUCLEAR_POWER_PLANT_INFO = "Nuclear Power Plant";
        private const string ID_POLICE_STATION_BUILDING = "Building Police Station";
        private const string ID_POWER_PLANT_SMALL_BUILDING = "Building Power Plant Small";
        private const string ID_SOLAR_POWER_PLANT_INFO = "Solar Power Plant";
        private const string ID_TRAIN_STATION_BUILDING = "Building Train Station";
        private const string ID_UNIVERSITY_INFO = "University";
        private const string ID_UNIVERSITY_EU_INFO = "University_EU";
        private const string ID_WATER_DRAIN_PIPE_INFO = "Water Outlet";
        private const string ID_WATER_PUMPING_STATION_INFO = "Water Intake";
        private const string ID_WIND_TURBINE_INFO = "Wind Turbine";


        private const string ID_BUILDING_BULLDOZE = "Building Bulldoze Sound";
        private const string ID_BUILDING_LEVELUP = "Levelup Sound";
        private const string ID_BUILDING_PLACEMENT = "Building Placement Sound";
        private const string ID_PROP_BULLDOZE = "Prop Bulldoze Sound";
        private const string ID_PROP_PLACEMENT = "Prop Placement Sound";
        private const string ID_ROAD_BULLDOZE = "Road Bulldoze Sound";
        private const string ID_ROAD_PLACEMENT = "Road Placement Sound";

        /// <summary>
        /// Gets the ambient sounds; or null if they don't exist.
        /// </summary>
        public static AudioInfo[] Ambients
        {
            get
            {
                return AudioManager.instance.m_properties.m_ambients;
            }
        }

        private static EffectSounds effects = new EffectSounds();
        /// <summary>
        /// Gets the effect sounds.
        /// </summary>
        public static EffectSounds Effects
        {
            get
            {
                return effects;
            }
        }

        /// <summary>
        /// Gets the cow sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect Cow
        {
            get
            {
                CitizenInfo cowInfo = PrefabCollection<CitizenInfo>.FindLoaded(ID_COW_INFO);
                if (cowInfo != null)
                {
                    return ((LivestockAI)cowInfo.m_citizenAI).m_randomEffect as SoundEffect;
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the pig sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect Pig
        {
            get
            {
                CitizenInfo pigInfo = PrefabCollection<CitizenInfo>.FindLoaded(ID_COW_INFO);
                if (pigInfo != null)
                {
                    return ((LivestockAI)pigInfo.m_citizenAI).m_randomEffect as SoundEffect;
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the seagull sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect Seagull
        {
            get
            {
                CitizenInfo seagullInfo = PrefabCollection<CitizenInfo>.FindLoaded(ID_SEAGULL_INFO);
                if (seagullInfo != null)
                {
                    MultiEffect effect = ((BirdAI)seagullInfo.m_citizenAI).m_randomEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_SEAGULL_SCREAM).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }


        /// <summary>
        /// Gets the hydro power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo AdvancedWindTurbine
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_ADVANCED_WIND_TURBINE_INFO);
            }
        }

        /// <summary>
        /// Gets the airport audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Airport
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_AIRPORT_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the bus depot audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo BusDepot
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_BUS_DEPOT_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the cemetery audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Cemetery
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_CEMETERY_INFO);
            }
        }

        /// <summary>
        /// Gets the coal/oil power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo CoalOilPowerPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_COAL_POWER_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the commercial audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Commercial
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_COMMERCIAL_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the crematory audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Crematory
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_CREMATORY_INFO);
            }
        }

        /// <summary>
        /// Gets the elementary school audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo ElementarySchool
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_ELEMENTARY_SCHOOL_INFO) ?? GetAudioInfoFromBuildingInfo(ID_ELEMENTARY_SCHOOL_EU_INFO);
            }
        }

        /// <summary>
        /// Gets the fire station audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo FireStation
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_serviceSounds, ID_FIRE_STATION_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the fusion power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo FusionPowerPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_FUSION_POWER_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the harbor audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Harbor
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_HARBOR_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the high school audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo HighSchool
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_HIGH_SCHOOL_INFO) ?? GetAudioInfoFromBuildingInfo(ID_HIGH_SCHOOL_EU_INFO);
            }
        }

        /// <summary>
        /// Gets the hospital audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Hospital
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_serviceSounds, ID_HOSPITAL_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the hydro power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo HydroPowerPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_HYDRO_POWER_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the incineration plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo IncinerationPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_INCINERATION_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the industrial audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo Industrial
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_INDUSTRIAL_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the metro station audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo MetroStation
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_METRO_STATION_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the nuclear power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo NuclearPowerPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_NUCLEAR_POWER_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the police station audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo PoliceStation
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_serviceSounds, ID_POLICE_STATION_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the small power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo PowerPlantSmall
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_serviceSounds, ID_POWER_PLANT_SMALL_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the solar power plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo SolarPowerPlant
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_SOLAR_POWER_PLANT_INFO);
            }
        }

        /// <summary>
        /// Gets the train station audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo TrainStation
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    return GetAudioInfoFromArray(BuildingManager.instance.m_properties.m_subServiceSounds, ID_TRAIN_STATION_BUILDING);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the university audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo University
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_UNIVERSITY_INFO) ?? GetAudioInfoFromBuildingInfo(ID_UNIVERSITY_EU_INFO);
            }
        }

        /// <summary>
        /// Gets the water drain pipe and water treatment plant audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo WaterDrainPipe
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_WATER_DRAIN_PIPE_INFO);
            }
        }

        /// <summary>
        /// Gets the water pumping station audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo WaterPumpingStation
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_WATER_PUMPING_STATION_INFO);
            }
        }

        /// <summary>
        /// Gets the wind turbine audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo WindTurbine
        {
            get
            {
                return GetAudioInfoFromBuildingInfo(ID_WIND_TURBINE_INFO);
            }
        }


        /// <summary>
        /// Gets the building bulldoze sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect BuildingBulldoze
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    MultiEffect effect = BuildingManager.instance.m_properties.m_bulldozeEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_BUILDING_BULLDOZE).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the building fire sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect BuildingFire
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    FireEffect effect = BuildingManager.instance.m_properties.m_fireEffect as FireEffect;
                    if (effect != null)
                    {
                        return effect.m_soundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the building level up sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect BuildingLevelUp
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    MultiEffect effect = BuildingManager.instance.m_properties.m_levelupEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_BUILDING_LEVELUP).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the building placement sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect BuildingPlacement
        {
            get
            {
                if (BuildingManager.instance.m_properties != null)
                {
                    MultiEffect effect = BuildingManager.instance.m_properties.m_placementEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_BUILDING_PLACEMENT).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the prop bulldoze sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect PropBulldoze
        {
            get
            {
                if (PropManager.instance.m_properties != null)
                {
                    MultiEffect effect = PropManager.instance.m_properties.m_bulldozeEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_PROP_BULLDOZE).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the prop placement sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect PropPlacement
        {
            get
            {
                if (PropManager.instance.m_properties != null)
                {
                    MultiEffect effect = PropManager.instance.m_properties.m_placementEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_PROP_PLACEMENT).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the road bulldoze sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect RoadBulldoze
        {
            get
            {
                if (NetManager.instance.m_properties != null)
                {
                    MultiEffect effect = NetManager.instance.m_properties.m_bulldozeEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_ROAD_BULLDOZE).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the road draw audio info; or null if it doesn't exist.
        /// </summary>
        public static AudioInfo RoadDraw
        {
            get
            {
                if (NetManager.instance.m_properties != null)
                {
                    return NetManager.instance.m_properties.m_drawSound;
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the road placement sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect RoadPlacement
        {
            get
            {
                if (NetManager.instance.m_properties != null)
                {
                    MultiEffect effect = NetManager.instance.m_properties.m_placementEffect as MultiEffect;
                    if (effect != null)
                    {
                        return effect.m_effects.FirstOrDefault(e => e.m_effect.name == ID_ROAD_PLACEMENT).m_effect as SoundEffect;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the zone fill sound effect; or null if it doesn't exist.
        /// </summary>
        public static SoundEffect ZoneFill
        {
            get
            {
                if (ZoneManager.instance.m_properties != null)
                {
                    return ZoneManager.instance.m_properties.m_fillEffect as SoundEffect;
                }
                return null;
            }
        }


        private static AudioInfo GetAudioInfoFromBuildingInfo(string id)
        {
            BuildingInfo info = PrefabCollection<BuildingInfo>.FindLoaded(id);
            if (info != null)
            {
                return info.m_customLoopSound;
            }
            return null;
        }

        private static AudioInfo GetAudioInfoFromArray(AudioInfo[] list, string id)
        {
            if (list != null)
            {
                return list.FirstOrDefault(a => a != null && a.name == id);
            }
            return null;
        }


        private static float menuClickSoundVolume = 1;
        /// <summary>
        /// Gets or sets the click sound volume in menus.
        /// </summary>
        public static float MenuClickSoundVolume
        {
            get { return menuClickSoundVolume; }
            set { menuClickSoundVolume = value; }
        }


        private static float menuDisabledClickSoundVolume = 1;
        /// <summary>
        /// Gets or sets the disabled click sound volume in menus.
        /// </summary>
        public static float MenuDisabledClickSoundVolume
        {
            get { return menuDisabledClickSoundVolume; }
            set { menuDisabledClickSoundVolume = value; }
        }

        /// <summary>
        /// A class that's basically a shortcut to generic effect sounds.
        /// </summary>
        public class EffectSounds
        {
            /// <summary>
            /// Gets an effect sound.
            /// </summary>
            /// <param name="id">The effect sound id.</param>
            /// <returns>The effect sound if it exists; null otherwise.</returns>
            public SoundEffect this[string id]
            {
                get
                {
                    EffectInfo effectInfo = EffectCollection.FindEffect(id);
                    SoundEffect soundEffect = effectInfo as SoundEffect;
                    if (soundEffect != null)
                    {
                        return soundEffect;
                    }
                    return null;
                }
            }
        }
    }
}
