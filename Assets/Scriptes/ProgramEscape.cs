using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramEscape : MonoBehaviour
{
    public GameObject screanEscape, escapeYes, escapeNo; // 목표 오브젝트


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
        if (screanEscape != null)    // 종료 메시지 창 있다면
        {
            Debug.Log("Active Escape Screen");  // 디버그 " 종료 메시지 창 활성화 "

            Time.timeScale = 0f;    // 일시정지 활성화
            screanEscape.SetActive(true);   // 종료 메시지 창 활성화
        }
    }

    public void escapeYesButton()   // 종료 버튼
    {
        Application.Quit(); // 프로그램 종료
    }

    public void escapeNoButton()    // 종료 취소
    {
        screanEscape.SetActive(false);  // 종료 메시지 창 비활성화
        Time.timeScale = 1f;    // 일시정지 해제
    }
}
