using UnityEngine;

public class RayGunBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform muzzle;
    [SerializeField]
    private float maxRayDistance = 5f;
    [SerializeField]
    private LayerMask shootableLayer;
    [SerializeField] 
    private AudioSource gunAudio;
    [SerializeField] 
    private ParticleSystem particlePrefab;



    public void Shoot(){
        gunAudio.Play();
        ParticleSystem effect = Instantiate(particlePrefab, muzzle.position, muzzle.rotation);
        effect.Play();
        Destroy(effect.gameObject, effect.main.duration);

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
