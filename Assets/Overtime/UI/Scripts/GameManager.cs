using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Object Public stuff
    public static GameManager instance;
    public GameObject loadingScreen;

    private void Awake() //this is when the script starts it will load the TITLE_SCREEN Scene but keep loading screen scene Loaded!
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive);
    }

    List<AsyncOperation> scenesLoading = new List<AsyncOperation>();
    public void LoadGame()
    {
        //This will set the Loading Screen Object to Active when required, and unload the Title Screen
        loadingScreen.gameObject.SetActive(true);

        SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN);
        SceneManager.LoadSceneAsync((int)SceneIndexes.LEVEL_01, LoadSceneMode.Additive);

        //Section below is where it checks to see if the scene is done loading so it can 
        StartCoroutine(GetSceneLoadProgress());
    }
    
    public IEnumerator GetSceneLoadProgress()
    {
        //This checks if the loading screen is done loading.
        for (int i = 0; i < scenesLoading.Count; i++)
        {
            while (!scenesLoading[i].isDone)
            {
                yield return null;
            }
        }

        loadingScreen.gameObject.SetActive(false);
    }
}
