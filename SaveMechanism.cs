using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveMechanism : MonoBehaviour {

	public GameObject Walls;
	public GameObject Floors;
	public GameObject Chairs;
	public GameObject Tables;
	public GameObject Pillars;
	public GameObject Bed;
	public GameObject BedSideTable;
	public GameObject WallWithDoor;
	public GameObject WallWithWindow;

	public GameObject src_Walls;
	public GameObject src_Floors;
	public GameObject src_Chairs;
	public GameObject src_Tables;
	public GameObject src_Pillars;
	public GameObject src_Bed;
	public GameObject src_BedSideTable;
	public GameObject src_WallWithDoor;
	public GameObject src_WallWithWindow;

	GameObject instantiateObject;
	GameObject parent;
	float scaleFactor;

	string fileName = "Default";

	public void saveOnClick(GameObject saveAck)
	{
		Save ();
		saveAck.SetActive (true);
	}

	public void loadOnClick(GameObject loadAck)
	{
			Load ();
		loadAck.SetActive (true);
	}
	void Load()
	{
		fileName = MapTitleScript.fileName + "_m.xml";
		objectCollection collection = new objectCollection ();
		XmlSerializer deserializer = new XmlSerializer (typeof(objectCollection));
		FileStream stream = new FileStream (Path.Combine (Application.dataPath,fileName), FileMode.Open);
		collection = deserializer.Deserialize (stream) as objectCollection;

		foreach (Transform child in Walls.transform)
			Destroy (child.gameObject);
		foreach (Transform child in Floors.transform)
			Destroy (child.gameObject);
		foreach (Transform child in Chairs.transform)
			Destroy (child.gameObject);
		foreach (Transform child in Tables.transform)
			Destroy (child.gameObject);
		foreach (Transform child in Pillars.transform)
			Destroy (child.gameObject);
		foreach (Transform child in Bed.transform)
			Destroy (child.gameObject);
		foreach (Transform child in BedSideTable.transform)
			Destroy (child.gameObject);
		foreach (Transform child in WallWithDoor.transform)
			Destroy (child.gameObject);
		foreach (Transform child in WallWithWindow.transform)
			Destroy (child.gameObject);


		foreach (Object obj in collection.objects) 
		{

			if (obj.name == "Walls") 
			{
				instantiateObject = src_Walls;
				parent = Walls;
				scaleFactor = 3.0f;
			}

			if (obj.name == "floors") 
			{
				instantiateObject = src_Floors;
				parent = Floors;
				scaleFactor = 3.0f;
			}

			if (obj.name == "chairs") 
			{
				instantiateObject = src_Chairs;
				parent = Chairs;
				scaleFactor = 1.0f;
			}

			if (obj.name == "tables") 
			{
				instantiateObject = src_Tables;
				parent = Tables;
				scaleFactor = 1.0f;
			}

			if (obj.name == "pillers") 
			{
				instantiateObject = src_Pillars;
				parent = Pillars;
				scaleFactor = 3.0f;
			}

			if (obj.name == "bed") 
			{
				instantiateObject = src_Bed;
				parent = Bed;
				scaleFactor = 3.0f;
			}

			if (obj.name == "bedsidetable") 
			{
				instantiateObject = src_BedSideTable;
				parent = BedSideTable;
				scaleFactor = 1.0f;
			}

			if (obj.name == "wallwithdoor") 
			{
				instantiateObject = src_WallWithDoor;
				parent = WallWithDoor;
				scaleFactor = 3.0f;
			}

			if (obj.name == "wallwithwindow") 
			{
				instantiateObject = src_WallWithWindow;
				parent = WallWithWindow;
				scaleFactor = 3.0f;
			}

			GameObject createdObject = Instantiate (instantiateObject) as GameObject;
			createdObject.transform.localScale = instantiateObject.transform.localScale * scaleFactor;
			createdObject.transform.parent = parent.transform;
			createdObject.transform.localPosition = new Vector3 (obj.posx, obj.posy, obj.posz);
			createdObject.transform.localRotation = Quaternion.Euler (new Vector3 (0f, obj.roty, 0f));
			 
		}
	}

	void Save()
	{
		objectCollection collection = new objectCollection ();

		// for walls
		foreach (Transform child in Walls.transform) {
			Object obj = new Object ();
			obj.name="Walls";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for floors
		foreach (Transform child in Floors.transform) {
			Object obj = new Object ();
			obj.name="floors";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for chairs
		foreach (Transform child in Chairs.transform) {
			Object obj = new Object ();
			obj.name="chairs";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}
			
		// for Tabels
		foreach (Transform child in Tables.transform) {
			Object obj = new Object ();
			obj.name="tables";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for Pillers
		foreach (Transform child in Pillars.transform) {
			Object obj = new Object ();
			obj.name="pillers";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for Bed
		foreach (Transform child in Bed.transform) {
			Object obj = new Object ();
			obj.name="bed";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for BedSideTable
		foreach (Transform child in BedSideTable.transform) {
			Object obj = new Object ();
			obj.name="bedsidetable";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for wallwithdoor
		foreach (Transform child in WallWithDoor.transform) {
			Object obj = new Object ();
			obj.name="wallwithdoor";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		// for WallWithWindow
		foreach (Transform child in WallWithWindow.transform) {
			Object obj = new Object ();
			obj.name="wallwithwindow";
			obj.posx=child.transform.localPosition.x;
			obj.posy=child.transform.localPosition.y;
			obj.posz=child.transform.localPosition.z;
			obj.roty = child.transform.localRotation.eulerAngles.y;
			collection.objects.Add (obj);
		}

		fileName = MapTitleScript.fileName + "_m.xml";
		XmlSerializer serializer = new XmlSerializer (typeof(objectCollection));
		FileStream stream = new FileStream (Path.Combine (Application.dataPath,fileName), FileMode.Create);
		serializer.Serialize (stream, collection);
		stream.Close ();

	}

	[XmlRoot("objectCollection")]
	public class objectCollection
	{
		[XmlArray("objects"),XmlArrayItem("object")]
		public List<Object> objects = new List<Object> ();
	}

	public class Object
	{
		[XmlAttribute("type")]
		public string name;

		[XmlElement("pos_x")]
		public float posx;

		[XmlElement("pos_y")]
		public float posy;

		[XmlElement("pos_z")]
		public float posz;

		[XmlElement("rot_y")]
		public float roty;
	}
}