using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace KiddoApp
{
    public class LoadNextScene : MonoBehaviour
    {
        public string nextScene;
        public Animator transition;
        public float transitionTime = 1.0f;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(LoadScene(nextScene));
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator LoadScene(string sceneName)
        {

            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(nextScene);
        }
    }
}

