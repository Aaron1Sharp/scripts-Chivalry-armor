using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public GameObject shopPanel; // Ссылка на панель магазина
    public GameObject BackGroundBlock; 
    public GameObject CloseButton; 

    // Метод для открытия магазина
    public void OpenShop()
    {
        CloseButton.SetActive(true);
        shopPanel.SetActive(true);
        BackGroundBlock.SetActive(true);
    }

    // Метод для закрытия магазина
    public void CloseShop()
    {
        CloseButton.SetActive(false);
        shopPanel.SetActive(false);
        BackGroundBlock.SetActive(false);
    }
    // Здесь можно добавить другие методы, связанные с логикой магазина
}
