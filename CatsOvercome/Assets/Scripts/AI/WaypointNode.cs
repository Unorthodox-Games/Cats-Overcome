using UnityEngine;
using System.Collections;

public class WaypointNode : MonoBehaviour
{
    #region Attributes
    public bool isBranching;            // False if this node has a single node, true for when has also a branching node
    public GameObject NextNode;         // Next node, has to be set via inspector (I wish there was a way to make that automatically?)
    public GameObject BranchingNode;    // Set via inspector in case of this node having also a branching node 
    #endregion
}
