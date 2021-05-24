using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControlManager : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject toppanel, middlepanel;
    public void OptionsMenu()
    {
        optionPanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
    public void Back()
    {
        optionPanel.SetActive(false);
        toppanel.SetActive(true);
        middlepanel.SetActive(true);


    }
}
