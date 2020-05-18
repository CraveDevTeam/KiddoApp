
using System;


namespace KiddoApp
{
    [Serializable]

    public class PlayerData
    {
        // the current save game version - increment this to invalidate obsolete save game files
        const int c_currentVersion = 1;

        // the current version of this player data file
        public int m_version;

        // is this the current game?
        public bool m_isCurrentGame;

        // all the parts of the player data
        //    public PD_General m_general;
        //    public PD_Starport m_starport;
        public PD_KidData m_kidsData;
        //    public PD_Game1 m_Game1;
        //    public PD_Game2 m_Game2;


        // this resets our player progress to the new game state
        public void Reset()
        {
            var gameData = DataManager.m_instance.m_gameData;

            m_version = c_currentVersion;
            m_isCurrentGame = false;

//            m_general = new PD_General();
//            m_starport = new PD_Starport();
            m_kidsData = new PD_KidData();
//            m_Game1 = new PD_Game1();
//            m_Game2 = new PD_Game2();

//            m_general.Reset();
//            m_starport.Reset();
            m_kidsData.Reset();
//            m_crewAssignment.Reset();
//            m_bank.Reset();

/*
            for (var i = 0; i < gameData.m_encounterList.Length; i++)
            {
                m_encounterList[i] = new PD_Encounter();

                m_encounterList[i].Reset(i);
            }
            */
        }

        // returns true if the player data version is current
        public bool IsCurrentVersion()
        {
            return (m_version == c_currentVersion);
        }
    }
}

