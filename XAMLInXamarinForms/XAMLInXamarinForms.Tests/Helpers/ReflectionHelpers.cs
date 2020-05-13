using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XAMLInXamarinForms.Tests.Helpers
{
    public static class ReflectionHelpers
    {
        private static readonly string _projectName = "XAMLInXamarinForms";

        public static Type GetUserType(string fullName)
        {
            return (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                    where assembly.FullName.StartsWith(_projectName)
                    from type in assembly.GetTypes()
                    where type.FullName == fullName
                    select type).FirstOrDefault();
        }
    }
}
