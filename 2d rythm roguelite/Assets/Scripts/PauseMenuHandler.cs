using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PauseMenuHandler : MonoBehaviour
{
    
    public Canvas PauseMenuCanvas;
    private bool isShowing = false;
    
    public void HidePauseMenu()
    {
        PauseMenuCanvas.enabled = false;
        isShowing = false;
    }
    
    public void PauseTheMenu(){
        PauseMenuCanvas.enabled = !isShowing;
        isShowing = !isShowing;
    }

 
}
