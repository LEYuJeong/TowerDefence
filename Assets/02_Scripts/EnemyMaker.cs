using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float currentTime;
    public float spawnCoolTime = 2.0f;
    public float enemyCount = 0;
    public float enemyMaxCount = 3.0f;

    public bool isRunning = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (isRunning)
        {

        }
    }

    // ���� ���� Enemy ���� �ʱ�ȭ
    public void InitEnemyMaker()
    {

    }
}
