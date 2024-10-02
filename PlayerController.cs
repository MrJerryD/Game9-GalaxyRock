using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPosition;
    public GameObject player;
    private float speed = 7f;

    private void Start()
    {
        targetPosition = player.transform.position;
    }

    private void Update()
    {

//#if UNITY_EDITOR
        // проверяем ли реагирует на нажатие мышки
        if (Input.GetMouseButton(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Mouse " + targetPosition);
        }
//#endif

        float step = speed * Time.deltaTime;
        if (targetPosition.y < -3.8f) // координаты движения
        {
            targetPosition.y = -3.8f;
        }
        else if (targetPosition.y > 3.5f) // стена за которую не выйдешь
        {
            targetPosition.y = 3.5f;
        }

        if (targetPosition.x < -8.4f)
        {
            targetPosition.x = -8.4f;
        }
        else if (targetPosition.x > 8.4f)
        {
            targetPosition.x = 8.4f;
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(targetPosition.x, targetPosition.y, player.transform.position.z), step);
        // позволяет передвигать игрока по значениям
    }
}
