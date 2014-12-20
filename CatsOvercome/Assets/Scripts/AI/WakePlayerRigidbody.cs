using UnityEngine;
using System.Collections;

class WakePlayerRigidbody : MonoBehaviour
{
    #region Events
    /// <summary>
    /// Pretty much self explainatory, if the Rigidbody of the player is sleeping, then wake it up
    /// </summary>
    void Update()
    {
        if(GetComponent<Rigidbody>().IsSleeping())
        {
            GetComponent<Rigidbody>().WakeUp();
        }
    }
    #endregion
}
