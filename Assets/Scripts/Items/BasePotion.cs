using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public enum PotionTypes{
		HEALTH,
		ENERGY,
		STRENGTH,
		INTELLIGENCE,
		VITALITY,
		ENDURANCE,
		SPEED
	}

	private PotionTypes potionType;
	private int spellEffectsID;

	public PotionTypes PotionType{
		get{ return potionType;}
		set{ potionType = value;}
	}

	public int SpellEffectID {
		get{ return spellEffectsID;}
		set{ spellEffectsID = value;}
	}

}
