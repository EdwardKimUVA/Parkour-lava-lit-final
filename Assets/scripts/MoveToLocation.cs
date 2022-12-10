using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation : MonoBehaviour
{
    [SerializeField] GameObject destinationObject;

    Vector3 startPosition;
    [SerializeField] float moveSpeed;
    float moveAmount;

    // DIRECTIONS: Nothing needs to change in this script, but you might want to 
    // examine it just out of curiosity to learn about LERP methods for your own use... 

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

    }
}
