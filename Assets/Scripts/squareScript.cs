using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareScript : MonoBehaviour {

    private int moveSpeed;
    
    public void SetMoveSpeed(int speed)
    {
        moveSpeed = speed;
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);

        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
	}
}
