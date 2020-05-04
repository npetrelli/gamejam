﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
	public int index = 0; //Номер предмета, в этой игре будет всего 3 типа брони, поэтому писать более сложный скрипт нет смысла
	public Slot slot;
	public Inventory inv;
	public Sprite sprite;

    void OnMouseDown()
    {
		inv.item = sprite;
		Debug.Log(inv.item);
		Destroy(gameObject); //Удаление объекта с карты
	}
}
