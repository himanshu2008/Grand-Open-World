using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam, secondCam, credLeadDes;

    void Start()
    {
        StartCoroutine(CamSwitcher());
    }

    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(3);
        credLeadDes.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
    }
}