using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class MagicCircleFactory : MonoBehaviour
{
    [SerializeField] private Transform circleParent;
    public ICircle GetMagicCircle(GameObject circleToGet,Vector3 spawnPos)
    {
        GameObject clone = Instantiate(circleToGet, spawnPos, Quaternion.identity, circleParent);
        ICircle circle = clone.GetComponentInChildren<ICircle>();

        return circle;
    }
}
