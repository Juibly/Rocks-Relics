using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController1 : MonoBehaviour
{
    private const string movex = "MoveX";
    private const string movey = "MoveY";
    private const string lastx = "LastX";
    private const string lasty = "LastY";
    private Animator anim1;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 300;
        anim1 = GetComponent<Animator>();

    }

    void Update()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -0.08f;
            anim1.SetFloat(lastx, horizontal);
            anim1.SetFloat(lasty, vertical);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 0.08f;
            anim1.SetFloat(lastx, horizontal);
            anim1.SetFloat(lasty, vertical);
        }
        Debug.Log(horizontal);


        if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 0.08f;
            anim1.SetFloat(lasty, vertical);
            anim1.SetFloat(lastx, horizontal);
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -0.08f;
            anim1.SetFloat(lasty, vertical);
            anim1.SetFloat(lastx, horizontal);
        }
        Debug.Log(vertical);

        anim1.SetFloat(movex, horizontal);
        anim1.SetFloat(movey, vertical);

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Goal")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
        }
        else if (other.gameObject.tag == "Rock")
        {
            audioSource.PlayOneShot(clip, volume);
        }
    }

}