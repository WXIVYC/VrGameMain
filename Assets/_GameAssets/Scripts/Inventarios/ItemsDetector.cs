using UnityEngine;
using UnityEngine.Events;

namespace FPFInventory
{
    public class ItemsDetector : MonoBehaviour
    {
        public static UnityAction<FPFInventory.InventoryItem> OnCollectItem;


        public bool destroyItem = false;
        private void OnTriggerEnter(Collider other)
        {
            print("Trigger");
            if (other.gameObject.GetComponentInParent<FPFInventory.SceneItem>())
            {
                FPFInventory.SceneItem sceneItem = other.gameObject.GetComponentInParent<FPFInventory.SceneItem>();
                FPFInventory.InventoryItem inventoryItem = new FPFInventory.InventoryItem(
                    sceneItem.itemName, 
                    sceneItem.itemsCounter, 
                    sceneItem.imageUI, 
                    sceneItem.itemGO);
                if (OnCollectItem != null)
                {
                    OnCollectItem.Invoke(inventoryItem);
                } else
                {
                    Debug.LogWarning("No hay suscriptores al proceso de recogida de Items");
                }

                if (destroyItem)
                {
                    Instantiate(
                        other.transform.parent.gameObject.GetComponent<SceneItem>().collectGO,
                        other.transform.position,
                        other.transform.rotation);
                    Destroy(other.transform.parent.gameObject);
                }
            }
        }
    }
}
