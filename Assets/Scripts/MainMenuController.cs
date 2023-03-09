#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    
    public void QuitGame()
    {
        Debug.Log("QuitGame function provoked");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
#endif
