using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner spawner;
    public Cauldron cauldron;

    public GameObject bigMushroom;
    public GameObject refrezherator; //(это рефрактометр для определения световых лучей в прозрачных жидкостях и некоторых твердых веществах.это даже звучит странно)


    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
            spawner.Spawn(bigMushroom);
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Water) &&
                  ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
            spawner.Spawn(refrezherator);
        }
        else if (
                  ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Eye) &&
                  ingredients.Count == 2)
        {
            Debug.Log("Zele bessmertiz sozdano");
        }
        else if (ingredients.Contains(IngredientType.Water) &&
                  ingredients.Contains(IngredientType.Bone) &&
                  ingredients.Count == 2)
        {
            Debug.Log("Zele poleta sozdano");
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
                  ingredients.Contains(IngredientType.Bone) &&
                  ingredients.Count == 2)
        {
            Debug.Log("Zele predvidenia sozdano");
        }
        

        cauldron.ClearCauldron();
    }
}