using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform : MonoBehaviour
{
    [SerializeField] GameObject detect, door;

    bool isOnPlatformDeteced;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //door.GetComponent<MoveToLocation>().enabled = true;
        if(isRedCubeDetected && isBlueCubeDeteced){
            areBothCubesDetected = true;
        }
        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blueCube.gameObject)
        {
            isOnPlatformDeteced = true;
        }
    }
}
