using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAttack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float timebtwattack;
    public float starttimebtwattack;
    [SerializeField]
    Animator animator;

    public float attackrange= 0.5f;
    public Transform attackpoint;
    public LayerMask enemylayer;
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
            Collider2D[] hitenemies =Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayer);
            foreach( Collider2D hitenemy in hitenemies)
            {
                Debug.Log($"We hit {hitenemy.gameObject.name}");
            }    
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
