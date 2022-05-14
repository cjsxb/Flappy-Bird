using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Movement Speed (0 = static)
    public float speed = 0f;
    // Switch Movement Direction (every x seconds)
    public float switchTime = 2f;
    // Reference to Obstacle's Rigidbody
    public Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D.velocity = new Vector2(0f, speed);
        InvokeRepeating("Switch", 0f, switchTime);
    }

    // Update is called once per frame
    void Switch()
    {
        rigid2D.velocity *= -1;
    }
}
