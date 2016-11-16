using UnityEngine;
using System.Collections;
using System;

public class SheildsPowerUp : MonoBehaviour, IDamage, IProtect;
{
    public int ProtectionLevel
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

    public void Damage()
    {
        throw new NotImplementedException();
    }

    public void Protect()
    {
        throw new NotImplementedException();
    }
}
