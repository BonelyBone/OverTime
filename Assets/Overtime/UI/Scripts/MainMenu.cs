using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour

{
    public GameObject LevelSelect;
    //Should Call the LoadGame fuction from Gamemanager and Load the Next Level When called... That if it even works
    private void Awake()
    {
        LevelSelect.gameObject.SetActive(false);
    }
    public void LoadGame()
    {
        GameManager.instance.LoadGame();
    }
    // Quits the game when called
    public void MenuQuit()
    {
        Application.Quit();
        Debug.Log("We have quit the game");
    }

    //Should Load the Level Select Menu
    public void MenuOpenSelect()
    {
        LevelSelect.gameObject.SetActive(true);
    }

    public void MenuOpenSelectClose()
    {
        LevelSelect.gameObject.SetActive(false);
    }
}
