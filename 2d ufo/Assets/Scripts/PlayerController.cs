using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("horizontal");
        float moveVertical = Input.GetAxis("vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
