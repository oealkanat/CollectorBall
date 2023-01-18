using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneSwitcher : MonoBehaviour
{
    public Slider slider;
    public void startGame()
    {
        SceneManager.LoadScene(1);
        prizeSpawner.Amount = Convert.ToInt32(slider.value);
    }

    public void openMenu()
    {
        SceneManager.LoadScene(0);
    }
}
