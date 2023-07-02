using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartParticle : MonoBehaviour
{
    public GameObject particleObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy") //Object�^�O�̕t�����Q�[���I�u�W�F�N�g�ƏՓ˂���������
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
            Destroy(this.gameObject); //�Փ˂����Q�[���I�u�W�F�N�g���폜
        }
    }
}