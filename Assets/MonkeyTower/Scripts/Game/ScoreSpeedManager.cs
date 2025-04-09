using UnityEngine;

public class ScoreSpeedManager : MonoBehaviour
{
    public FloatObject gameSpeed; // Reference to the FloatObject ScriptableObject
    public ScoreManagerSO scoreManager; // Reference to the ScoreManager

    public int minComboThreshold = 10;
    public int maxComboThreshold = 50;
    public int speedMultiplier;

    void Start()
    {
        // Initialize gameSpeed to its default value
        gameSpeed.value = gameSpeed.defaultValue;
    }

    void Update()
    {
        AdjustGameSpeed();
    }

    void AdjustGameSpeed()
    {
        if (scoreManager.comboCount < minComboThreshold)
        {
            gameSpeed.value = gameSpeed.minValue;
        }
        else if (scoreManager.comboCount > maxComboThreshold)
        {
            gameSpeed.value = gameSpeed.maxValue;
        }
        else
        {
            float comboRange = maxComboThreshold - minComboThreshold;
            float speedRange = gameSpeed.maxValue - gameSpeed.minValue;
            float comboProgress = (float)(scoreManager.comboCount - minComboThreshold) / comboRange;
            gameSpeed.value = gameSpeed.minValue + comboProgress * speedRange;
        }
    }
}
