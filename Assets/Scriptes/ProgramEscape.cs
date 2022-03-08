using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramEscape : MonoBehaviour
{
    public GameObject screanEscape, escapeYes, escapeNo; // ��ǥ ������Ʈ


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
        if (screanEscape != null)    // ���� �޽��� â �ִٸ�
        {
            Debug.Log("Active Escape Screen");  // ����� " ���� �޽��� â Ȱ��ȭ "

            Time.timeScale = 0f;    // �Ͻ����� Ȱ��ȭ
            screanEscape.SetActive(true);   // ���� �޽��� â Ȱ��ȭ
        }
    }

    public void escapeYesButton()   // ���� ��ư
    {
        Application.Quit(); // ���α׷� ����
    }

    public void escapeNoButton()    // ���� ���
    {
        screanEscape.SetActive(false);  // ���� �޽��� â ��Ȱ��ȭ
        Time.timeScale = 1f;    // �Ͻ����� ����
    }
}
