namespace StringCalculator
{
	public static class Calculator
	{
		public static double Calculate(string sequence)
		{
			if (sequence.Length > 5)
			{
				var numbers = sequence.Split(' ');
				var first = double.TryParse(numbers[0], out var firstNumber);
				var second = double.TryParse(numbers[2], out var secondNumber);
				if (first && second)
				{
					switch (numbers[1])
					{
					case "+":
						return firstNumber+secondNumber;
					case "-":
						return firstNumber-secondNumber;
					case "*":
						return firstNumber*secondNumber;
					case "/":
						return firstNumber/secondNumber;
					default:
						return 0;
					}
				}
			}
			return 0;
		}
	}
}