using UnityEngine;
using System.Collections;
using System;

public class AmmoPowerUp : MonoBehaviour, IPowerUp, IAddPoints, IAttack
{
    public static Action myA;

    public event EventHandler Attack;

    public int Points
    {
        get
        {
            throw new NotImplementedException();
        }

        set
        {
            throw new NotImplementedException();
        }
    }

    public int power
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    event Action IAttack.Attack
    {
        add
        {
            throw new NotImplementedException();
        }

        remove
        {
            throw new NotImplementedException();
        }
    }

    public int AddPoint()
    {
        throw new NotImplementedException();
    }

    public void OnTriggerEnter()
    {
        throw new NotImplementedException();
    }

    void Cool () {

        print("OK");
    }
    public void Start()
    {
        myA = Cool;
        throw new NotImplementedException();
    }
}
