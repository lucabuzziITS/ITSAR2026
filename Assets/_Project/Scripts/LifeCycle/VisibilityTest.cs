using UnityEngine;

public class VisibilityTest : MonoBehaviour
{
    [SerializeField] VariablesTest vt;

    private void start()
    {
        if(vt != null)
        {
            Debug.Log($"{vt.ShopIndex}");
        }
    }
}
