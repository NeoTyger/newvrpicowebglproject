using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    
    [SerializeField] private Button btnReturn;
    
    // Start is called before the first frame update
    void Start()
    {
        btnReturn.onClick.AddListener(ReturnToMainMenu);
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
