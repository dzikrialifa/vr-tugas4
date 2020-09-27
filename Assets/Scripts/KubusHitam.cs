using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KubusHitam : MonoBehaviour
{
    public Image imgCircle;
    
    public float totalTime = 1;
    bool gvrStatus;
    public float gvrTimer;

    void Update()
    {
        if(gvrStatus) {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
            if(imgCircle.fillAmount == 1) {
                TextMesh hitam = GameObject.Find("Ini Kubus Hitam").GetComponent<TextMesh>();
                hitam.text = "Ini Kubus Hitam";
            }
        }   
    }

    public void textCubeBlackON() {
        gvrStatus = true;
    }

    public void textCubeBlackOFF() {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
        TextMesh hitam = GameObject.Find("Ini Kubus Hitam").GetComponent<TextMesh>();
        hitam.text = "";
    }
}
