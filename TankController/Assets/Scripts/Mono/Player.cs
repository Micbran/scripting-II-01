using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    private int currentHealth;

    TankController tankController;

    private void Awake()
    {
        tankController = GetComponent<TankController>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        
    }


    public void IncreaseHealth(int amount)
    {
        this.currentHealth = Mathf.Clamp(this.currentHealth + amount, 0, this.maxHealth);
        Debug.Log("Player's Health: " + this.currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        this.currentHealth = Mathf.Clamp(this.currentHealth - amount, 0, this.maxHealth);
        Debug.Log("Player's Health: " + this.currentHealth);
        if (this.currentHealth <= 0)
        {
            this.Kill();
        }
    }

    public void Kill()
    {
        this.gameObject.SetActive(false);
        // fire kill events
    }
}
