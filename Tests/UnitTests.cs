namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Ott()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Ott()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Ott()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
	
}
[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Ott()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-2, Program.Subtract("3", "5"));
	}

	[TestMethod]
	public void Subtract_Invalid_Ott()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
	}

	[TestMethod]
	public void Subtract_Null_Ott()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "2"));
	}
}


[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Ott()
	{
		Assert.AreEqual(6, Program.Multiply("2", "3"));
	}

	[TestMethod]
	public void Multiply_Invalid_Ott()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "3"));
	}

	[TestMethod]
	public void Multiply_Null_Ott()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "3"));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Ott()
	{
		Assert.AreEqual(2, Program.Divide("6", "3"));
	}

	[TestMethod]
	public void Divide_ByZero_Ott()
	{
		Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("6", "0"));
	}

	[TestMethod]
	public void Divide_Null_Ott()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "3"));
	}
}

[TestClass]
public class Exponentiation
{
	[TestMethod]
	public void Power_Valid_Ott()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("5", "0"));
	}

	[TestMethod]
	public void Power_Invalid_Ott()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("x", "2"));
	}

	[TestMethod]
	public void Power_Null_Ott()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
	}
}
