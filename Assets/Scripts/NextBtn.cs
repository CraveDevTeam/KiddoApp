using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace KiddoApp
{
    public class NextBtn : MonoBehaviour
    {
        public string nextScene;
        // Start is called before the first frame update
        void Start()
        {

        }

        public void NextLevelButton()
        {
            // load the next scene
            SceneManager.LoadScene(nextScene);
        }
    }
}

