using UnityEngine;

public class ModalWindowManager : MonoBehaviour
{
    public GameObject[] modalWindows; // Массив всех модальных окон
    public CanvasGroup buttonsPanelCanvasGroup; // Canvas Group вашей панели с кнопками
    public GameObject closeButton; 

    // Метод для открытия конкретного модального окна
    public void OpenModalWindow(int windowIndex)
    {
        closeButton.SetActive(false);
        for (int i = 0; i < modalWindows.Length; i++)
        {
            // Активируем только выбранное окно и деактивируем все остальные
            modalWindows[i].SetActive(i == windowIndex);
        }
        buttonsPanelCanvasGroup.interactable = false; // Сделать кнопки на панели неинтерактивными
    }

    // Метод для закрытия всех модальных окон
    public void CloseAllModalWindows()
    {
        closeButton.SetActive(true);
        foreach (var window in modalWindows)
        {
            window.SetActive(false);
        }
        buttonsPanelCanvasGroup.interactable = true; // Вернуть интерактивность кнопкам
    }
}
