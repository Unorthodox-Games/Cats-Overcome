using UnityEngine;
using System.Collections;
using System;

public class Characteristic : MonoBehaviour
{

    #region "Attributes"

    protected float _Experience = 0;
    public float Experience {
        get{
            return this._Experience;
        }
        set
        {
            this._Experience = value;
        }
    }

    public CaracteristicLevel level = null;

    #endregion

    #region "Constructor/Init"

    public Characteristic()
    {
        
    }

    #endregion

    #region "Events"



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
            return true;
        }
        catch(Exception e)
        {
            return false;
        }
    }

    /// <summary>
    ///  Update the current level using experience points
    /// </summary>
    /// <returns></returns>
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

    #endregion
}