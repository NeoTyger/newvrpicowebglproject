using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadPointsGameOver : MonoBehaviour
{
    [SerializeField] private IntegerPersistanceVariable Points;
    [SerializeField] private BooleanSO win;
    [SerializeField] private TextMeshProUGUI txtPoints;
    // Start is called before the first frame update
    void Start()
    {
        if (win.Value)
        { 
            txtPoints.text = "Congratulations, you earned " + Points.Value + "!";
        }
        else
        {
            txtPoints.text = "You lost, time has ended!";
        }
    }
}
