using UnityEngine;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public GameObject completeRegister;
    public InputField codeInput;
    public void LoadNextPanel()
    {
        if (codeInput.text == "12345")
        {
            completeRegister.SetActive(true);
        }
        else { Debug.Log("Code is wrong"); }
    }    
}