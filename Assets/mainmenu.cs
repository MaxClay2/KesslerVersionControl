using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   // Runs the Next scene in the que when the start button is clicked 
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Closes the game when the player clicks the Exit Button  
    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
