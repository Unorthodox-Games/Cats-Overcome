using UnityEngine;
using System.Collections;

public class FindNearestPath : MonoBehaviour
{

    #region Attributes
    GameObject[] waypoints;                 // All the waypoints on the scene
    float nearestDistance = float.MaxValue; // The distance to the nearest waypoint, max value by default
    GameObject currentNode;                 // The waypoint to which is currently traveling
    bool recentlyBranched = false;          // Branching allows the AI to choose randomly between two paths, if already choose, it won't choose again for some time
    public float walkSpeed = 3.0f;          // The normal walking speed of the robot
    #endregion

    #region Events
    /// <summary>
    /// We search for the closest waypoint and set it as our target
    /// </summary>
    void Start () 
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        foreach(GameObject w in waypoints)
        {
            float currDistance = (w.transform.position - transform.position).sqrMagnitude;
            if (currDistance < nearestDistance)
            {
                nearestDistance = currDistance;
                currentNode = w;
            }
        }
        MoveTo(currentNode.transform.position);
	}

    /// <summary>
    /// When we arrive our destination we will call the method to search the next waypoint
    /// </summary>
    void Update()
    {
       if (GetComponent<NavMeshAgent>().remainingDistance == 0)
       {
          FindNext();
       }
    }
    #endregion

    #region Methods
    /// <summary>
    /// If it's a single node, it will just assign our current target to the next node, if it's a branching node, 
    /// it will randomly pick between one of the two options (only if it didn't branched on the previous node, for obvious reasons) 
    /// </summary>
    void FindNext()
    {
        WaypointNode wp = currentNode.GetComponent<WaypointNode>();
        if(wp.isBranching && !recentlyBranched)
        {
            if(Random.value > 0.5f)
            {
                recentlyBranched = true;
                currentNode = wp.BranchingNode;
            }
            else
            {
                recentlyBranched = false;
                currentNode = wp.NextNode;
            }
        }
        else
        {
            recentlyBranched = false;
            currentNode = wp.NextNode;
        }
        MoveTo(currentNode.transform.position);
    }

    /// <summary>
    /// Here we set a new destination for the agent and set his speed down/changed animation (in case he started chasing)
    /// </summary>
    /// <param name="pos">Pos will be this agent's Vector3 to set as a new target destination</param>
    public void MoveTo(Vector3 pos)
    {
        GetComponent<NavMeshAgent>().SetDestination(pos);
        GetComponent<Animation>().Play("walk", PlayMode.StopAll);
        GetComponent<NavMeshAgent>().speed = walkSpeed;
    }
    #endregion
}
