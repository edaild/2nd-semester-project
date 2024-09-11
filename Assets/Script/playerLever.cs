using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerLever : MonoBehaviour
{
    [Header("Player Level settings")]
    [Tooltip("current player level")]
    public float playerLevel = 1f;

    [Tooltip("Texxt component to display the player level")]
    public Text levelText;

    private const float MaxLevel = 60f;

    private void Update()
    {
        HandIeInput();
    }

    private void HandIeInput()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            IncreaseLevel();
        }
    }

    private void IncreaseLevel()
    {
        if (playerLevel < MaxLevel)
        {
            playerLevel += 1f;
            if (playerLevel >= MaxLevel)
            {
                playerLevel = MaxLevel;
                Debug.Log("�����մϴ�. �ִ� ������ �޼��ϼ̽��ϴ�.");
            }
        }
        else
        {
            Debug.Log("�� �̻��� ������ �ø� �� �����ϴ�.");
        }
    }

    private void updateleveldisplay()
    {
        levelText.text = $"Level {playerLevel}";
    }
}
