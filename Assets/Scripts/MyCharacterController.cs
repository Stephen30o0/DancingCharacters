using UnityEngine;

public class MyCharacterController : MonoBehaviour {
    public Animator animator;
    private bool isActive = false;

    public void SetActive(bool active) {
        isActive = active;
        
        if (active) {
            // Start with first dance animation
            animator.SetInteger("animationIndex", 1);
            animator.SetBool("isDancing", true);
        } else {
            // Force reset using both parameters and cross-fade
            animator.SetInteger("animationIndex", 0);
            animator.SetBool("isDancing", false);
            animator.CrossFade("Idle", 0.1f); // Match your idle state name
        }
    }

    void Update() {
        if (!isActive) return;

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) {
            int newIndex = animator.GetInteger("animationIndex") + 1;
            animator.SetInteger("animationIndex", newIndex > 3 ? 1 : newIndex);
        }
    }
}