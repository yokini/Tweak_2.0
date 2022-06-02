using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed;
    public GameManagerScript gm;
    public RiverTimer rt;

    void Start()
    {
        gm = FindObjectOfType<GameManagerScript>();
        rt = FindObjectOfType<RiverTimer>();
        speed = speed + rt.time;
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (gm.hasWon == true || gm.TimerOngoing == false)
        {
            speed = 0;
        }

        Debug.Log(speed);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "collider")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
