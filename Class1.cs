using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SmallBasic.Library;


namespace JoshSB
{
    /// <summary>
    /// An extension I made which adds functions I regularly use into the language
    /// </summary>
    [SmallBasicType]
    public static class JoshSB
    {
    /// <summary>
    /// Checks if a number is even
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is even</returns>
    /// <example>JoshSB.isEven(2)</example>
    public static Primitive isEven(Primitive number)
    {
    if( (number % 2) == 0 )
    return true;
    else
    return false;
    }
    /// <summary>
    /// Checks if a number is odd
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is odd</returns>
    /// <example>JoshSB.isOdd(1)</example>
    public static Primitive isOdd(Primitive number)
    {
        if ((number % 2) == 0)
            return false;
        else
            return true;
    }
    }
}
