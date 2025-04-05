using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEditor.VersionControl;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using JetBrains.Annotations;
public class RetryManager : MonoBehaviour
{
    [SerializeField] TMP_Text logText;
    void Start()
    {
        if (ClickObject.Winner == 1)
        {
        logText.text = "Победитель: Крестики";
        }
        else
        {
        logText.text = "Победитель: Нолики";
        }

    }

    void Update()
    {
        
    }
    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
