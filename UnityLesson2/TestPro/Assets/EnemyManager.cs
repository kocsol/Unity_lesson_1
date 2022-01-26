using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject enemy;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy"); //enemy가 있는지
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)//텅비었다 ,없다
        {
            enemy = Instantiate(enemyPrefab);

        }
    }
}
