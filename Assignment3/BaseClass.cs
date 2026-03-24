public class BaseClass
{
	// Virtual method for validation, can be overridden by derived classes
	public virtual bool IsValidated()
	{
		return false; // Default validation returns false
	}
}