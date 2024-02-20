using System.Collections;
using UnityEngine;

public class IncomeGenerator : MonoBehaviour
{
    public Wallet wallet;
    public float incomeInterval = 1.0f;
    public int incomeAmount = 1;

    void Start()
    {
        StartCoroutine(GenerateIncome());
    }

    IEnumerator GenerateIncome()
    {
        while (true)
        {
            yield return new WaitForSeconds(incomeInterval);
            wallet.AddFunds(incomeAmount);
        }
    }

    // Метод для увеличения дохода
    public void IncreaseIncome(int amount)
    {
        incomeAmount += amount;
    }
}
