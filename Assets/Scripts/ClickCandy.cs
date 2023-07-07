using UnityEngine;

public class ClickCandy : MonoBehaviour
{
    private Animator _animator;
    private BoxCollider2D _collider;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
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
                Animation();
        }
    }

    protected void Animation()
    {
        _animator.SetTrigger("isClicked");
    }
}
