using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetScript : MonoBehaviour
{
    // ���� �ȳ� ������Ʈ
    public GameObject escapeMassage, escapeYes, escapeNo;
    // ���� �г� ������Ʈ
    public GameObject userSetPanel;
    // ����� �ͼ�
    public AudioMixer audioMixer;
    // ����� �����̴� ��Ʈ�� ������Ʈ
    public Slider sliderMaster, sliderBGM, sliderSFX, sliderMenuSFX;

    // UserSet Funtion  ############################################
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            openUserSetPanel();
        }
    }
    public void openUserSetPanel()
    {
        Time.timeScale = 0f;
        userSetPanel.SetActive(true);
    }
    public void closeUserSetPanel()
    {
        userSetPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    
    // Audio Control Funtion    ##################################################
    public void audioMasterControl()    // Master Aduio
    {
        float volume = sliderMaster.value;

        if(volume == -40f)  // �����̴� ���� -40 �̸� �Ҹ����� -80�� ���� (���Ұ�)
        {
            audioMixer.SetFloat("Master", -80);
        }
        else
        {
            audioMixer.SetFloat("Master", volume);
        }
    }
    public void audioBGMControl()   // BGM Audio
    {
        float volume = sliderBGM.value;

        if(volume == -40f)
        {
            audioMixer.SetFloat("BGM", -80);
        }
        else
        {
            audioMixer.SetFloat("BGM", volume);
        }
    }
    public void audioSFXControl()   // SFX Aduio
    {
        float volume = sliderSFX.value;

        if (volume == -40f)
        {
            audioMixer.SetFloat("SFX", -80);
        }
        else
        {
            audioMixer.SetFloat("SFX", volume);
        }
    }
    public void audioMenuSFXControl()   // MenuSFX Audio
    {
        float volume = sliderSFX.value;

        if (volume == -40f)
        {
            audioMixer.SetFloat("SFX", -80);
        }
        else
        {
            audioMixer.SetFloat("SFX", volume);
        }
    }

    // Escape Funtion   #######################################################
    public void openEscapeMassage()
    {
        escapeMassage.SetActive(true);
    }
    public void executeEscape()
    {
        Application.Quit();
    }

    public void unexcuteEscape()
    {
        escapeMassage.SetActive(false);
    }

    // Graphic Funtion  #########################################################
}
