using UnityEngine;

[CreateAssetMenu(fileName = "NewUpgrade", menuName = "Upgrade System/Upgrade")]
public class Upgrade : ScriptableObject
{
    public string upgradeName;
    public int cost;
    // Добавьте другие параметры, характерные для улучшения, например:
    public float clickMultiplier;
    public int additionalIncome;
    // Можно добавить методы, которые будут применять эти улучшения
}
