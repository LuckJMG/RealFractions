"""Convert testing file from real_fractions package.

Classes:
    TestConvertFraction(): Test ConvertFraction class convert.
"""

from real_fractions import ConvertFractions

class TestConvertFraction(ConvertFractions):
    """Test ConvertFraction class convert.

    Tests:
        test_to_decimal(): Test to_decimal method from ConvertFractions.
        test_to_mixed_number():
            Test to_mixed_number method from ConvertFractions.
        test_to_fraction(): Test to_fraction method from ConvertFractions.
    """

    def test_to_decimal(self):
        """Test to_decimal method from ConvertFractions."""

        # Normal cases
        assert self.to_decimal("5/10") == 0.5
        assert self.to_decimal("123/456", 2) == 0.27
        assert self.to_decimal("-123/456") == -0.26973684210526316
        assert self.to_decimal("1/-3", 3) == -0.333
        assert self.to_decimal("-5/-3", 1) == 1.7

        # Invalid arguments
        assert self.to_decimal(243) is None
        assert self.to_decimal("Error", "This is") is None

    def test_to_mixed_number(self):
        """Test to_mixed_number method from ConvertFractions."""

        # Normal cases
        assert self.to_mixed_number("13/10") == "1 3/10"
        assert self.to_mixed_number("-25/10") == "-2 1/2"
        assert self.to_mixed_number("-15/-10") == "1 1/2"
        assert self.to_mixed_number("34/-10") == "-3 2/5"
        assert self.to_mixed_number("-123/456") == "-123/456"
        assert self.to_mixed_number("10/-2") == -5
        assert self.to_mixed_number("-20/-2") == 10

        # Invalid arguments
        assert self.to_mixed_number("10/0") is None
        assert self.to_mixed_number("Bug 10/3") is None
        assert self.to_mixed_number("13 BigError") is None
        assert self.to_mixed_number(True) is None
        assert self.to_mixed_number("Error") is None

    def test_to_fraction(self):
        """Test to_fraction method from ConvertFractions."""

        # Normal cases
        assert self.to_fraction(1.3) == "13/10"
        assert self.to_fraction(3) == "3/1"
        assert self.to_fraction(-0.123) == "-123/1000"
        assert self.to_fraction(-24) == "-24/1"
        assert self.to_fraction("2 1/2") == "5/2"
        assert self.to_fraction("-3 2/3") == "-11/3"
        assert self.to_fraction("-1 -1/2") == "3/2"
        assert self.to_fraction("1 -1/2") == "-3/2"

        # Invalid arguments
        assert self.to_fraction("10/0") is None
        assert self.to_fraction("Error") is None

        # Special Cases
        assert self.to_fraction(False) == "0/1"  # False = 0
        assert self.to_fraction(True) == "1/1"  # True = 1
