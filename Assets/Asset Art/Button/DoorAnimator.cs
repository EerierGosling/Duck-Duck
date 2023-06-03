using UnityEngine;
using UnityEngine.UI;

public class DoorAnimator : MonoBehaviour
{
    private Animator animator;
    public GameObject Button;
    private BoxCollider2D boxCollider;

    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
       
        if (buttonScript.buttonPressed)
        {
            animator.SetTrigger("YourAnimationTrigger");
            boxCollider.enabled = false;

        }
    }

}
