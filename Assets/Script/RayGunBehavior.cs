using UnityEngine;

public class RayGunBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform muzzle;

    [SerializeField]
    private float maxRayDistance = 5f;

    [SerializeField]
    private LayerMask shootableLayer;

    public void Shoot(){
        Debug.Log("Je tire");
        Debug.DrawRay(muzzle.position, muzzle.forward * maxRayDistance, Color.red, 1f);

        if (!Physics.Raycast(
            muzzle.position,
            muzzle.forward,
            out RaycastHit hit,
            maxRayDistance,
            shootableLayer
        )) return;

    TargetBehavior target = hit.collider.GetComponentInParent<TargetBehavior>();
    target.beenShoot();
    }

}
