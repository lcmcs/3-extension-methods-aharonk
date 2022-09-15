using ExtensionMethods;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTest
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ReverseTest()
        {
            "ab".Reversed().Should().Be("ba");
            "Ab".Reversed().Should().Be("bA");
            "".Reversed().Should().Be("");
            "abcA".Reversed().Should().Be("Acba");
            "abc ad".Reversed().Should().Be("da cba");
        }

        [TestMethod]
        public void TruePalindromeTest()
        {
            "aba".IsPalindrome().Should().BeTrue();
            "a.b.a".IsPalindrome().Should().BeTrue();
            "Aba".IsPalindrome().Should().BeTrue();
            "Abba".IsPalindrome().Should().BeTrue();
            "AbBa".IsPalindrome().Should().BeTrue();
            "Ab'Ba".IsPalindrome().Should().BeTrue();
            "".IsPalindrome().Should().BeTrue();
        }

        [TestMethod]
        public void FalsePalindromeTest()
        {
            "ab a".IsPalindrome().Should().BeFalse();
            "aba ".IsPalindrome().Should().BeFalse();
            "A.ba".IsPalindrome().Should().BeFalse();
            "abba.".IsPalindrome().Should().BeFalse();
            "abca".IsPalindrome().Should().BeFalse();
        }

        [TestMethod]
        public void GematriaTest()
        {
            "א".Gematria().Should().Be(1);
            "י".Gematria().Should().Be(10);
            "ק".Gematria().Should().Be(100);

            "נר".Gematria().Should().Be(250);
            "אבא".Gematria().Should().Be(4);
            "בכור".Gematria().Should().Be(228);
            "תשתרר".Gematria().Should().Be(1500);
        }

        [TestMethod]
        public void GematriaCornerTest()
        {
            "".Gematria().Should().Be(0);
            "abc".Gematria().Should().Be(0);
            "אb.".Gematria().Should().Be(1);
        }

        [TestMethod]
        public void GematriaEndTest()
        {
            "כ".Gematria().Should().Be(20);
            "ך".Gematria().Should().Be(20);

            "מ".Gematria().Should().Be(40);
            "ם".Gematria().Should().Be(40);

            "נ".Gematria().Should().Be(50);
            "ן".Gematria().Should().Be(50);

            "פ".Gematria().Should().Be(80);
            "ף".Gematria().Should().Be(80);

            "צ".Gematria().Should().Be(90);
            "ץ".Gematria().Should().Be(90);
        }
    }
}