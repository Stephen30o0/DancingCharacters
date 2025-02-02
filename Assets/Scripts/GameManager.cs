using UnityEngine;

public class GameManager : MonoBehaviour {
    // Variables
    public GameObject[] characters;
    public AudioController audioController;
    private int activeCharacterIndex = -1;

    // Character selection
    public void SelectCharacter(int index) {
        if (index == activeCharacterIndex) return;

        audioController.StopBackgroundMusic();
        ResetAllCharacters();
        
        activeCharacterIndex = index;
        characters[index].GetComponent<MyCharacterController>().SetActive(true);
        audioController.PlayCharacterSong(index);
    }

    // Reset all characters
    private void ResetAllCharacters() {
    foreach (var character in characters) {
        var controller = character.GetComponent<MyCharacterController>();
        if (controller != null) {
            // Force immediate reset
            controller.SetActive(false);
            
            // Additional safeguard
            Animator anim = character.GetComponent<Animator>();
            anim.Play("Idle");
            anim.Update(0); // Force immediate update
        }
    }
}

    // Full system reset
    public void ResetToIdleState() {
        ResetAllCharacters();
        audioController.ResetToIdleState();
        activeCharacterIndex = -1;
    }
} 