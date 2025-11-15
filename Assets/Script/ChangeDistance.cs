using UnityEngine;

public class ChangeDistance : MonoBehaviour
{
    [SerializeField]
    private DistanceTargetManager _distanceTargetManager;
    [SerializeField]
    private int _distance;


    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Left Hand") || other.CompareTag("Right Hand")) _distanceTargetManager.ChangePosition(_distance);
    }
}
