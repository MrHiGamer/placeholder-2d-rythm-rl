using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsPageHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Canvas CreditsCanvas;
    private bool isShowing = false;

    public void HideCredits()
    {
        CreditsCanvas.enabled = false;
        isShowing = false;
    }

    public void ShowCredits()
    {
        CreditsCanvas.enabled = !isShowing;
        isShowing = !isShowing;
    }
}