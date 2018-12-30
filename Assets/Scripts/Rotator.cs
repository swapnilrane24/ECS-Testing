using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Rotator : MonoBehaviour {

    public float speed;
}

public class RotateComponent : ComponentSystem
{
    struct Component
    {
        public Rotator rotator;
        public Transform transform;
    }

    protected override void OnUpdate()
    {
        float deltaTime = Time.deltaTime;

        foreach (var e in GetEntities<Component>())
        {
            e.transform.Rotate(0, e.rotator.speed * deltaTime, 0);
        }
    }

}