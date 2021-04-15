using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvases_Arrangement : MonoBehaviour
{
    //public Canvas help_panel_canvas;
    //public Canvas main_menu_canvas;
    public List<Canvas> canvases;
    //string key = "First", value = "True";
    
    private void Awake()
    {
        // Get_Menu_Canvas();
        Show_Menu_Canvas();
        // Show help panel for the first time.
        /*
        if (PlayerPrefs.HasKey(key))
        {
            help_panel_canvas.enabled = false;
            
        }
        else 
        {
            Show_Menu_Canvas();
            help_panel_canvas.enabled = true;
            PlayerPrefs.SetString(key, value);
        }
        */
    }


    /*
    private void Get_Menu_Canvas()
    {        
        canvases.AddRange(FindObjectsOfType<Canvas>());     
        foreach (Canvas item in canvases)
        {
            if (item.name == "Canvas_Main_Menu")
            { 
                main_menu_canvas = item;
                canvases.Remove(item);
                break;
            }
        }
    }
    */


    private void Show_Menu_Canvas()
    {
        canvases.AddRange(FindObjectsOfType<Canvas>());
        //main_menu_canvas.enabled = true;
        foreach (Canvas item in canvases)
        {
            if (item.name == "Canvas_Main_Menu")
            {
                item.enabled = true;
            }
            else
            {
                item.enabled = false;
            }
        }
    }
}