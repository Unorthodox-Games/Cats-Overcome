using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ShowTimePlayed : MonoBehaviour {
    
    #region "Attributes"

    #endregion

    #region "Constructor/Init"



    #endregion

    #region "Events"

    void Update()
    {
        GetComponent<Text>().text = "Time Played: " + ((int)Statistic.PlayedTime/60).ToString("00") + ":" +((int)Statistic.PlayedTime%60).ToString("00");
    }

    #endregion

    #region "Methods"



    #endregion

}
