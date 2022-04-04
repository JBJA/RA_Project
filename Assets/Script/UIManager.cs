using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject ItemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
    }

    private void ActivateMainMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).DOMoveY(300, 0.3f);
    }

    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

}
