using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;



public class BulletController : MonoBehaviour
{

    private ScoreController scoreController;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(this.transform.forward * 10.0f, ForceMode.Impulse);

        scoreController = GameObject.Find("ScoreManager").GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            scoreController.score += 1;
        }

    }
}
