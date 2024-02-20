using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject settingsPanel; // Ссылка на панель настроек

    void Start()
    {
        settingsPanel.SetActive(false); // Скрываем панель настроек при запуске
    }

    public void ContinueGame()
    {
        // Загрузка последнего сохранения или переход к игровой сцене
        SceneManager.LoadScene("GameScene"); // Замените "GameScene" на имя вашей игровой сцены
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true); // Отображаем панель настроек
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); // Скрываем панель настроек
    }

    public void QuitGame()
    {
        Application.Quit(); // Выход из игры
    }
}
