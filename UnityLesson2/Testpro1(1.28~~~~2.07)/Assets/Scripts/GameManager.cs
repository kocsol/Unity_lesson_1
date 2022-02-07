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

    public int enemyNum;//선언 public을 해야 enemy에서 사용가능 private면 사용불가
    // Start is called before the first frame update
    public int playerNum;
    void Start()
    {
        enemyNum = 1;
        playerNum = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyNum == 0)
        {
            enemy = Instantiate(enemyPrefab);
            //enemy라는 게임오브젝트의 위치는 3차원 벡터값으로 -0.5 0.15 10의 위치이다.
            enemy.transform.position = new Vector3(-0.5f, 0.15f, 10);
            //enemy라는 게임오브젝트의 회전값은 3차원 벡터값으로 0 180 0의 회전값이다.
            enemy.transform.rotation = Quaternion.Euler(0, 180, 0);
            enemyNum = 1;

            //1p화면에 win이 뜬다. -> 1p의 화면에 win이라느 ㄴText가 뜨게 한다.
            //1p를 찾는다. -->1p안에 있는(child) 캔버스를 찾는다. -> 긍 안에 있는 Text를 찾아서 변수화하고 이름을 win으로 수정한다.
            playerResultText = GameObject.Find("Player(Clone)/Canvas/ResultText").GetComponent<Text>() ;
            playerResultText.text = "Win";

            //2p화면에 lose가 뜬다. -> 2p의 화면에 lose라는 Text가 뜬다.
            enemyResultText = GameObject.Find("Enemy(Clone)/Canvas/ResultText").GetComponent<Text>();
            enemyResultText.text = "Lose";
        }
        if (playerNum == 0)
        {
            player = Instantiate(playerPrefab);
            //player라는 게임오브젝트의 위치는 3차원 벡터값으로 0 0.15 0의 위치이다.
            player.transform.position = new Vector3(0, 0, 0);
            //player라는 게임오브젝트의 회전값은 3차원 벡터값으로 0 0 0의 회전값이다.
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
            playerNum = 1;

           
            playerResultText = GameObject.Find("Player(Clone)/Canvas/ResultText").GetComponent<Text>();
            playerResultText.text = "Lose";

          
            enemyResultText = GameObject.Find("Enemy(Clone)/Canvas/ResultText").GetComponent<Text>();
            enemyResultText.text = "Win";
        }
    }
}
