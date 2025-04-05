using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] TMP_Text logText;
    [SerializeField] TMP_InputField inputField;
    public GameObject button;

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }

    void OnMouseDown()
    {
        OpenGame();
    }

    void Start()
    {

    }
}
