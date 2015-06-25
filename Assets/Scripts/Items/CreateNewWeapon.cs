using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
//	private string[] weaponNames = new string[6] ("Weapon of Greatness");

	void Start(){
		CreateWeapon();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.WeaponType);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.Stamina.ToString());
		Debug.Log (newWeapon.Endurance.ToString());

	
	}

	public void CreateWeapon(){

		newWeapon = new BaseWeapon ();

		//assign name to weapon
		newWeapon.ItemName = "W" + Random.Range (1, 101);
		//create weapon description
		newWeapon.ItemDescription = "This is a new Weapon.";
		//weapon ID
		newWeapon.ItemID = Random.Range (1, 101);
		//stats
		newWeapon.Stamina = Random.Range (1, 11);
		newWeapon.Endurance = Random.Range (1, 11);
		newWeapon.Intelligence = Random.Range (1, 11);
		newWeapon.Strength = Random.Range (1, 11);
		//choose type of weapon
		ChooseWeaponType ();
		//spell effect ID
		newWeapon.SpellEffectID = Random.Range (1, 101);
	
	}


	private void ChooseWeaponType(){
		//generates random number from 1 to 6
		//then set the type of weapon from WeaponTypes
		int randomTemp = Random.Range (1, 7);
		if (randomTemp == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}else if (randomTemp == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}else if (randomTemp == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		}else if (randomTemp == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}else if (randomTemp == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
		}else if (randomTemp == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
		}
	}
}
