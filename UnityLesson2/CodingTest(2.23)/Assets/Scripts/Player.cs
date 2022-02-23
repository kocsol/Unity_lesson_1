using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int cubeNum;//선언
    int sceneNum;
    // Start is called before the first frame update
    void Start()
    {        
        cubeNum = 0;//정의        
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                if(hitInfo.collider.tag == "Finish")//Cube의 태그
                {
                    Destroy(hitInfo.collider.gameObject);
                    cubeNum++;
                }
            }
        }

        if(cubeNum == 5)
        {
            if(sceneNum == 0)
            {
                SceneManager.LoadScene(1);
                sceneNum = 1;
                cubeNum = 0;
            }            
            
            else if (sceneNum == 1)
            {
                SceneManager.LoadScene(0);
                sceneNum = 0;
                cubeNum = 0;
            }
        }
    }
}
