using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicToggle : MonoBehaviour
{
    // Toggle Switch Graphic Set
    public void selectGraphicSet(bool isOn)
    {
        if(isOn)
        {
            Debug.Log("toggle Graphic [ High ]");
            QualitySettings.SetQualityLevel(3, true);
            Application.targetFrameRate = 60;
            Debug.Log("Graphic Quility Level set 3");
        }
        else
        {
            Debug.Log("toggle Graphic [ Low ]");
            QualitySettings.SetQualityLevel(1, true);
            Application.targetFrameRate = 30;
            Debug.Log("Graphic Quility Level set 1");
        }
    }
}
