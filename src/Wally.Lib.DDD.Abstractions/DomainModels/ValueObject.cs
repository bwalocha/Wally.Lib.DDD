using System;
using Wally.Lib.DDD.Abstractions.Validators;

namespace Wally.Lib.DDD.Abstractions.DomainModels
{
	public abstract class ValueObject
	{
		protected static void CheckRule(IBusinessRule rule)
		{
			if (rule.IsBroken())
			{
				// TODO: 
				// throw new DomainValidationException(rule);

				throw new NotImplementedException();
			}
		}
	}
}
