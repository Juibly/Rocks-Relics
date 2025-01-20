using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTimer : MonoBehaviour
{
    float Ecount = 2;

    void Update()
    {
        if (Ecount > 0)
        {
            Ecount -= Time.deltaTime;
        }
        if (Ecount < 0.1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        }
    }
}
