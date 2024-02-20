using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Upgrade upgrade;
    public UnityEvent onUpgradeClick;

    void Start()
    {
        // Предполагается, что у кнопки есть компонент Button
        GetComponent<Button>().onClick.AddListener(ApplyUpgrade);
    }

    void ApplyUpgrade()
    {
        // Здесь логика применения улучшения
        // Например, проверка хватает ли денег и т.д.
        Debug.Log($"Применено улучшение: {upgrade.upgradeName}");

        // Вызов события, если оно не пустое
        onUpgradeClick?.Invoke();
    }
}
