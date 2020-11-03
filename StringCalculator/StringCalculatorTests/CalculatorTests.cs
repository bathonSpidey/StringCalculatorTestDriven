using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
	public class CalculatorTests
	{
		[Test]
		public void Nothing() => Assert.That(Calculator.Calculate(""), Is.EqualTo(0));

		[Test]
		public void CheckValidSequence() => Assert.That(Calculator.Calculate("4+5"), Is.EqualTo(0));

		[Test]
		public void CheckIncompleteSequence() => Assert.That(Calculator.Calculate("4 + "), Is.EqualTo(0));

		[Test]
		public void AddTwoNumbers() => Assert.That(Calculator.Calculate("1.0 + 1.0"), Is.EqualTo(1 + 1));

		[Test]
		public void SubtractTwoNumbers()
			=> Assert.That(Calculator.Calculate("2.0 - 1.0"), Is.EqualTo(2 - 1));
	}
}