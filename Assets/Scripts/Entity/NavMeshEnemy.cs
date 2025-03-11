using UnityEngine;
using UnityEngine.AI;

public class NavMeshEnemy : Entity
{
    protected NavMeshAgent agent;
    protected Transform playerTarget;
    int maxHealth = 10;

    public override void Die()
    {
        base.Die();

        //TODO: play animations here
        
    }

    public override void TakeHit(int damage)
    {
        base.TakeHit(damage);

        //TODO: play animations here
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTarget = GameObject.Find("Player").transform;
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false; //this may be needed for looking towards player
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTarget != null)
        {
           agent.SetDestination(playerTarget.position);
        }
    }

}
