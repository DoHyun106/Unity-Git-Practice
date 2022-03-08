using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramEscape : MonoBehaviour
{
    public GameObject screanEscape, escapeYes, escapeNo; // ��ǥ ������Ʈ [ ���� â(�г�) , "��" ��ư, "�ƴϿ�" ��ư ]


    private void Update()
    {
        // ESC ������ ���� �޽��� Ȱ��ȭ
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            activeEscape();
        }
    }

    public void activeEscape()  // ���� �޽���
    {
        Debug.Log("Active Escape Screen");  // ����� " ���� �޽��� â Ȱ��ȭ "

        Time.timeScale = 0f;    // �帣�� �ð� 0���� �ؼ� �Ͻ����� Ȱ��ȭ
        screanEscape.SetActive(true);   // ���� �޽��� â Ȱ��ȭ
    }

    public void escapeYesButton()   // ���� ��ư
    {
        Application.Quit(); // ���α׷� ����
    }

    public void escapeNoButton()    // ���� ���
    {
        screanEscape.SetActive(false);  // ���� �޽��� â ��Ȱ��ȭ
        Time.timeScale = 1f;    // �帣�� �ð� 1�� �ؼ� �Ͻ����� ����
    }
}
