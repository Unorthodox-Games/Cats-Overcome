using UnityEngine;
using System.Collections;
using System;

public class Characteristic : MonoBehaviour
{

    #region "Attributes"
    public int _CurrentLevel = 1;
    public int CurrentLevel
    {
        get
        {
            return _CurrentLevel;
        }
        set
        {
            _CurrentLevel = value;
        }
    }

    protected float _Experience = 0;
    public float Experience 
    {
        get
        {
            return this._Experience;
        }
        set
        {
            this._Experience = value;
        }
    }

    protected float _XPNextLevel = 110;
    public float XPNextLevel
    {
        get
        {
            return _XPNextLevel;
        }
        set
        {
            _XPNextLevel = value;
        }
    }

    public CaracteristicLevel level = null;
    public string Label = "";
    public Color Color;

    #endregion

    #region "Constructor/Init"

<<<<<<< HEAD
=======
    public Characteristic()
    {
        // set default
        this.Color = Color.black;
    }

>>>>>>> origin/master
    #endregion

    #region "Events"

    void Update()
    {
        Debug.Log("XP: " + _Experience);
        Debug.Log("Lv: " + CurrentLevel);
    }


    #endregion

    #region "Methods"

    /// <summary>
    /// Improve the experience of caracteristic
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool ImproveExperience(float value)
    {
        try
        {
            _Experience += value;
            if (_Experience > XPNextLevel)
                UpdateLevel();
            return true;
        }
        catch(Exception e)
        {
            return false;
        }
    }

    public bool UpdateLevel()
    {
        try
        {
            XPNextLevel = (float)Math.Pow((15 * CurrentLevel),2);
            CurrentLevel++;
            return true;
        }
        catch
        {
            return false;
        }

    }



    /// <summary>
    ///  Update the current level using experience points
    /// </summary>
    /// <returns></returns>
    /// 

    /*
    public bool UpdateLevel()
    {
        try
        {
            CaracteristicLevel nextLevel = this.NextStepLevel();

            if(nextLevel.Level != this.level.Level)
            {
                this.level = nextLevel;
                return true;
            }
            
        }
        catch(Exception e)
        {
            return false;
        }
        return false;
    }
     */

    /*
     * 
     *          Creating a new method for the moment
     * 
     * 

    public CaracteristicLevel NextStepLevel()
    {
        try
        {
            int level = 1;
            float nextExperience = 1;
            int maxLevel = 100;

            while (nextExperience <= this.Experience && ++level < maxLevel)
            {
                // here is the algorithm for leveling up
                nextExperience *= 2;
            }

            return new CaracteristicLevel() { Experience = nextExperience, Level = level };
        }
        catch(Exception e)
        {
            return null;
        }
    }
     * 
     */

    #endregion
}