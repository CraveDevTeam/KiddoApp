using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace KiddoApp
{
    public class LevelLoader : MonoBehaviour
    {
        public string nextScene;
        public Animator transition;
        public float transitionTime = 1.0f;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                LoadNextScene();
            }
        }

        public void LoadNextScene()
        {
            StartCoroutine(LoadScene(nextScene));
        }

        IEnumerator LoadScene(string sceneName)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);

            SceneManager.LoadScene(nextScene);
        }
    }
}

