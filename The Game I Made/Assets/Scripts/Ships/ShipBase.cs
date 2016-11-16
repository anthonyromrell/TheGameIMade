using UnityEngine;
using System.Collections;
using System;

public class ShipBase : MonoBehaviour, IDamage, IAttack {

    public void Attack()
    {
        print("Attacking");
    }

    public void Damage()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    public virtual void Start () {
        print("Refuel");
        Attack();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
