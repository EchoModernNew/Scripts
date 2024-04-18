using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndCri : MonoBehaviour
{
    public float delay = 5;
    void Update()
    {
        print("Crikets");
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());

        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    // Update is called once per frame
    
}
