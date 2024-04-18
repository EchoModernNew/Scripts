using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    // Start is called before the first frame update
    public int Heath = 5;
    public int Speed = 3;
    public int Level = 1;
   
    void Start()
    {
        print(Heath += Level);
    }

    // Update is called once per frame
    void Update()
 {
        Vector3 newPosition = transform.position;
        newPosition.x -= Speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
