using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SmallBasic.Library;

namespace JoshSB
{
    /// <summary>
    /// An extension I made which adds functions I regularly use and some new ones into the language
    /// </summary>
    [SmallBasicType]
    public static class JoshSB
    {
    /// <summary>
    /// Checks if a specified value is even
    /// </summary>
    /// <param name="value">The value to check</param>
    /// <returns>True if the value is even</returns>
    /// <example>JoshSB.isEven(2)</example>
    public static Primitive isEven(Primitive value)
    {
    if( (value % 2) == 0 )
    return true;
    else
    return false;
    }
    /// <summary>
    /// Checks if a specified value is odd
    /// </summary>
    /// <param name="number">The value to check</param>
    /// <returns>True if the number is odd</returns>
    /// <example>JoshSB.isOdd(1)</example>
    public static Primitive isOdd(Primitive number)
    {
        if ((number % 2) == 0)
            return false;
        else
            return true;
    }
    /// <summary>
    /// Gets the user name of the person who is currently logged on to the Windows operating system
    /// </summary>
    /// <returns>
    /// The user name of the person who is currently logged on to the Windows operating system.
    /// </returns>
    /// <example>
    /// username = JoshSB.CurrentUser
    /// </example>
    public static Primitive CurrentUser
    {
        get    
        {
            return (Primitive)Environment.UserName;
        }
    }
    /// <summary>
    /// Gets the fully qualified path of the current working directory
    /// </summary>
    /// <returns>
    /// The fully qualified path of the current working directory
    /// </returns>
    /// <example>
    /// dir = JoshSB.WorkingDir
    /// </example>
    public static Primitive WorkingDir
    {
        get
        {
            return (Primitive)Environment.CurrentDirectory;
        }
    }
    /// <summary>
    /// Gets the NetBIOS name of this local computer
    /// </summary>
    /// <returns>
    /// The NetBIOS name of this local computer
    /// </returns>
    /// <example>
    /// netbios_name = JoshSB.ComputerName
    /// </example>
    public static Primitive ComputerName
    {
        get
        {
            return (Primitive)Environment.MachineName;
        }
    }
    /// <summary>
    /// Gets the network domain name associated with the current user
    /// </summary>
    /// <returns>
    /// The network domain name associated with the current user
    /// </returns>
    /// <example>
    /// domain = JoshSB.CurrentDomain
    /// </example>
    public static Primitive CurrentDomain
    {
        get
        {
            return (Primitive)Environment.UserDomainName;
        }
    }
    /// <summary>
    /// Gets the number of milliseconds elapsed since the system started
    /// </summary>
    /// <returns>
    /// The number of milliseconds elapsed since the system started
    /// </returns>
    /// <example>
    /// uptime = JoshSB.Uptime
    /// </example>
    public static Primitive Uptime
    {
        get
        {
            return (Primitive)Environment.TickCount;
        }
    }
    }
}
