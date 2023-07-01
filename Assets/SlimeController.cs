using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ’Ç‰Á
using UnityEngine.AI;
public class SlimeController : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    private int life = 3;

    private float time = 0;

    private ScoreController scoreController;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
        scoreController = GameObject.Find("ScoreManager").GetComponent<ScoreController>();
    }

    void Update()
    {
       
       

        if (life <= 0)
        {
            time = time + Time.deltaTime;

            if (time > 1.5f)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            life--;

            if(life <= 0)
            {
                GetComponent<NavMeshAgent>().isStopped = true;
                GetComponent<Animator>().SetTrigger("Die");
                scoreController.score += 1;
            }
            else
            {
                GetComponent<Animator>().SetTrigger("Damage");
            }
            
        }
    }
}
