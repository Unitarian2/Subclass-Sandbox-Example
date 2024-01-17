using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleLifeCycle 
{
    

    public abstract IEnumerator Activate();//Subclass kendi versiyonunu tanýmlamalý

    protected void SpawnUp()
    {
        Debug.Log("Circle Spawn Up");
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
