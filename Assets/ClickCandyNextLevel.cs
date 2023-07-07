using UnityEngine;
using UnityEngine.UI;

public class ClickCandyNextLevel : MonoBehaviour
{
    [SerializeField] private Button _button;

    private BoxCollider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    protected void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            
            if (hit.collider is null)
                return;

            if (hit.collider.Equals(_collider)) 
                Click();
        }
    }

    private void Click()
    {
        _button.onClick.Invoke();
    }
}
