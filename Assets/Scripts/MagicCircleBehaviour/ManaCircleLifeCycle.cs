using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaCircleLifeCycle : CircleLifeCycle
{
    public override IEnumerator Activate()
    {
        SpawnUp();
        yield return new WaitForSeconds(15);
        Shrink();
    }
}
