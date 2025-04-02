using UnityEngine;

[CreateAssetMenu]
public class FloatObject : ScriptableObject
{
    public float value;
    
    public float defaultValue;
    public float maxValue;
    public float minValue;
    public float multiplierValue;

    public void IncrementValue()
    {
        value++;
    }

    public void MultiplyValue()
    {
        if (value >= maxValue)
        {
            value = maxValue;
        }
        else
        {
            value *= multiplierValue;
        }
    }

    public void ResetValue()
    {
        value = defaultValue;
    }
}
