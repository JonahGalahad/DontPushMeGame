using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoController : MonoBehaviour
{
    [SerializeField] private GameObject dialogo; 
    [SerializeField] private GameObject panelDialogo;
    [SerializeField] private TMP_Text text;
    [SerializeField] private string[] lineasDialogo;

    private float timeTipeo = 0.05f;
    private bool enRango;
    private bool hacerDialogo;
    private int lineIndex;

    void Update()
    {
        if(enRango && Input.GetKeyDown(KeyCode.E))
        {
            if (!hacerDialogo)
            {
                ComenzarDialogo();
            } else if (text.text == lineasDialogo[lineIndex])
            {
                NextDialogoLine();
            } else
            {
                StopAllCoroutines();
                text.text = lineasDialogo[lineIndex];
            }
        }
    }

    private void ComenzarDialogo()
    {
        hacerDialogo=true;
        panelDialogo.SetActive(true);
        dialogo.SetActive(true);
        lineIndex = 0;
        StartCoroutine(showLine());

    }

    private void NextDialogoLine()
    {
        lineIndex++;
        if (lineIndex < lineasDialogo.Length)
        {
            StartCoroutine(showLine());
        } else {
            hacerDialogo = false;
            panelDialogo.SetActive(false);
            dialogo.SetActive(false);
        }

    }
    private IEnumerator showLine ()
    {
        text.text = string.Empty;

        foreach (char item in lineasDialogo[lineIndex])
        {
            text.text += item;
            yield return new WaitForSecondsRealtime(timeTipeo);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enRango = true;
            dialogo.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enRango = false;
            dialogo.SetActive(false);
        }

    }
}
