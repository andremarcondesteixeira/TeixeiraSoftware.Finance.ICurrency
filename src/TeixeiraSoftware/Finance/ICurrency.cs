using System;

namespace TeixeiraSoftware.Finance
{
    /// <summary>
    /// The <see cref="ICurrency" /> interface defines a boundary so that any concrete
    /// implementations of it can be refered as being an <see cref="ICurrency" /> type
    /// </summary>
    public interface ICurrency : IEquatable<ICurrency>
    {
        /// <summary>The symbol that uniquely identifies the currency</summary>
        string Symbol { get; }

        /// <summary>Tells if another currency is the same as this one</summary>
        /// <param name="other">The other currency that you want to compare</param>
        /// <returns>True if the currencies are the same, false otherwise</returns>
        new bool Equals(ICurrency other);
    }
}
