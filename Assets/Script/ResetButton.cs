using UnityEngine;

public class ResetButton : MonoBehaviour
{
    [SerializeField]
    private TargetManager targetManager;

    private void OnTriggerEnter(){
        targetManager.ResetScore();
    }
}
