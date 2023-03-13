using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnOptions;

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ToOptionsMenu()
    {
        SceneManager.LoadScene("Options Menu");
    }

    public void Exitgame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }


    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(StartGame);
        btnExit.onClick.AddListener(Exitgame);
        btnOptions.onClick.AddListener(ToOptionsMenu);
    }
}
