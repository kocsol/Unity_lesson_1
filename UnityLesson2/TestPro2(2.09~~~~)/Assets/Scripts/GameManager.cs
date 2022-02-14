using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject enemy;
    public GameObject enemyPrefab;
    Text enemyResultText;

    private GameObject player;
    public GameObject playerPrefab;
    Text playerResultText;

    public int enemyNum;//선언
    public int playerNum;//선언
    // Start is called before the first frame update
    void Start()
    {
        enemyNum = 1;//정의
        playerNum = 1;//정의
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyNum == 0)//enemy라는 게임오브젝트의 숫자가 0일때
        {
            enemy = Instantiate(enemyPrefab);//enemy라는 게임오브젝트를 하나 만들어라

            //enemy라는 게임오브젝트의 위치는 3차원 벡터값으로 -0.5, 0.15, 10의 위치이다.
            enemy.transform.position = new Vector3(-0.5f, 0.15f, 10);

            //enemy라는 게임오브젝트의 회전값은 3차원 벡터값으로 0, 180, 0의 회전값이다.
            enemy.transform.rotation = Quaternion.Euler(0, 180, 0);

            enemyNum = 1;//enemy라는 게임오브젝트의 숫자는 1이다.

            //1P의 화면에 Win이 뜬다 -> 1P의 화면에서 Win이라는 Text가 뜨게 만든다.            
            playerResultText = GameObject.Find("Player(Clone)/Canvas/ResultText").GetComponent<Text>();
            playerResultText.text = "Win";

            //2P의 화면에는 Lose가 뜬다 -> 2P의 화면에서 Lose라는 Text가 뜨게 만든다.
            enemyResultText = GameObject.Find("Enemy(Clone)/Canvas/ResultText").GetComponent<Text>();
            enemyResultText.text = "Lose";
        }

        if (playerNum == 0)//player라는 게임오브젝트의 숫자가 0일때
        {
            player = Instantiate(playerPrefab);//player라는 게임오브젝트를 하나 만들어라

            //player라는 게임오브젝트의 위치는 3차원 벡터값으로 -0.5, 0.15, 10의 위치이다.
            player.transform.position = new Vector3(0, 0, 0);

            //player라는 게임오브젝트의 회전값은 3차원 벡터값으로 0, 180, 0의 회전값이다.
            player.transform.rotation = Quaternion.Euler(0, 0, 0);

            playerNum = 1;//player라는 게임오브젝트의 숫자는 1이다.
                                  
            playerResultText = GameObject.Find("Player(Clone)/Canvas/ResultText").GetComponent<Text>();
            playerResultText.text = "Lose";
                        
            enemyResultText = GameObject.Find("Enemy(Clone)/Canvas/ResultText").GetComponent<Text>();
            enemyResultText.text = "Win";
        }
    }
}
