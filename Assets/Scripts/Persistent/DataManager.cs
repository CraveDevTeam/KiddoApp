using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;


namespace KiddoApp
{
    public class DataManager : MonoBehaviour
    {
        // the number of save game slots
        public const int c_numSaveGameSlots = 15;

        // static reference to this instance
        public static DataManager m_instance;
        //  public static string m_sceneToLoad = "Intro";

        // the name of the game data file
        public string m_gameDataFileName;

        // the name of the save game file
        public string m_playerDataFileName;

        // the loaded game data
        public GameData m_gameData;

        // the save game slots
        public PlayerData[] m_playerDataList;

        // the player data from the current save game slot
        public PlayerData m_playerData;

        // the active save game slot number
        public int m_activeSaveGameSlotNumber;

        // set this to switch to a different save game slot
        int m_targetSaveGameSlotNumber;

        // unity awake
        void Awake()
        {
            // remember this instance to this
            m_instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SaveActiveGame()
        {
            SavePlayerData(m_activeSaveGameSlotNumber);
        }

        // this saves a save game slot to disk
        public void SavePlayerData(int saveGameSlotNumber)
        {
            // measure performance
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            // get the path to the player data file
            var filePath = Application.persistentDataPath + "/" + m_playerDataFileName + saveGameSlotNumber + ".bin";

            try
            {
                // try to save the player data file
                using (var file = File.Create(filePath))
                {
                    // create the binary formatter
                    var binaryFormatter = new BinaryFormatter();
                    /*
                                    // add support for serializing / deserializing Unity.Vector3
                                    var surrogateSelector = new SurrogateSelector();
                                    var vector3SerializationSurrogate = new Vector3SerializationSurrogate();
                                    surrogateSelector.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), vector3SerializationSurrogate);
                                    binaryFormatter.SurrogateSelector = surrogateSelector;
                    */
                    // serialize and save the player data file
                    binaryFormatter.Serialize(file, m_playerDataList[saveGameSlotNumber]);

                    // report how long it took
                    UnityEngine.Debug.Log("Saving the player data took " + stopwatch.ElapsedMilliseconds + " milliseconds.");
                }
            }
            catch (IOException exception)
            {
                // report if we got an exception
                UnityEngine.Debug.Log("Saving player data failed - " + exception.Message);
            }
        }
    }
}
