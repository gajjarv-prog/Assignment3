
public class Person : BaseClass
{
	// Properties for first and last name
	public string FirstName { get; set; }
	public string LastName { get; set; }

	// Constructor to initialize first and last name, with default empty strings
	public Person(string firstName = "", string lastName = "")
	{
		FirstName = firstName;
		LastName = lastName;
	}

	// Override the IsValidated method to check if both first and last names are provided
	public override bool IsValidated()
	{
		// Ensure FirstName is not null
		if (FirstName == null)
			FirstName = "";

		// Ensure LastName is not null
		if (LastName == null)
			LastName = "";

		// Check if both fields have values
		if (FirstName.Length > 0 && LastName.Length > 0)
			return true;
		else
			return false;
	}
}