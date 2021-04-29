using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTLTMPro;
using UnityEngine.UI;
public class Turn_Off_Buttons : MonoBehaviour
{
    public List<GameObject> frames;
    public List<RTLTextMeshPro> tmps;

    void Start()
    {
        foreach (GameObject item in frames)
        {
            item.GetComponent<Image>().enabled = false;
        }
        foreach (RTLTextMeshPro item in tmps)
        {
            item.color = new Color32(241, 121, 70, 255);
        }
    }
}
