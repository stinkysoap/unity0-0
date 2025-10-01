using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float timebtwattack;
    public float starttimebtwattack;
    [SerializeField]
    Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            animator.SetTrigger("Attck");
        }
        
    }
}
