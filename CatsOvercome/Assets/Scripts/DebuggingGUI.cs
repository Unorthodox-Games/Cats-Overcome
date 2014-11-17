using UnityEngine;
using System.Collections;

public class DebuggingGUI : MonoBehaviour {

   #region "Attributes"

    GameObject Player;
    #endregion

    #region "Constructor/Init"

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    #endregion

    #region "Events"

    void OnGUI()
    {
        if (GUILayout.Button("Jump"))
        {
            Player.GetComponent<Agility>().ImproveExperience(10);
        }
        if(GUILayout.Button("Slash"))
        {
            Player.GetComponent<Strenght>().ImproveExperience(10);
        }
        if(GUILayout.Button("Socialize"))
        {
            Player.GetComponent<Charm>().ImproveExperience(10);
        }
    }

    #endregion

    #region "Methods"
    

    #endregion
    

}
