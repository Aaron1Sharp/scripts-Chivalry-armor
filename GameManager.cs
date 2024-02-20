using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Синглтон для доступа к GameManager

    public Wallet wallet; // Ссылка на кошелек
    public ClickerController clickerController; // Ссылка на контроллер кликера

    void Start()
    {
        StartCoroutine(AutoSaveRoutine());
    }

    IEnumerator AutoSaveRoutine()
    {
        while (true) // Бесконечный цикл для автосохранения
        {
            yield return new WaitForSeconds(15f); // Ожидание 15 секунд
            SaveGameData(); // Вызов метода сохранения
            Debug.Log("Произведено сохранение.");

        }
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Опционально, если GameManager должен сохраняться между сценами
        }
        else
        {
            Destroy(gameObject);
        }

        LoadGameData();
            Debug.Log("Произведена загрузка данных.");

    }

    void OnApplicationQuit()
    {
        SaveGameData();
            Debug.Log("Произведено сохранение.");
        
    }

    public void SaveGameData()
    {
        // Код сохранения данных
        PlayerPrefs.SetInt("Balance", wallet.balance);
        PlayerPrefs.SetInt("FundsPerClick", clickerController.fundsPerClick);
        PlayerPrefs.SetInt("UpgradeCost", clickerController.upgradeCost);
        PlayerPrefs.Save();
    }

    public void LoadGameData()
    {
        // Код загрузки данных
        wallet.balance = PlayerPrefs.GetInt("Balance", wallet.balance);
        clickerController.fundsPerClick = PlayerPrefs.GetInt("FundsPerClick", clickerController.fundsPerClick);
        clickerController.upgradeCost = PlayerPrefs.GetInt("UpgradeCost", clickerController.upgradeCost);
    }
}
