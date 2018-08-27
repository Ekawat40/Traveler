using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isLootboxSold;

	public Text moneyAmountText;
	public Text LootboxPrice;

	public Button buyButton;

	// Use this for initialization
	void Start () {
		moneyAmount = 400;
	}
	
	// Update is called once per frame
	void Update () {
		
		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

		isLootboxSold = PlayerPrefs.GetInt ("IsLootboxSold");

		if (moneyAmount >= 200 && isLootboxSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	
	}

	public void buyLootbox()
	{
		moneyAmount -= 200;
		PlayerPrefs.SetInt ("IsLootboxSold", 1);
		LootboxPrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("GameScene");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		LootboxPrice.text = "Price: 200$";
		PlayerPrefs.DeleteAll ();
	}

}
