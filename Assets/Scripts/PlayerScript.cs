using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public GameManagerScript gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<GameManagerScript>();
     
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY);
    }

    private void FixedUpdate()
    {
        rb.velocity = playerDirection * playerSpeed;
    }

    void OnDestroy()
    {
        Debug.Log("Dead");
        gm.OnPlayerDestroyed();
    }
}
