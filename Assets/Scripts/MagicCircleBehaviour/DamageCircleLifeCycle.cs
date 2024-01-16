using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCircleLifeCycle : CircleLifeCycle
{
    public override IEnumerator Activate()
    {
        SpawnUp();
        yield return new WaitForSeconds(10);
        Shrink();
    }
}
