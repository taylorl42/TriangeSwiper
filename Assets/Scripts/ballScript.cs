using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

    public bool hitBoundary;

    private int moveSpeed;
    

	// Use this for initialization
	void Start () {
        moveSpeed = 7;
    }
    
	// Update is called once per frame
	void Update () {

        if (gameObject.transform.position.x > 2.5 || gameObject.transform.position.x < -2.5)
            hitBoundary = !hitBoundary;


        if(hitBoundary == false)
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        if (hitBoundary == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }

    public void SetMoveSpeed(int speed)
    {
        moveSpeed = speed;
    }
}
