using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;

    public void ShowDeathScreen()
    {
        deathScreen.SetActive(true);
        StartCoroutine(DeathScreenCoroutine());
    }

    private IEnumerator DeathScreenCoroutine()
    {
        yield return new WaitForSeconds(2.5f);
        deathScreen.SetActive(false);
    }
}
