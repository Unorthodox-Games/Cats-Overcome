using UnityEngine;
using System.Collections;
using System;

public class Character : MonoBehaviour, IClientStored
{

    #region "Attributes"

    public string Username = "Meow Clawson";
    public Statistic statistic = null;

    #endregion

    #region "Constructor/Init"

    public Character()
    {
        // set default

        // load datas from client
        this.LoadDatasFromClient();
    }

    #endregion

    #region "Events"

    #endregion

    #region "Methods"

    #endregion

    #region IClientStored

    // attributes/properties
    private string _FileName = "";
    public string FileName
    {
        get
        {
            return this._FileName;
        }
        set
        {
            this._FileName = value;
        }
    }

    // methods
    public bool SaveDatasOnClient()
    {
        try
        {
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public bool LoadDatasFromClient()
    {
        try
        {
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    #endregion

}