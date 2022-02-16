using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class MediaPlay : MonoBehaviour
{
    public AudioSource audio; // 선언
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           video.Play(); // play함수는 AudioSource 내에 있는 함수 중 하나인데 오디오 클립을 재생할 수 있다.
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            video.Pause();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            video.Stop();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
                   
        }

    }
}
