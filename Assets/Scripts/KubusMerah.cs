using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KubusMerah : MonoBehaviour
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
                TextMesh merah = GameObject.Find("Ini Kubus Merah").GetComponent<TextMesh>();
                merah.text = "Ini Kubus Merah";
            }
        }   
    }

    public void textCubeRedON(){
        gvrStatus = true;
    }

    public void textCubeRedOFF() {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
        TextMesh merah = GameObject.Find("Ini Kubus Merah").GetComponent<TextMesh>();
        merah.text = "";
    }
}
