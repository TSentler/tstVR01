using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public Cauldron cauldron;

public GameObject mushroom


    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Water) &&
                  ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
        }
        cauldron.ClearCauldron();
        else if (ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Eye) &&
                  ingredients.Count == 2) 
            cauldron.ClearCauldron();
        else if (ingredients.Contains(IngredientType.Water) &&
                  ingredients.Contains(IngredientType.Bone) &&
                  ingredients.Count == 2
            cauldron.ClearCauldron();
        else if (ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Bone) &&
                  ingredients.Count == 2)
}