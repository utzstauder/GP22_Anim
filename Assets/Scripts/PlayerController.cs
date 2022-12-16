using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("action");
        }
        
        animator.SetFloat("horizontal", horizontal);
        animator.SetFloat("vertical", vertical);
    }
}
