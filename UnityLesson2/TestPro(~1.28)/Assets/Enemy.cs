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
    public GameObject enemy;    // 선언
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)    
        {
            Destroy(this.gameObject); //적을 없에고
            //새로운 것을 하나 더 만들어 주세요.
            Instantiate(enemy);

        }
    }
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")//내가 부딪힌 것이 총알이라면
        {
            health = health - damage;
            hpText.text = "hp :" + health;
            float myHp = (float)(0.01f * health); 
            hpBar.fillAmount = myHp;
        }   
    }
}
