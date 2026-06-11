using System.Collections.Generic;
using UnityEngine;


public class Cauldron : MonoBehaviour
{
    public List<IngredientType> currentIngredients = new List<IngredientType>();

    private void OnTriggerEnter(Collider other)
    {
        ingredient ingredient = other.GetComponent<ingredient>();
        if (ingredient != null)
            currentIngredients.Add(ingredient.type);
        Debug.Log("Added: " + ingredient.type);
        other.gameObject.SetActive(false);
    }
    public void ClearCauldron()
    {
        currentIngredients.Clear();
        Debug.Log("Котел очищен");
    }
}
