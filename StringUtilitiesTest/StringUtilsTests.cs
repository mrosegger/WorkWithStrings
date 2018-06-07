using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;


namespace StringUtilitiesTest
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void countSmall_e_actualString_returnAmount()
        {
            //Arrange
            string testtext = "A simple sentence.";
            int expected = 2;
            //Act
            int actual = stringUtility.countACharWithShorterForeach(testtext, 'e');
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void countSmall_e_emtyString_returnZero()
        {
            //Arange
            string testtext = "   ";
            int expected = 0;
            //Act
            int actual = stringUtility.countACharWithShorterForeach(testtext, 'e');
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFirstWordFromString_StringWithNormalSentence_FirstWord()
        {
            //Arange
            string testtext = "A simple sentence.";
            string expected = "A";
            //Act
            string actual = stringUtility.GetFirstWordFromString(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFirstWordFromString_StringWithSpacesBeforeWord_FirstWord()
        {
            //Arange
            string testtext = "     A simple sentence.";
            string expected = "A";
            //Act
            string actual = stringUtility.GetFirstWordFromString(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFirstWordFromString_EmptyString_emtyString()
        {
            //Arange
            string testtext = "";
            string expected = "";
            //Act
            string actual = stringUtility.GetFirstWordFromString(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFirstWordFromString_StringWithValueNull_EmptyString()
        {
            //Arange
            string testtext = null;
            string expected = null;
            //Act
            string actual = stringUtility.GetFirstWordFromString(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFirstWordFromString_StringWithoutSpace_completeString()
        {
            //Arange
            string testtext = "Hello";
            string expected = "Hello";
            //Act
            string actual = stringUtility.GetFirstWordFromString(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPalindrom_StringWithReliefpfeiler_true()
        {
            //Arange 
            string testtext = "reliefppfeiler";
            bool expected = true;
            //Act 
            bool actual = stringUtility.IsPalindrom(testtext);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
