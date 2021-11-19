using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
    
{
    //Should Call the LoadGame fuction from Gamemanager and Load the Next Level When called... That if it even works
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
}
