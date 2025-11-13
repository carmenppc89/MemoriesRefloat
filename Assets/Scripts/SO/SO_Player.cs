using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_Player", menuName = "Scriptables/Player")]
public class SO_Player : ScriptableObject
{
    [Serializable]
    public class ItemSlot
    {
        //[SerializeField] public ObjecteScriptable objecte;
        [SerializeField] public int idObj;
        [SerializeField] public int quantitat;

        //public ItemSlot(ObjecteScriptable obj)
        //{
        //    objecte = obj;
        //    idObj = obj.idObj;
        //    quantitat = 1;
        //}

        public ItemSlot(int id, int q)
        {
            idObj = id;
            quantitat = q;
            //objecte = BaseDades.Instance.BuscarSOObjecte(id);
        }
    }

    [Header("Inventaris")]
    public List<ItemSlot> inventariPlayer;
    public List<ItemSlot> inventariVaixell;
    public List<ItemSlot> inventariEsquers;

    [Header("Vaixell")]
    public float benzinaMax;
    public float benzinaActual;
    public float distanciaPerConsmir;
    public float speedVaixell = 1000;

    [Header("Basics")]
    public int diners;

    [Header("Eines")]
    public int numBombonesOX;


    //private PlayerScriptable.ItemSlot ItemAux;

    //public void CapturaPeix(PeixScriptable peix)
    //{
    //    BuscaLlista(inventariVaixell, peix);
    //}

    //public void EmmagatzemaVaixell(ObjecteScriptable objecte)
    //{
    //    BuscaLlista(inventariVaixell, objecte);
    //}

    //public void Emmagatzemar(ObjecteScriptable obj, bool isVaixell)
    //{
    //    if (isVaixell)
    //    {
    //        Debug.Log(string.Format("Afegint {0} a invVaixell", obj.nom));
    //        BuscaLlista(inventariVaixell, obj);
    //    }
    //    else
    //    {
    //        Debug.Log(string.Format("Afegint {0} a invPlayer", obj.nom));
    //        BuscaLlista(inventariPlayer, obj);
    //    }
    //}

    //public void EmmagatzemarEsquers(CraftScriptable obj)
    //{
    //    BuscaLlista(inventariEsquers, obj);
    //}
    //private void BuscaLlista(List<ItemSlot> llista, ObjecteScriptable objecte)
    //{
    //    Debug.Log(string.Format("Afegint {0}", objecte.nom));
    //    ItemSlot item = llista.FirstOrDefault(slot => slot.objecte == objecte);
    //    if (item != null)
    //    {
    //        item.quantitat++;
    //    }
    //    else
    //    {
    //        llista.Add(new ItemSlot(objecte));
    //    }
    //}

    //public bool DeudaCheck()
    //{
    //    if (diners < 0)
    //        return true;
    //    else
    //        return false;
    //}

    //public void Load(GameData data)
    //{
    //    diners = data.playerAttributes.diners;
    //    benzinaActual = data.playerAttributes.benzinaActual;
    //    benzinaMax = data.playerAttributes.benzinaMax;
    //    numBombonesOX = data.playerAttributes.numBombonesOX;

    //    inventariPlayer.Clear();
    //    foreach (PlayerAttributesData.ItemSlot itemSlot in data.playerAttributes.inventariPlayer)
    //    {
    //        ItemSlot item = new ItemSlot(itemSlot.idObj, itemSlot.quantitat);
    //        inventariPlayer.Add(item);
    //    }
    //}

    //public int quantObj(ObjecteScriptable objecte)
    //{
    //    ItemAux = inventariPlayer.FirstOrDefault(obj => obj.idObj == objecte.idObj);
    //    if (ItemAux == null)
    //        return 0;
    //    else
    //    {
    //        Debug.Log("Hay esto: " + ItemAux.quantitat);
    //        return ItemAux.quantitat;
    //    }

    //}

    //public void treureObj(ObjecteScriptable objecte, int quant)
    //{
    //    ItemAux = inventariPlayer.FirstOrDefault(obj => obj.idObj == objecte.idObj);
    //    ItemAux.quantitat -= quant;
    //}
}
