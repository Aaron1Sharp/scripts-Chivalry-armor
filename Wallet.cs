using UnityEngine;
using UnityEngine.UI; // Подключаем пространство имен для работы с UI
using TMPro;
public class Wallet : MonoBehaviour
{
    public TMP_Text walletText; // UI Text для отображения баланса
    public int balance = 0; // Переменная для хранения значения баланса

    void Start()
    {
        UpdateDisplay(); // Обновляем отображение баланса при старте
    }

    // Метод для добавления средств в кошелек
    public void AddFunds(int amount)
    {
        if (amount > 0)
        {
            balance += amount; // Увеличиваем баланс
            UpdateDisplay(); // Обновляем отображение
        }
    }

    // Метод для изъятия средств из кошелька
    public bool TrySpendFunds(int amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount; // Уменьшаем баланс
            UpdateDisplay(); // Обновляем отображение
            return true; // Возвращаем true, если транзакция успешна
        }
        return false; // Возвращаем false, если средств недостаточно
    }

    // Метод для обновления UI текста, отображающего баланс
    private void UpdateDisplay()
    {
        if (walletText != null)
        {
            walletText.text = "$: " + balance; // Устанавливаем текстовое значение
        }
    }

    // Опционально: метод для получения текущего баланса (если он будет нужен где-то ещё)
    public int GetBalance()
    {
        return balance;
    }
}
