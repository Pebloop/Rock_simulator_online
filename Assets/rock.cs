using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x = Random.Range(-20, 20);
        pos.z = Random.Range(-20, 20);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
