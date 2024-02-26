using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    
    void Update()
    {
        if(transform.position.x < screenBounds.x * 12)
        {
            Destroy(this.gameObject);
        }
    }
}
