using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSetting : MonoBehaviour
{
    public GameObject screanSet;    // ���� â,

    // ���� â ����
    public void openSetWindow()
    {
        screanSet.SetActive(true);
        Time.timeScale = 0f;

        Debug.Log("Activate true [screanSet]");
    }

    //���� â �ݱ�
    public void cloaseSetWindow()
    {
        screanSet.SetActive(false);
        Time.timeScale = 1f;

        Debug.Log("Activate false [screanSet]");
    }
    // ������ ���� ����
    // ȿ���� ���� ����
    // ����� ���� ����
    // �޴� ȿ���� ���� ����
    // �׷��� ���� / ����� ����
    // ũ���� ȭ�� �̵�
    // ���α׷� ����
}
