using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallenge.FamilyTree;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void if_the_person_exists_in_tree_the_result_should_be_january()
        {
            var person = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(person, "Joe");

            Assert.AreEqual("January", result);
        }

        [TestMethod]
        public void if__the_person_exists_at_the_top_tree_the_result_should_be_may()
        {
            var person = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(person, "Ted");

            Assert.AreEqual("May", result);
        }

        [TestMethod]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var person = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(person, "Jeebus");

            Assert.AreEqual("", result);
        }
    }
}
