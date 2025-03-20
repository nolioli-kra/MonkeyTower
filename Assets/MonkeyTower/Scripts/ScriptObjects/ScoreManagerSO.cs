using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManagerSO", menuName = "Scriptable Objects/ScoreManagerSO")]
public class ScoreManagerSO : ScriptableObject
{
    public int score;       // Total score
    public int comboCount;  // Number of consecutive bananas tapped

    // Called when a banana is tapped
    public void IncrementScore()
    {
        score += 1;    // Add 1 point per banana
        comboCount += 1; // Increment combo
    }

    // Called when a bomb is tapped
    public void ResetCombo()
    {
        comboCount = 0; // Reset combo count
    }

    // Called at game start to reset all values
    public void ResetScore()
    {
        score = 0;
        comboCount = 0;
    }
}
