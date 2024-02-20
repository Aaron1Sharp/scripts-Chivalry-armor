using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject itemSlotPrefab;

    void Start()
    {
        inventoryPanel.SetActive(false); // Скрываем панель инвентаря при старте
    }

    // Метод для открытия инвентаря
    public void ToggleInventory()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
    }

    // Метод для добавления предмета в инвентарь
    public void AddItemToInventory(Sprite itemSprite, int quantity)
    {
        GameObject itemSlot = Instantiate(itemSlotPrefab, inventoryPanel.transform);
        itemSlot.GetComponent<Image>().sprite = itemSprite;
        itemSlot.transform.GetChild(0).GetComponent<Text>().text = quantity.ToString();
    }
}
