using UnityEngine;

public class enemy : MonoBehaviour
{
    public int maxhealth=100;
    
    int currenthealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenthealth=maxhealth;
        
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0)
        {
            die();
        }
    }

    public void die()
    {
        Destroy(gameObject);
    }
    
}

