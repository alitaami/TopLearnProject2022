using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.Generator
{
    public class NameGenerator
    {
        public static string GenerateUniqueCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
 
}
