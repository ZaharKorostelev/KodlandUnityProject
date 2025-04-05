using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObject : MonoBehaviour
{
    public GameObject cross;
    public GameObject zero;
    public static bool iscross = true;
    static int[,] Board = new int[3, 3] { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
    public static int Winner = -1; // -1 - нет победителя, 0 - нолик, 1 - крестик

    public void OpenRetry()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Board[i, j] = -1;
            }
        }
        iscross = true;
        SceneManager.LoadScene("Retry");
    }

    void Victory()
    {
        // Проверка строк
        for (int i = 0; i < 3; i++)
        {
            if (Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2] && Board[i, 0] != -1)
            {
                Winner = Board[i, 0];
                OpenRetry();
            }
        }

        // Проверка столбцов
        for (int j = 0; j < 3; j++)
        {
            if (Board[0, j] == Board[1, j] && Board[1, j] == Board[2, j] && Board[0, j] != -1)
            {
                Winner = Board[0, j];
                OpenRetry();
            }
        }

        // Проверка диагоналей
        if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && Board[0, 0] != -1)
        {
            Winner = Board[0, 0];
            OpenRetry();
        }
        if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && Board[0, 2] != -1)
        {
            Winner = Board[0, 2];
            OpenRetry();
        }
    }

    void OnMouseDown()
    {
        string s = gameObject.tag;
        int x = -1, y = -1;
        if (tag == "00")
        {
            x = 0;
            y = 0;
        }
        else if (tag == "10")
        {
            x = 1;
            y = 0;
        }
        else if (tag == "20")
        {
            x = 2;
            y = 0;
        }
        else if (tag == "01")
        {
            x = 0;
            y = 1;
        }
        else if (tag == "11")
        {
            x = 1;
            y = 1;
        }
        else if (tag == "21")
        {
            x = 2;
            y = 1;
        }
        else if (tag == "02")
        {
            x = 0;
            y = 2;
        }
        else if (tag == "12")
        {
            x = 1;
            y = 2;
        }
        else if (tag == "22")
        {
            x = 2;
            y = 2;
        }

        if (iscross)
        {
            if (Board[y, x] == -1)
            {
                cross.SetActive(true);
                iscross = false;
                Board[y, x] = 1;
                Victory();
            }
        }
        else
        {
            if (Board[y, x] == -1)
            {
                zero.SetActive(true);
                iscross = true;
                Board[y, x] = 0;
                Victory();
            }
        }

    }

    void Start()
    {
        if (cross != null)
        {
            cross.SetActive(false);
        }

        if (zero != null)
        {
            zero.SetActive(false);
        }
    }

    void Update()
    {

    }
}