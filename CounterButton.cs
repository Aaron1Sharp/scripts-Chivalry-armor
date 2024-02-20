using UnityEngine;
using UnityEngine.UI;

public class CounterButton : MonoBehaviour
{
    public Text counterText; // UI Text для отображения счетчика
    private int counter = 0; // Переменная для хранения значения счетчика

    void Start()
    {
        UpdateCounterText();
    }

    // Метод для обновления текста счетчика
    void UpdateCounterText()
    {
        counterText.text = "Баланс: " + counter;
    }

    // Метод для вызова при нажатии кнопки
    public void OnButtonPressed()
    {
        counter++; // Увеличиваем счетчик
        UpdateCounterText(); // Обновляем текст
    }
}
