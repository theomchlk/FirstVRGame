using UnityEngine;
using TMPro;

public class TargetManager : MonoBehaviour
{
    [SerializeField]
    private TargetBehavior[] targets;
    [SerializeField]
    private TMP_Text _scoreDisplay;
    [SerializeField]
    private TMP_Text _hitDisplay;



    private int _score;

    public void Subscribe(TargetBehavior target){
        target.OnHit += AddScore;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var target in targets) {Subscribe(target);}
        ResetScore();
    }

    private void AddScore(int score){
        _score += score;
        _scoreDisplay.text = "" +_score;
        _hitDisplay.text = "" + score;
    }

    public void ResetScore(){
        _score = 0;
        _scoreDisplay.text = "" + _score;
        _hitDisplay.text = "hit :";
    }

}
