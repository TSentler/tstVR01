using UnityEngine;
using UnityEngine.Rendering;

public class InteractButton: MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DoneButton")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
    }
}
