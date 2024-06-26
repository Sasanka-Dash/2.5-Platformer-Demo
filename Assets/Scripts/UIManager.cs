using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }

            return _instance;
        }
    }

    public GameObject StartMenuPanel;
    public GameObject GamePlayHUDPanel;

    public void StartGame()
    {
        StartMenuPanel.SetActive(false);
        GamePlayHUDPanel.SetActive(true);
    }
}
