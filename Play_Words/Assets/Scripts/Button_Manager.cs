using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RTLTMPro;

public class Button_Manager : MonoBehaviour
{
    //public GameObject current_button;
    public List<GameObject> other_buttons;

    public void Choose_Button(GameObject current_button)
    {
        // Turn on the current button frame and change the color        
        GameObject current_button_child = current_button.transform.GetChild(0).gameObject;
        RTLTextMeshPro current_button_text = current_button_child.GetComponent<RTLTextMeshPro>();
        current_button_text.color = new Color32(247, 82, 53, 255);

        current_button.GetComponent<Image>().enabled = true;        

        foreach (GameObject item in other_buttons)
        {
            if (item.name != current_button.name)
            {
                // Turn of frames
                item.GetComponent<Image>().enabled = false;
                // Change the color
                GameObject item_child = item.transform.GetChild(0).gameObject;
                RTLTextMeshPro item_text = item_child.GetComponent<RTLTextMeshPro>();
                item_text.color = new Color32(241, 121, 70, 255);
            }
        }
    }
}