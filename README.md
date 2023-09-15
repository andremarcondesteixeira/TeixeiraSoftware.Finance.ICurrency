# TeixeiraSoftware.Finance.ICurrency

This is just a simple interface that is used by the TeixeiraSoftware.Finance.Currency library.

```
    public interface ICurrency : IEquatable<ICurrency>
    {
        /// <summary>The symbol that uniquely identifies the currency</summary>
        string Symbol { get; }

        /// <summary>Tells if another currency is the same as this one</summary>
        /// <param name="other">The other currency that you want to compare</param>
        /// <returns>True if the currencies are the same, false otherwise</returns>
        new bool Equals(ICurrency other);
    }
```
