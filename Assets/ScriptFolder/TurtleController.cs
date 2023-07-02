using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 追加
using UnityEngine.AI;
public class TurtleController : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    private int life = 5;

    private float time = 0;

    private ScoreController scoreController;

    // AudioClip再生用
    public AudioClip damageSound;
    public AudioClip downSound;
    AudioSource audioSource;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
        scoreController = GameObject.Find("ScoreManager").GetComponent<ScoreController>();

        // AudioSourceコンポーネント取得
        audioSource = GetComponent<AudioSource>();
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
        if (other.gameObject.tag == "Bullet")
        {
            life--;

            if (life <= 0)
            {
                audioSource.PlayOneShot(downSound);
                GetComponent<NavMeshAgent>().isStopped = true;
                GetComponent<Animator>().SetTrigger("Die");
                scoreController.score += 3;
            }
            else
            {
                audioSource.PlayOneShot(damageSound);
                GetComponent<Animator>().SetTrigger("Damage");
            }

        }
    }
}
