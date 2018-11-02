using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public UIManager ui;
    public float moveSpeed;
    public spawnScript spawns;
    
    private int moving = 0; //0 = not moving, 1= left, 2= right
    private Vector2 fp;   //First touch position
    private Vector2 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    private Vector3 pos;
    private Vector3 endPos;
    
    

    void Start()
    {
        pos = transform.position;
        endPos = pos;
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
        moveSpeed = 20;
    }

    void Update()
    {

        pos.x = Mathf.Clamp(pos.x, -1.5f, 1.5f);
        transform.position = pos;


        if (Input.touchCount == 1 && moving == 0) // user is touching the screen with a single touch and not moving
        {

            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position

                if (lp.x < fp.x && pos.x > -1.5)
                {   //Left swipe
                    endPos.x -= 1.5f;
                    moving = 1;
                }

                if (lp.x > fp.x && pos.x < 1.5)  //If the movement was to the right and not on the right side
                {   //Right swipe
                    endPos.x += 1.5f;
                    moving = 2;
                }
            }
        }
    
        
        if (moving == 1) //moving left
        {
            
            transform.position = Vector3.MoveTowards(transform.position,endPos,Time.deltaTime * moveSpeed);
            pos = transform.position;
            if (pos.x <= endPos.x)
                moving = 0;

        }

        if (moving == 2)//moving right
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, Time.deltaTime * moveSpeed);
            pos = transform.position;
            if (pos.x >= endPos.x)
                moving = 0;

        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        transform.position = new Vector2(0, -3);
        spawns.SetPlaying(false);
        ui.GameOver();
        gameObject.SetActive(false);
        
    }
}