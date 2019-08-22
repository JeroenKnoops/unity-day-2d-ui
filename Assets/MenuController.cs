using UnityEngine;

public class MenuController : MonoBehaviour
{
  public GameObject MenuPanel;
  public GameObject ButtonPrefab;

  public GameObject MenuCanvas;

  public void Start()
  {
    var newButton = Instantiate(ButtonPrefab);
    newButton.transform.SetParent(MenuPanel.transform);

    var script = newButton.GetComponent<MenuItem>();
    script.Initialize("Close Menu", CloseMenuPlz);
  }

  private void CloseMenuPlz()
  {
    Debug.Log("now close the menu plzkthxbye");
    MenuCanvas.SetActive(false);
  }
}
