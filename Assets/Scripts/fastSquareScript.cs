using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastSquareScript : MonoBehaviour {

    private int moveSpeed;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 16;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);

        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
}
