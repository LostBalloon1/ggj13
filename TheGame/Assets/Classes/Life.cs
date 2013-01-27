using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    public int hp = 10;
	private Ressource ressource;
	public int numRessource = 1;
	protected GameObject lifeBar;

	// Use this for initialization
	void Start () {
		ressource = (Ressource)FindObjectOfType(typeof(Ressource)) as Ressource;
		lifeBar = transform.FindChild("LifeBar").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		changeLifeBar();
	}

    public void takeDamage(int amount)
    {
		hp -= amount;
        if (hp <= 0)
        {
			if(ressource != null)
			{
				ressource.takeRessource(numRessource);
			}
			Destroy(this.gameObject);//kill me -> look into the function Destroy
        }
    }
	
	protected void changeLifeBar()
   	{
        Texture texture = null;
		int life = hp;
		switch(life)
        {
            case 0: texture = Resources.Load("HUD_Bar_0", typeof(Texture)) as Texture; break;
			case 1: texture = Resources.Load("HUD_Bar_3", typeof(Texture)) as Texture; break;
			case 2: texture = Resources.Load("HUD_Bar_6", typeof(Texture)) as Texture; break;
			case 3: texture = Resources.Load("HUD_Bar_9", typeof(Texture)) as Texture; break;
			case 4: texture = Resources.Load("HUD_Bar_12", typeof(Texture)) as Texture; break;
			case 5: texture = Resources.Load("HUD_Bar_15", typeof(Texture)) as Texture; break;
			case 6: texture = Resources.Load("HUD_Bar_18", typeof(Texture)) as Texture; break;
			case 7: texture = Resources.Load("HUD_Bar_21", typeof(Texture)) as Texture; break;
			case 8: texture = Resources.Load("HUD_Bar_24", typeof(Texture)) as Texture; break;
			case 9: texture = Resources.Load("HUD_Bar_27", typeof(Texture)) as Texture; break;
			case 10: texture = Resources.Load("HUD_Bar_29", typeof(Texture)) as Texture; break;
			default: texture = Resources.Load("HUD_Bar_29", typeof(Texture)) as Texture; break;
        }
		if(texture != null && lifeBar != null){
			lifeBar.renderer.material.mainTexture = texture;
		}
    }
}
