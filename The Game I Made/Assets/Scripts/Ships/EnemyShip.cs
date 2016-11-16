using UnityEngine;
using System.Collections;
using System;

public class EnemyShip : ShipBase, IProtect {
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


    public void Protect(int i, string s)
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    public override void Start () {
        base.Start();
        Chase();
	}

    private void Chase()
    {
        print("Chasing");
    }
}
