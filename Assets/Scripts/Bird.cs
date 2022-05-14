using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float speed = 2f;
    public float upForce = 5f;
    public Rigidbody2D rigid2D;
    public Camera cam;
    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(new Vector2(0f, upForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            Debug.Log("Level 2");
            Scene activescene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Level 2");
        }
        else if(collision.gameObject.tag == "Win2")
        {
            Debug.Log("Level 3");
            Scene activescene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("Level 3");
        }
        else if(collision.gameObject.tag == "Win3")
        {
            Debug.Log("Win");
            Scene activescene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("WinScene");
        }
        else if (collision.gameObject.tag == "WinBadge")
        {
            Application.Quit();
        }
        else
        {
            Scene activescene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activescene.buildIndex);
        }
    }

}