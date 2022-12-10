using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavarise : MonoBehaviour
{
    [SerializeField] GameObject destinationObject;

    Vector3 startPosition;
    [SerializeField] float moveSpeed;
    float moveAmount;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        moveAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Lerp means "linear interpolation"-- it figures out the number between two numbers based 
        // on a percentage from 0 to 1, e.g. Lerp(2,4,.5f) = 3 because 3 is halfway between 2 and 4.
        // Lerp methods can be done to floats, Vectors, and a few other values
        transform.position = Vector3.Lerp(startPosition, destinationObject.transform.position, moveAmount);

        moveAmount += moveSpeed;// We increase the moveAmount based on the moveSpped, and therefore 
        // change the position in the Lerp method above on the next Update() cycle

        // NOTE: Uncomment the four code lines below, and change what is inside the "if statement" to make this work
        // You should NOT write any new lines of code-- just change what is inside the "if statement"
        //Vector3.Distance(transform.position,destinationObject.transform.position) <= 0
        if (moveAmount >= 1)
        {
            moveSpeed = 0;
        }
    }

}
