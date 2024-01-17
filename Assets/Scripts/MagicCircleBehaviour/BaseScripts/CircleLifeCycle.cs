using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleLifeCycle 
{
   

    public abstract IEnumerator Activate(ICircle circleRef);//Subclass kendi versiyonunu tanýmlamalý

    public abstract ICircle CircleRef { get; set; }

    protected void SpawnUp()
    {
        Debug.Log("Circle Spawn Up");
        CircleRef.GetGameObject();
    }

    protected void Shrink()
    {
        Debug.Log("Circle Shrink");
        Despawn();
    }

    protected void Despawn()
    {
        Debug.Log("Circle Despawn");
    }
}
