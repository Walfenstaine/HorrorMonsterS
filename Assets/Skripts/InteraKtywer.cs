using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraKtywer : MonoBehaviour
{
    public Sprite[] imgs;
    public GameObject tool;
    public LayerMask mask;
    public static InteraKtywer rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 2.1f, mask))
        {
            tool = hit.collider.gameObject;
            if (hit.collider.tag == "Tool")
            {
                Tollse.rid.cell.sprite = imgs[1];
            }
            if (hit.collider.tag == "Meh"|| hit.collider.tag == "Password")
            {
                Tollse.rid.cell.sprite = imgs[2];
            }
            if (hit.collider.tag == "Yee")
            {
                Tollse.rid.cell.sprite = imgs[3];
            }
        }
        else 
        {
            tool = null;
            Tollse.rid.cell.sprite = imgs[0];
        }

    }
    public void OnTached() 
    {
        if (tool != null) 
        {
            if (tool.tag == "Tool")
            {
                tool.GetComponent<Tool>().OnDataIndex();
            }
            if (tool.tag == "Password")
            {
                tool.GetComponent<PSSPanel>().AddPSS();
            }
            if (tool.tag == "Yee")
            {
                tool.GetComponent<List_Viver>().Open_List();
            }
            if (tool.tag == "Meh")
            {
                tool.GetComponent<Opener>().Open(Tollse.rid.index);
                Tollse.rid.Indexer(0);
            }
        }
    }
}
