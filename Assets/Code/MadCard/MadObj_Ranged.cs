using UnityEngine;


public class MadObj_Ranged : MadObj_Held
{
    [Header("REFS: Ranged")][Space(10)]
    public GameObject BreachObj;

    public GameObject Point_Shoot;
    public GameObject Point_Mag;
    public GameObject Point_Reload;
    public GameObject Point_Casing;

    public GameObject Addon_Stock;
    public GameObject Addon_Rail;
}
