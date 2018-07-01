
public class Sample
{

	//declare variables
	private int minimum = 0;
	private int maximum = 100;
	private int Tmp_Answer;

	void Start()
	{
		Debug.Log("Hello! I want you to pick a number range from 0 to 100");
		//calls the guessing function
		GuessNumber();
		
	}
	
	//Guessing Function
	void Update()
	{
		Debug.Log("If the number is Higher then click Up Arrow else Click Down Arrow");
		Do
		{
			Tmp_Answer = minimum + maximum /2;
			Debug.Log(Tmp_Answer);
			Debug.Log("Higher or lower?");	
			if (input.getKey(KeyCode.UpArrow))
			{
				minimum = Tmp_Answer;
				Debug.Log(minimum + maximum /2);
			}
			
			else if (input.getKey(KeyCode.DownArrow))
			{
				maximum = Tmp_Answer;
				Debug.Log(minimum + maximum /2);
			}
		}while (input.getKey(KeyCode.Space));
		Debug.Log("Correct!");
	}

	
	
}

	
	
	