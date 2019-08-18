using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Vector2 jumpForce = new Vector2(0, 300);
    Rigidbody2D myPlayer;
    // Use this for initialization
    void Start () {
        myPlayer = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space"))
        {
            //for mobile Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended;
            myPlayer.velocity = Vector2.zero;
            myPlayer.AddForce(jumpForce);
        }

        //Die by being OffMeshLink screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        Die();

    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
