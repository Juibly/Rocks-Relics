using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TMP_Text tex;
    float countdown = 10;

    void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        if (countdown < 0.1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScene");
        }
        double b = System.Math.Round(countdown, 0);
        tex.text = b.ToString();

    }
}
