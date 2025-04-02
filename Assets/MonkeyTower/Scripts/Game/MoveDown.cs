using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public FloatObject gameSpeed;
    //public float speed = 2.0f;
    public float destroyDepth = -15;

    void Update()
    {
        transform.Translate(Vector3.down * (gameSpeed.value * Time.deltaTime));
        
        if (transform.position.y <= destroyDepth)
        {
            Destroy(gameObject);
        }
    }
}
