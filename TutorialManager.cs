using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel; // Ссылка на панель обучения в вашем UI

    private void Start()
    {
        ShowTutorialIfFirstTime();
    }

    private void ShowTutorialIfFirstTime()
    {
        // Проверяем, было ли обучение уже показано (0 - не показано, 1 - показано)
        if (PlayerPrefs.GetInt("TutorialShown", 0) == 0)
        {
            tutorialPanel.SetActive(true); // Показываем панель обучения
            PlayerPrefs.SetInt("TutorialShown", 1); // Устанавливаем флаг, что обучение показано
            PlayerPrefs.Save(); // Сохраняем изменения
        }
        
        else
        {
            tutorialPanel.SetActive(false); // Скрываем панель обучения, если она уже была показана
        }
    }

    // Метод для закрытия обучения, который можно вызвать, например, по кнопке "Продолжить" на панели обучения
    public void CloseTutorial()
    {
        tutorialPanel.SetActive(false); // Скрываем панель обучения
    }
}
