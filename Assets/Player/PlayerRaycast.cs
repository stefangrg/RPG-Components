using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRaycast : MonoBehaviour
{
    RaycastHit HitInfo;
    Transform cameraTransform;

    [SerializeField]
    private float RaycastRange = 4.0f;

    public UnityAction<Entity> OnEntityHit;
    public UnityAction OnHitNothing;

    private void Awake()
    {
        cameraTransform = GetComponentInChildren<Camera>().transform;
    }

    void Update()
    {
        // Check if player raycast collide with something
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out HitInfo, RaycastRange))
        {
            Entity entity = HitInfo.transform.GetComponent<Entity>();
            if (entity)
                OnEntityHit.Invoke(entity);
            else
                OnHitNothing.Invoke();
        }

        Debug.DrawRay(cameraTransform.position, cameraTransform.forward * RaycastRange, Color.cyan);

    }
}
