using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSetting : MonoBehaviour
{
    public GameObject screanSet;    // 셋팅 창,

    // 설정 창 열기
    public void openSetWindow()
    {
        screanSet.SetActive(true);
        Time.timeScale = 0f;

        Debug.Log("Activate true [screanSet]");
    }

    //설정 창 닫기
    public void cloaseSetWindow()
    {
        screanSet.SetActive(false);
        Time.timeScale = 1f;

        Debug.Log("Activate false [screanSet]");
    }
    // 마스터 음량 조절
    // 효과음 음량 조절
    // 배경음 음량 조절
    // 메뉴 효과음 음량 조절
    // 그래픽 고사양 / 저사양 선택
    // 크레딧 화면 이동
    // 프로그램 종료
}
