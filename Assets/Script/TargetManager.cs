using UnityEngine;
using TMPro;

public class TargetManager : MonoBehaviour
{
    [SerializeField]
    private TargetBehavior[] targets;
    [SerializeField]
    private TMP_Text _scoreText;
    [SerializeField]
    private TMP_Text _hitText;



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
        _scoreText.text = "" +_score;
        _hitText.text = "hit :" + score;
    }

    public void ResetScore(){
        _score = 0;
        _scoreText.text = "" + _score;
        _hitText.text = "hit :";
    }

}
