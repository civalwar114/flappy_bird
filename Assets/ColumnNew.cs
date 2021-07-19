using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnNew : MonoBehaviour {
    public GameControlNew gameControl;
    Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {

        gameControl = FindObjectOfType<GameControlNew>();

        rb2D = GetComponent<Rigidbody2D>();

        rb2D.velocity = new Vector2(-2, 0);

	}
	
	// Update is called once per frame
	void Update () {

        if (gameControl.gameOver == true)
        {
            rb2D.velocity = Vector2.zero;


        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bird>() != null)
        {

            gameControl.BirdSocred();

        }

    }


}
