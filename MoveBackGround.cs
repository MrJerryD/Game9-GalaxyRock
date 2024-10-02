using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public GameObject bg;
    public float speed = 1f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
