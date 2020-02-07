using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;
    public GameObject gameOver;
    public GameObject rstButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position; //x,y Axis

        if (h>0)
        {
            //going to the right side
            currentPosition.x += speed * Time.deltaTime;
            
        }
        else if(h<0)
        {
            //going to the left side
            currentPosition.x -= speed * Time.deltaTime;
        }

        if (currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }

        if (currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            gameOver.gameObject.SetActive(true);
            rstButton.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

} // end PlayerScript
