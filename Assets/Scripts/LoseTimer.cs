using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTimer : MonoBehaviour
{
    float Lcount = 2;
    void Update()
    {
        if (Lcount > 0)
        {
            Lcount -= Time.deltaTime;
        }
        if (Lcount < 0.1)
        {
            Application.Quit();
        }
    }
}