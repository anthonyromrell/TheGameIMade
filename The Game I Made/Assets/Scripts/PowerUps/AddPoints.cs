using UnityEngine;
using System;

public class AddPoints : MonoBehaviour, IAddPoints
{
    public static EventHandler myE () {
        print("cool");
        return null;   
    }
    private int points;
    public int Points
    {
        get
        {
            return points;
        }

        set
        {
            points = value;
        }
    }

    
    void Start()
    {
    
       myE();
    }
    public int AddPoint()
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter()
    {
        throw new NotImplementedException();
    }
}
