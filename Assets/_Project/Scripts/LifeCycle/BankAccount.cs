using UnityEngine;

public class BankAccount : MonoBehaviour
{
    [SerializeField] int conteinedValue;

    public int BankValue => conteinedValue;

    public void AddMoneyToBank(int money)
    {
        conteinedValue += money;
    }
}
