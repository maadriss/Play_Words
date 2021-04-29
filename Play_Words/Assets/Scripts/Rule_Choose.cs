using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Rule_Choose : MonoBehaviour
{
    public List<GameObject> frames;
    public List<TextMeshProUGUI> tmps;
    public GameObject this_frame;
    public TextMeshProUGUI this_tmp;
    // Attach this script to buttons and change the values
    
    public void Change_Parameters()
    {
        // Turn off other buttons frame and color
        foreach (GameObject item in frames)
        {
            item.GetComponent<Image>().enabled = false;
        }
        foreach (TextMeshProUGUI item in tmps)
        {
            // Light orange (r:241,g:121,b:70);
            item.color = new Color32(241, 121, 70, 255);
        }
        // Turn on this frame and color
        this_frame.GetComponent<Image>().enabled = true;
        // Dark orange(r: 247, g: 82, b: 53, a: 255)
        this_tmp.color = new Color32(247, 82, 53, 255);
    }
}