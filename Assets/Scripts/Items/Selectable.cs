using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public void SelectThis()
    {
        SelectableManager.instance.SetSelected(this);
    }
}
