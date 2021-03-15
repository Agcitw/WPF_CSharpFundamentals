﻿namespace ClassLibrary
{
	public class ValidatorBuilderStr1<T> : Builder<T>
	{
		public override void Build()
		{
			ConcreteConcreteValidator.AddRule(Rules.IsNotNull);
		}
	}
	
	public class ValidatorBuilderStr2<T> : Builder<T>
	{
		public override void Build()
		{
			ConcreteConcreteValidator.AddRule(Rules.IsStringWithoutUpperChars);
		}
	}

	public class ValidatorBuilderInt1<T> : Builder<T>
	{
		public override void Build()
		{
			ConcreteConcreteValidator.AddRule(Rules.IsPositiveNumber);
		}
	}
	
	public class ValidatorBuilderInt2<T> : Builder<T>
	{
		public override void Build()
		{
			ConcreteConcreteValidator.AddRule(Rules.IsZero);
		}
	}
}