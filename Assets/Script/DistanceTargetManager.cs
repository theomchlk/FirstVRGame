using UnityEngine;
using TMPro;

public class DistanceTargetManager : MonoBehaviour
{
    [SerializeField]
    private CercleManager cercle;

    [SerializeField]
    private TMP_Text _distanceDisplay;

    public void Start(){
        ChangePosition(cercle.Distance);
    }

    public void ChangePosition(int distance){
        cercle.ChangePosition(distance);
        _distanceDisplay.text = cercle.Distance + "m";
    }

}
