using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private Button btnRestart;
    [SerializeField] private Button btnMenu;
    [SerializeField] private Button btnQuit;
    // Start is called before the first frame update
    void Start()
    {
        btnRestart.onClick.AddListener(RestartGame);
        btnMenu.onClick.AddListener(ToMainMenu);
        btnQuit.onClick.AddListener(QuitGame);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    private void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        if(EditorApplication.isPlaying) 
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
            Application.Quit();
#endif
    }
}
