using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(this.transform.forward * 10.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
