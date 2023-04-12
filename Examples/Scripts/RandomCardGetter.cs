using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityExtendedScriptable.Test
{
    public class RandomCardGetter : MonoBehaviour
    {
        public List<Card> AvailableCards;
        public Deck Deck;

        public Text LinkedText;

        public void GetRandomCard()
        {
            if (AvailableCards == null || AvailableCards.Count == 0)
            {
                SetText("No available cards");
                Debug.LogError("Please add some cards into AvailableCards field");
                return;
            }

            int randomIndex = UnityEngine.Random.Range(0, AvailableCards.Count);

            System.Guid aGuidToSearch = AvailableCards[randomIndex].Guid;

            Card aCard = Deck.FindByGuid(aGuidToSearch);

            SetText(aCard == null ?
                        $"No card found with guid {aGuidToSearch.ToString("N")} \n :("
                        :
                        $"Card <b>{aCard.GetName}</b> was founded with guid \n{aCard.Guid.ToString("N")}");
        }

        private void SetText(string text)
        {
            if (LinkedText == null)
                return;

            LinkedText.text = text;
        }
    }
}