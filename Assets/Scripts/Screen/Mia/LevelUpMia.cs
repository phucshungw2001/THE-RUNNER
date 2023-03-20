using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpMia : MonoBehaviour
{
    public Canvas canvas;
    public Image image;
    public bool isShowing = false;
    public PlayerJohnMove player;
    public PlayerMiaMove player2;
    private Transform imageTransform;
    private void Start()
    {
        player = FindObjectOfType<PlayerJohnMove>();
        player2 = FindObjectOfType<PlayerMiaMove>() == null ? null : FindObjectOfType<PlayerMiaMove>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        // Hide the level up screen when the scene starts
        imageTransform = canvas.transform.Find("LevelUp");
        image = imageTransform.GetComponent<Image>();
    }

    private void Update()
    {
        if (player != null)
        {
            if (player.John.level > 1 && player.isLevelUp)
            {
                for (int i = 0; i < imageTransform.transform.childCount; i++)
                {
                    var child = imageTransform.transform.GetChild(i).gameObject;
                    if (child != null)
                        if (child.CompareTag("levelTxt"))
                        {
                            child.GetComponent<TextMeshProUGUI>().text = "You are now level " + player.John.level;
                        }
                    child.SetActive(true);
                }
                image.enabled = true;
                Time.timeScale = 0f; // Stop the game
            }
            else
            {
                image.enabled = false;
                for (int i = 0; i < imageTransform.transform.childCount; i++)
                {
                    var child = imageTransform.transform.GetChild(i).gameObject;
                    if (child != null)
                        child.SetActive(false);
                }
            }
        }

        if (player2 != null)
        {
            if (player2.Mia.level > 1 && player2.isLevelUp)
            {
                for (int i = 0; i < imageTransform.transform.childCount; i++)
                {
                    var child = imageTransform.transform.GetChild(i).gameObject;
                    if (child != null)
                        if (child.CompareTag("levelTxt"))
                        {
                            child.GetComponent<TextMeshProUGUI>().text = "You are now level " + player2.Mia.level;
                        }
                    child.SetActive(true);
                }
                image.enabled = true;
                Time.timeScale = 0f; // Stop the game
            }
            else
            {
                image.enabled = false;
                for (int i = 0; i < imageTransform.transform.childCount; i++)
                {
                    var child = imageTransform.transform.GetChild(i).gameObject;
                    if (child != null)
                        child.SetActive(false);
                }
            }
        }
        // Show the level up screen when the player levels up

    }

    public void UpgradeAtkSpeed()
    {
        if (player != null)
        {
            player.John.atkSpeed += (player.John.atkSpeed * 5) / 100;
        }
        if (player2 != null)
        {
            player2.Mia.atkSpeed += (player2.Mia.atkSpeed * 5) / 100;
        }
        CloseLevelUpScreen();
    }

    public void UpgradeAtkDamage()
    {
        if (player != null)
        {
            player.John.damage += (player.John.damage * 20) / 100;
        }
        if (player2 != null)
        {
            player2.Mia.damage += (player2.Mia.damage * 20) / 100;
        }
        // TODO: Handle upgrade option 2
        CloseLevelUpScreen();
    }

    public void UpgradeMaxHealth()
    {
        if (player != null)
        {
            player.John.bloodMax += (player.John.bloodMax * 20) / 100;
        }
        if (player2 != null)
        {
            player2.Mia.bloodMax += (player2.Mia.bloodMax * 20) / 100;
        }
        // TODO: Handle upgrade option 3
        CloseLevelUpScreen();
    }

    public void UpgradeHeal()
    {
        if (player != null)
        {
            player.John.blood += player.John.bloodMax / 2;
            if (player.John.blood > player.John.bloodMax)
            {
                player.John.blood = player.John.bloodMax;
            }
        }
        if (player2 != null)
        {
            player2.Mia.blood += player2.Mia.bloodMax / 2;
            if (player2.Mia.blood > player2.Mia.bloodMax)
            {
                player2.Mia.blood = player2.Mia.bloodMax;
            }
        }
        // TODO: Handle upgrade option 4
        CloseLevelUpScreen();
    }

    public void UpgradeMovementSpeed()
    {
        if (player != null)
        {
            player.John.moveSpeed += (player.John.moveSpeed * 10) / 100;
        }
        if (player2 != null)
        {
            player2.Mia.moveSpeed += (player2.Mia.moveSpeed * 10) / 100;
        }
        // TODO: Handle upgrade option 5
        CloseLevelUpScreen();
    }

    private void CloseLevelUpScreen()
    {
        Debug.Log("bsdhvbsdssvv");
        // Hide the level up screen and resume the game
        image.enabled = false;
        Time.timeScale = 1f; // Resume the game
        // player.isLevelUp = false;
        player2.isLevelUp = false;
        isShowing = false;
    }
}
