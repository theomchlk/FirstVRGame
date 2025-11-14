using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    [SerializeField]
    private int value;
    public event System.Action<int> OnHit;

    private int _timesBeenShoot;

    public void beenShoot(){
        _timesBeenShoot++;
        OnHit?.Invoke(value);
        
    }

}
