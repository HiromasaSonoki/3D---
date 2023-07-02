using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;



public class BulletController : MonoBehaviour
{

    private ScoreController scoreController;
    // Start is called before the first frame update

    // �o�ߎ���
    private float time;

    
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(this.transform.forward * 10.0f, ForceMode.Impulse);

        scoreController = GameObject.Find("ScoreManager").GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        // �O�t���[������̎��Ԃ����Z���Ă���
        time = time + Time.deltaTime;

        if (time > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
           // Destroy(other.gameObject);
            Destroy(this.gameObject);
           
        }

    }
}
