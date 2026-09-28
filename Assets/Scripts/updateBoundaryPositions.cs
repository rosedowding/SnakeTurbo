using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateBoundaryPositions : MonoBehaviour
{

    //Attach this only to the upper and lower boundaries!!!

    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        //Stores the correct position for the boundary
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
        //Resets the boundary position to the correct position. Without this it is possible for the player to push the boundary and go out-of-bounds
    }
}
