using UnityEngine;

public class UIManager1 : MonoBehaviour {
    public GameManager gameManager; // Reference to GameManager

    public void OnSelectRobot() {
        gameManager.SelectCharacter(0); // Activate Robot
    }

    public void OnSelectNinja() {
        gameManager.SelectCharacter(1); // Activate Ninja
    }

    public void OnSelectZombie() {
        gameManager.SelectCharacter(2); // Activate Zombie
    }

    
    public void OnResetToIdle() {
        gameManager.ResetToIdleState(); // Return to idle state and play background music
    }
}

