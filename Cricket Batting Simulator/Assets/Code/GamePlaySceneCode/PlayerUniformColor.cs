//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUniformColor : MonoBehaviour
{
    //initialize variables
    public Material RRMaterial;
    public Material DCMaterial;
    public Material SRHMaterial;
    public Material PKMaterial;
    public Material LSGMaterial;
    public Material CSKMaterial;
    public Material MIMaterial;
    public Material KKRMaterial;
    public Material GTMaterial;
    public Material RCBMaterial;

    //this function is called once when the page is first loaded
    //this function sets the uniform color of the players based on the team the user is playing as
    public void Start()
    {
        string selectedTeam = GetString("SelectedTeam");

        if (selectedTeam == "RR")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = RRMaterial;
        }
        if (selectedTeam == "DC")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = DCMaterial;
        }
        if (selectedTeam == "SRH")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = SRHMaterial;
        }
        if (selectedTeam == "PK")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = PKMaterial;
        }
        if (selectedTeam == "LSG")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = LSGMaterial;
        }
        if (selectedTeam == "CSK")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = CSKMaterial;
        }
        if (selectedTeam == "MI")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = MIMaterial;
        }
        if (selectedTeam == "KKR")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = KKRMaterial;
        }
        if (selectedTeam == "GT")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = GTMaterial;
        }
        if (selectedTeam == "RCB")
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = RCBMaterial;
        }
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string keyname)
    {
        return PlayerPrefs.GetString(keyname);
    }
}
