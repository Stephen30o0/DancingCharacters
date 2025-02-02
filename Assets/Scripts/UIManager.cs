using UnityEngine;
using UnityEngine.UI; // For UI components (if needed)
using UnityEngine.SceneManagement; // For scene transitions

public class UIManager : MonoBehaviour {
    // Reference all animators
    public Animator mainMenuAnim;
    public Animator settingsAnim;
    public Animator creditsAnim;

    public void ShowMainMenu() {
        settingsAnim.SetTrigger("HideSettings");
        creditsAnim.SetTrigger("HideCredits");
        mainMenuAnim.SetTrigger("ShowMain");
    }

    public void ShowSettings() {
        mainMenuAnim.SetTrigger("HideMain");
        settingsAnim.SetTrigger("ShowSettings");
    }

    public void ShowCredits() {
        mainMenuAnim.SetTrigger("HideMain");
        creditsAnim.SetTrigger("ShowCredits");
    }
}