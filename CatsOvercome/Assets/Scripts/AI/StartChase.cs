using UnityEngine;
using System.Collections;

public class StartChase : MonoBehaviour
{

    #region Attributes
    float chaseTime = 0f;               // The time this agent will be chasing in case of seeing the player
    public float chaseSpeed = 5f;       // The chase speed of this agent
    public Transform playerTarget;      // The Transform of the player (has to be set via inspector, for some strange reason it fails to work if not done this way)
    #endregion

    #region Events
    /// <summary>
    /// When the player is colliding with the trigger, it will continue chasing
    /// </summary>
    /// <param name="other">Player</param>
    void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            chaseTime = 10f;
        }
    }

    /// <summary>
    /// If it's chasing, then it will count down on the chase timer,
    /// Then it sets the target to the actual position of the player
    /// and increases the speed of the AI as well as the animation
    /// </summary>
    void Update()
    {
        if(chaseTime > 0)
        {
            chaseTime -= Time.deltaTime;
            NavMeshAgent agent = GetComponent<NavMeshAgent>();

            if (agent.speed == 0)
            {
                
                GetComponent<Animation>().Play("idle", PlayMode.StopAll); // When the player is on a high spot and the AI can only wait
            }
            else
            {
                GetComponent<Animation>().Play("run", PlayMode.StopAll);
            }
            if (agent.pathStatus != NavMeshPathStatus.PathInvalid)
            {
                agent.SetDestination(playerTarget.position);
                agent.speed = chaseSpeed;
            }
        }
    }
    #endregion
}
