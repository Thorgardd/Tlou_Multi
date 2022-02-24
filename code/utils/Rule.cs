using Sandbox;

public class Rule
{
	private string CodeRule;

	public Rule( string codeRule )
	{
		CodeRule = codeRule;
	}

	public bool CheckIsValid(string value)
	{
		switch ( CodeRule )
		{
			case "NotBlank":
				return value.Length >= 1 ? true : false;
			default:
				return false;
		}
	}

	public string GetError()
	{
		switch ( CodeRule )
		{
			case "NotBlank":
				return "Le champ ne doit pas être vide !";
			default:
				return $"Une erreur est survenue, la règle qui porte le code {CodeRule} n'a pas été trouvée !";
		}
	}
	
	
}
