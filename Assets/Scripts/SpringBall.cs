using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBall : MonoBehaviour
{
    public deployobstacles obstacle;
    public Score score;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject Scoretext;
    public GameObject explosion;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(obstacle);
            Destroy(score);
            Scoretext.SetActive(false);
            gameOverUI.SetActive(true);
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
        }

     
    }
    
        
    
}
