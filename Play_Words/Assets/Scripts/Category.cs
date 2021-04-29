using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Category : MonoBehaviour
{
    // Play body is a position with cards width and height.
    public GameObject play_body;
    public GameObject card_layout;
    
    // Put cards in list
    public List<GameObject> cards;
    
    // Show cards if button start clicks.

    // Method for put card in a choosed_cards_positions.
    public void Put_Card()
    {
        // Get Cards_Layout game object and put it to card_layout field in the unity editor 
        // Instantiate category card game object
        GameObject clone = Instantiate(this.gameObject, card_layout.transform);
        
        // Change the size of category cards
        RectTransform clone_rect = clone.GetComponent<RectTransform>();
        clone_rect.sizeDelta = new Vector2(350, 458);
    }
}
