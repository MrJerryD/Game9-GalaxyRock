using UnityEngine;

public class CreateBackGround : MonoBehaviour
{
    // Ссылка на текущий задний фон
    public GameObject now_bg;

    // Префаб нового заднего фона
    public GameObject instat_bg;

    // Переменная для хранения нового созданного заднего фона
    private GameObject newPrefab_bg;

    // Метод, вызываемый каждый кадр
    private void Update()
    {
        // Проверяем условие для создания нового заднего фона
        if (now_bg.transform.position.y <= -2f && newPrefab_bg == null)
        {
            // Вызываем метод для создания нового заднего фона
            CreateNewBg();
        }
        // Проверяем условие для создания дополнительного нового заднего фона
        else if (newPrefab_bg != null && newPrefab_bg.transform.position.y <= -2f)
        {
            // Вызываем метод для создания еще одного нового заднего фона
            CreateNewBg();
        }
    }

    // Метод для создания нового заднего фона
    void CreateNewBg()
    {
        // Создаем новый объект заднего фона из префаба
        newPrefab_bg = Instantiate(instat_bg, new Vector2(0f, 14.3f), Quaternion.identity) as GameObject;

        // Проверяем, если текущий задний фон находится ниже определенной высоты
        if (now_bg.transform.position.y < - 12f)
        {
            // Уничтожаем текущий задний фон
            Destroy(now_bg);

            // Присваиваем переменной now_bg ссылку на новый задний фон
            now_bg = newPrefab_bg;
        }
    }
}