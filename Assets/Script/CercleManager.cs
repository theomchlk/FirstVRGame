using UnityEngine;

public class CercleManager : MonoBehaviour
{
    public enum MoveAxis { X, Y, Z };
    public bool increaseInNegative;

    public MoveAxis axis = MoveAxis.X;

    [SerializeField]
    private int _distance = 5;

    public void Awake(){
        UpdateTargetPosition();
    }

    public int Distance{
        get => _distance;
        private set{

            if (increaseInNegative) _distance = Mathf.Clamp(value, -50, -5);
            else _distance = Mathf.Clamp(value, 5, 50);
            UpdateTargetPosition();
        }
    }

    private void UpdateTargetPosition(){
        Vector3 pos = transform.localPosition;

        switch(axis){
            case MoveAxis.X:
                pos.x = _distance;
                break;
            case MoveAxis.Y:
                pos.y = _distance;
                break;
            case MoveAxis.Z:
                pos.z = _distance;
                break;
        }

        transform.localPosition = pos;
    }

    public void ChangePosition(int amount){
        if (increaseInNegative) Distance -= amount;
        else Distance += amount;
    }
}
