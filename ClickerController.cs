using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ClickerController : MonoBehaviour
{
    public Wallet wallet;
    public TMP_Text upgradeInfoText;
    public IncomeGenerator incomeGenerator;

    public int fundsPerClick = 1;
    public int upgradeCost = 10; // Начальная стоимость улучшения
    public int additionalFunds = 2;
    public int incomeIncreaseAmount = 1;
    public int costIncreaseAmount = 150; // Увеличение стоимости улучшения

    void Start()
    {
        UpdateUpgradeInfo();
    }

    public void OnClick()
    {
        wallet.AddFunds(fundsPerClick);
    }

    public void OnBuyBread()
    {
        if (wallet.TrySpendFunds(upgradeCost))
        {
            fundsPerClick += additionalFunds;
            incomeGenerator.IncreaseIncome(incomeIncreaseAmount);
            upgradeCost += costIncreaseAmount; // Увеличиваем стоимость улучшения

            UpdateUpgradeInfo(); // Обновляем информацию об улучшении после покупки
            Debug.Log("Улучшение куплено. Теперь за клик: " + fundsPerClick + ", и доход от генератора увеличен.");
        }
        else
        {
            Debug.Log("Недостаточно средств для покупки улучшения");
        }
    }

    public void OnBuyUpgrade()
    {
        if (wallet.TrySpendFunds(upgradeCost))
        {
            fundsPerClick += additionalFunds;
            incomeGenerator.IncreaseIncome(incomeIncreaseAmount);
            upgradeCost += costIncreaseAmount; // Увеличиваем стоимость улучшения

            UpdateUpgradeInfo(); // Обновляем информацию об улучшении после покупки
            Debug.Log("Улучшение куплено. Теперь за клик: " + fundsPerClick + ", и доход от генератора увеличен.");
        }
        else
        {
            Debug.Log("Недостаточно средств для покупки улучшения");
        }
    }

    private void UpdateUpgradeInfo()
    {
        if (upgradeInfoText != null)
        {
            upgradeInfoText.text = $"Цена: {upgradeCost} | + за клик: {additionalFunds}\n + от генератора: {incomeIncreaseAmount}";
        }
    }
}