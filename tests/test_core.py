"""Core testing file from real_fractions package.

Classes:
    TestFraction(): Test Fraction class from core module.
"""

from real_fractions import Fractions

class TestFraction(Fractions):
    """Test Fraction class from core.

    Tests:
        test_separate_numbers(): Test separate_numbers method from Fractions.
        test_sign_checker(): Test sign_checker method from Fractions.
        test_simplify(): Test simplify method from Fractions.
        test_zero_checker(): Test zero_checker method from Fractions.
    """

    def test_separate_numbers(self):
        """Test separate_numbers method from Fractions."""

        # Normal cases
        assert self.separate_numbers("5/10") == (5, 10)
        assert self.separate_numbers("-123/456") == (-123, 456)
        assert self.separate_numbers("10/-0") == (10, 0)
        assert self.separate_numbers("-12/-12") == (-12, -12)

        # Invalid arguments
        assert self.separate_numbers(243) is None
        assert self.separate_numbers("Error") is None
        assert self.separate_numbers("This is/an Error") is None

    def test_sign_checker(self):
        """Test sign_checker method from Fractions."""

        # Normal cases
        assert self.sign_checker("5/10") == "5/10"
        assert self.sign_checker("-123/456") == "-123/456"
        assert self.sign_checker("10/-2") == "-10/2"
        assert self.sign_checker("-20/-2") == "20/2"

        # Invalid arguments
        assert self.sign_checker("10/0") is None
        assert self.sign_checker(True) is None
        assert self.sign_checker("Error") is None

    def test_simplify(self):
        """Test simplify method from Fractions."""

        # Normal cases
        assert self.simplify("5/10") == "1/2"
        assert self.simplify("-12/4") == "-3/1"
        assert self.simplify("10/-2") == "-5/1"
        assert self.simplify("-20/-2") == "10/1"

        # Invalid arguments
        assert self.simplify("10/0") is None
        assert self.simplify(True) is None
        assert self.simplify("Error") is None

    def test_zero_checker(self):
        """Test zero_checker method from Fractions."""

        # Normal cases
        assert not self.zero_checker("5/10", "-5/10")
        assert not self.zero_checker("-5/10", "5/10")
        assert not self.zero_checker("5/-10", "5/10")
        assert self.zero_checker("5/10", "5/10")
        assert self.zero_checker("521/10", "-5/10")
        assert self.zero_checker("5/10", "32/-10")
        assert self.zero_checker("5/-10", "5/-10")
        assert self.zero_checker("-5/10", "-5/10")

        # Invalid arguments
        assert self.zero_checker("this is", "an error") is None
        assert self.zero_checker("Error", "123/456") is None
        assert self.zero_checker("123/456", "Error") is None
        assert self.zero_checker(240, 234.5) is None
