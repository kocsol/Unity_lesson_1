using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject enemy;
    public GameObject enemyPrefab;

    public int enemyNum;//선언 public을 해야 enemy에서 사용가능 private면 사용불가
    // Start is called before the first frame update
    void Start()
    {
        enemyNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyNum == 0)
        {
            enemy = Instantiate(enemyPrefab);
            enemyNum = 1;
        }
    }
}
