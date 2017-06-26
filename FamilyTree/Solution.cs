using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            if (person.Name == descendantName)
            {
                return person.Birthday.ToString("MMMM");
            }

            foreach (var descendant in person.Descendants)
            {
                if (descendant.Name == descendantName)
                {
                    return descendant.Birthday.ToString("MMMM");
                }
            }

            foreach (var descendant in person.Descendants)
            {
                GetBirthMonth(descendant, descendantName);
            }

            return "";
        }
    }
}