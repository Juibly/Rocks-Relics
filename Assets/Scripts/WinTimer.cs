using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTimer : MonoBehaviour
{
    float Wcount = 2;
    void Update()
    {
        if (Wcount > 0)
        {
            Wcount -= Time.deltaTime;
        }
        if (Wcount < 0.1)
        {
            Application.Quit();
        }
    }
}
