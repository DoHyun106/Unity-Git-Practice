using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramEscape : MonoBehaviour
{
    public GameObject screanEscape, escapeYes, escapeNo; // 목표 오브젝트 [ 종료 창(패널) , "네" 버튼, "아니요" 버튼 ]


    private void Update()
    {
        // ESC 눌러서 종료 메시지 활성화
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            activeEscape();
        }
    }

    public void activeEscape()  // 종료 메시지
    {
        Debug.Log("Active Escape Screen");  // 디버그 " 종료 메시지 창 활성화 "

        Time.timeScale = 0f;    // 흐르는 시간 0으로 해서 일시정지 활성화
        screanEscape.SetActive(true);   // 종료 메시지 창 활성화
    }

    public void escapeYesButton()   // 종료 버튼
    {
        Application.Quit(); // 프로그램 종료
    }

    public void escapeNoButton()    // 종료 취소
    {
        screanEscape.SetActive(false);  // 종료 메시지 창 비활성화
        Time.timeScale = 1f;    // 흐르는 시간 1로 해서 일시정지 해제
    }
}
