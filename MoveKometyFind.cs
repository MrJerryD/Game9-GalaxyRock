using UnityEngine;

public class MoveKometyFind : MonoBehaviour
{
    public float speed = 3f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <= -6.5f)
        {
            Destroy(gameObject);
        }
    }
}
