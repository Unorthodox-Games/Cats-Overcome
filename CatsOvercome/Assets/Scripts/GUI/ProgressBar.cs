using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    #region "Attributes"

    public AttributeType StatisticToDisplay;
    public RectTransform ProgressBarTransform;  // This is the bar that will move
    public Text CurrentLevelLabel;              // Level indicator
    public Text CurrentXPLabel;                 // % of XP for the Label

    float p100;                                 // 100%
    float pCurrent;                             // Current %
    float currentLevel;                         // Current level the player is in

    float time = 10f;
        

    #endregion

    #region "Constructor/Init"

    #endregion

    #region "Events"

    void Update()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");
        switch (StatisticToDisplay)
        {
            case AttributeType.STRENGHT:
                pCurrent = player.GetComponent<Strenght>().Experience;
                p100 = player.GetComponent<Strenght>().XPNextLevel;
                currentLevel = player.GetComponent<Strenght>().CurrentLevel;
                break;
            case AttributeType.AGILITY:
                pCurrent = player.GetComponent<Agility>().Experience;
                p100 = player.GetComponent<Agility>().XPNextLevel;
                currentLevel = player.GetComponent<Agility>().CurrentLevel;
                break;
            case AttributeType.CHARM:
                pCurrent = player.GetComponent<Charm>().Experience;
                currentLevel = player.GetComponent<Charm>().CurrentLevel;
                p100 = player.GetComponent<Charm>().XPNextLevel;
                break;
        }
     
            ProgressBarTransform.anchoredPosition = new Vector2(-50.0f, 0f);
            ProgressBarTransform.sizeDelta = new Vector2(-100f, 20f);
            ProgressBarTransform.anchoredPosition += new Vector2((((pCurrent * 100) / p100) / 2f), 0f);
            ProgressBarTransform.sizeDelta += new Vector2(((pCurrent * 100) / p100), 0f);
            CurrentLevelLabel.text = currentLevel.ToString();
            CurrentXPLabel.text = ((pCurrent) / p100).ToString("0.0%");
    }



    #endregion

    #region "Methods"



    #endregion

}
