"""Operation testing file from real_fractions package.

Classes:
    TestOperationFractions(): Test ConvertFraction class convert.
"""

from real_fractions import OperationFractions

class TestOperationFractions(OperationFractions):
    """Test ConvertFraction class convert.

    Tests:
        test_addition(): Test addition method from OperationFractions.
        test_substraction():
            Test substraction method from OperationFractions.
        test_multiplication():
            Test multiplication method from OperationFractions.
    """

    def test_addition(self):
        """Test addition method from OperationFractions."""

        # Normal cases
        assert self.addition("5/10", "5/10") == 1
        assert self.addition("1/2", "2/3", "3/4") == "23/12"
        assert self.addition("-1/3", "-1/3", "-1/3") == -1
        assert self.addition("5/10", "-5/10") == 0
        assert self.addition("-5/100", "7/100") == "1/50"

        # Invalid arguments
        assert self.addition("2/3", 243) is None
        assert self.addition("Error", "This is") is None

    def test_substraction(self):
        """Test substraction method from OperationFractions."""

        # Normal cases
        assert self.substraction("5/10", "5/10") == 0
        assert self.substraction("1/2", "2/3", "3/4") == "-11/12"
        assert self.substraction("-1/3", "-1/3", "-1/3") == "1/3"
        assert self.substraction("5/10", "-5/10") == 1
        assert self.substraction("-5/100", "7/100") == "-3/25"

        # Invalid arguments
        assert self.substraction("2/3", 243) is None
        assert self.substraction("Error", "This is") is None

    def test_multiplication(self):
        """Test multiplication method from OperationFractions."""

        # Normal cases
        assert self.multiplication("5/10", "5/10") == "1/4"
        assert self.multiplication("1/2", "2/3", "3/4") == "1/4"
        assert self.multiplication("-1/3", "-1/3", "-1/3") == "-1/27"
        assert self.multiplication("5/10", "-5/10") == "-1/4"
        assert self.multiplication("-5/100", "7/100") == "-7/2000"
        assert self.multiplication("3/2", 0) == 0
        assert self.multiplication("1/2", "1/1") == "1/2"

        # Invalid arguments
        assert self.multiplication("2/3", 243) is None
        assert self.multiplication("Error", "This is") is None

    def test_division(self):
        """Test division method from OperationFractions."""

        # Normal cases
        assert self.division("5/10", "5/10") == "1/1"
        assert self.division("1/2", "2/3", "3/4") == "1/1"
        assert self.division("-1/3", "-1/3", "-1/3") == "-3/1"
        assert self.division("5/10", "-5/10") == "-1/1"
        assert self.division("-5/100", "7/100") == "-5/7"
        assert self.division("1/2", "1/1") == "1/2"

        # Invalid arguments
        assert self.division("3/2", 0) is None
        assert self.division("2/3", 243) is None
        assert self.division("Error", "This is") is None
