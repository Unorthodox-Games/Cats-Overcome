using UnityEngine;
using System.Collections;

public class Statistic : MonoBehaviour
{

    #region Attributes

    // public
    public static float PlayedTime = 0.0f;

    #endregion

    #region "Constructor/Init"

    public Statistic()
    {

    }

    #endregion

    #region "Events"

    void Update()
    {
        PlayedTime += Time.deltaTime;
    }

    #endregion

    #region "Methods"



    #endregion
}