using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    int health;
    int damage;
    public Text hpText;
    public Image hpBar;
    public GameObject enemy;//선언

    public EnemyManager _enemyManager; // 선언
    // Start is called before the first frame update
    void Start()
    {
        _enemyManager = FindObjectOfType<EnemyManager>();//사용
        health = 100;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);//적은 없애고
            //새로운 적을 하나 더 만들어주세요.
            _enemyManager.enemyNum = 0;//사용
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {            
            health = health - damage;
            hpText.text = "hp :" + health;
            float myHP = (float)(0.01f * health);
            hpBar.fillAmount = myHP;
            Destroy(other.gameObject);
        }
    }
}
