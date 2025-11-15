using UnityEngine;
using TMPro;

public class DistanceTargetManager : MonoBehaviour
{
    [SerializeField]
    private CercleManager cercle;

    [SerializeField]
    private TMP_Text _distanceText;

    public void Start(){
        ChangePosition(cercle.Distance);
    }

    public void ChangePosition(int distance){
        cercle.ChangePosition(distance);
        if (cercle.increaseInNegative) _distanceText.text = -cercle.Distance + "m";
        else _distanceText.text = cercle.Distance + "m";
    }

}
