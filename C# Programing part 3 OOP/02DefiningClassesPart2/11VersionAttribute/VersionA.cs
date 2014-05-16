namespace _11VersionAttribute
{
    using System;

    [Version(2,11)]
    class VersionA
    {
        // Check for the attribute in the VersionAttribute file
        static void Main()
        {
            Type attributeVersion = typeof(VersionA);
            object[] allAttributes = attributeVersion.GetCustomAttributes(false);
            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine("Version is [{0},{1}]", item.Major, item.Minor);
            }
        }
    }
}
