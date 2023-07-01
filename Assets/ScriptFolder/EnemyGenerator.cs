using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject1")]
    private GameObject slimePrefab;

    [SerializeField]
    [Tooltip("��������GameObject2")]
    private GameObject turtlePrefab;


    // �o�ߎ���
    private float time;


    // Update is called once per frame
    void Update()
    {
        // �O�t���[������̎��Ԃ����Z���Ă���
        time = time + Time.deltaTime;

        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (time > 3.0f)
        {
            int enemyNumber = Random.Range(1, 100);
            int areaNumber = Random.Range(1, 4);
            if (1 <= enemyNumber && enemyNumber <= 85)
            {
                if (areaNumber == 1)
                {


                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(10, 30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(10, 30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else if (areaNumber == 2)
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(-10, -30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(10, 30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else if (areaNumber == 3)
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(10, 30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(-10, -30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
                else
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(-10, -30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(-10, -30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(slimePrefab, new Vector3(x, 7, z), slimePrefab.transform.rotation);
                }
            }
            else
            {
                if (areaNumber == 1)
                {


                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(10, 30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(10, 30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else if (areaNumber == 2)
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(-10, -30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(10, 30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else if (areaNumber == 3)
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(10, 30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(-10, -30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
                else
                {
                    // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float x = Random.Range(-10, -30);

                    // rangeA��rangeB��z���W�͈͓̔��Ń����_���Ȑ��l���쐬
                    float z = Random.Range(-10, -30);


                    // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                    Instantiate(turtlePrefab, new Vector3(x, 7, z), turtlePrefab.transform.rotation);
                }
            }
            // �o�ߎ��ԃ��Z�b�g
            time = 0f;
        }
    }
}
