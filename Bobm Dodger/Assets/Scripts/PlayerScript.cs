using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed = 10f;

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

        transform.position = currentPosition;
    }

} // end PlayerScript
