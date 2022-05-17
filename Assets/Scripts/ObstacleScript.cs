using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
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
