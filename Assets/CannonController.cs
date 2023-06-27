using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    //プレハブ
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0.0f, -30.0f * Time.deltaTime, 0.0f, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0.0f, 30.0f * Time.deltaTime, 0.0f, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, this.transform.position + new Vector3(0.0f, 2.5f, 0.0f), this.transform.rotation);
        }
    }
}