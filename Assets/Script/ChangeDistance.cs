using UnityEngine;

public class ChangeDistance : MonoBehaviour
{
    [SerializeField]
    private DistanceTargetManager _distanceTargetManager;
    [SerializeField]
    private int _distance;


    private void OnTriggerEnter(Collider other){
        _distanceTargetManager.ChangePosition(_distance);
    }
}
