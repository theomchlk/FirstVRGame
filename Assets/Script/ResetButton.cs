using UnityEngine;

public class ResetButton : MonoBehaviour
{
    [SerializeField]
    private TargetManager targetManager;

    private void OnTriggerEnter(Collider other){
        targetManager.ResetScore();
    }
}
