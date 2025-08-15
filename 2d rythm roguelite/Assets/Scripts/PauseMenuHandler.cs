using UnityEngine;
using System.Collections;
public class PauseMenuHandler : MonoBehaviour
{
    
   public GameObject PauseMenu;
    private bool isShowing = false;
    
    public void PauseTheMenu(){
        isShowing = !isShowing;
        PauseMenu.SetActive(isShowing);
    }
    
}
