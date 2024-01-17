using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaCircle : MonoBehaviour, ICircle
{
    public float Amount { get; set; }
    public StatType Type { get; set; }
    

    

    public float GetCalculatedAmount()
    {
        return Amount;
    }

    public void StartLifeCycle()
    {
        CircleLifeCycle circleBehaviour = new ManaCircleLifeCycle();
        StartCoroutine(circleBehaviour.Activate());
    }

    private void Start()
    {
        Amount = 5;
        Type = StatType.Mana;
    }
}