using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Strenght_PBar : MonoBehaviour {
    
    #region "Attributes"

    RectTransform InnerProgressBar; // This is the bar that will move
    Text CurrLevel;                 // Level indicator
    public Text CurrExp;                   // % of XP for the Label

    float p100;                             // 100%
    float pCurrent;                         // Current %

    #endregion

    #region "Constructor/Init"

    void Start()
    {
        InnerProgressBar = GetComponent<RectTransform>();
        CurrLevel = GetComponentInChildren<Text>();
    }

    #endregion

    #region "Events"

    void Update()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");

        pCurrent = player.GetComponent<Strenght>().Experience;
        p100 = player.GetComponent<Strenght>().XPNextLevel;


        //gameObject.GetComponent<RectTransform>().sizeDelta += new Vector2(0.5f,0f);
        //InnerProgressBar.transform.right += new Vector3(((pCurrent * 100) / p100), 0f, 0f);
        CurrExp.text = ((pCurrent) / p100).ToString("0.0%");
        CurrLevel.text = player.GetComponent<Strenght>().CurrentLevel.ToString();
    }



    #endregion

    #region "Methods"



    #endregion
}
