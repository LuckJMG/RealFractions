"""Convert module from real_fractions package.

Classes:
    ConvertFractions: Convert class from real_fractions.
"""

from math import trunc
from .core import Fractions

class ConvertFractions(Fractions):
    """Convert class from real_fractions.

    Methods:
        to_decimal(fraction, number_decimal):
            Convert a fraction into his decimal with an specific amount of
            decimals.
        to_mixed_number(fraction): Convert a fraction into his mixed number.
        to_fraction(number): Convert a decimal into his fraction.
    """

    @classmethod
    def to_decimal(cls, fraction, number_decimal=None):
        """Convert a fraction into his decimal with an specific amount of
        decimals.

        Args:
            fraction (str): Fraction to convert to its decimal
            number_decimal (int, optional): Amount decimal places of the
            decimal. Defaults to None.

        Returns:
            float: Decimal of the fraction
        """

        # Discard invalid argument types
        if not isinstance(fraction, str):  # First argument
            print("The first argument isn't a fraction")
            return None

        elif (
                not number_decimal is None
                and not isinstance(number_decimal, int)
            ):  # Second Argument
            print("The second argument isn't an integer")
            return None

        try:
            numerator, denominator = cls.separate_numbers(fraction)
            decimal = numerator / denominator  # Calculate decimal

            if number_decimal is not None:  # Optional argument
                decimal = round(decimal, number_decimal)

            return decimal

        except TypeError:  # Discard invalid string arguments
            print("One of the arguments isn't a valid argument")

    @classmethod
    def to_mixed_number(cls, fraction):
        """Convert a fraction into his mixed number.

        Args:
            fraction (str): Fraction to convert to a mixed number

        Returns:
            str: Mixed number of the fraction
        """

        if not isinstance(fraction, str):  # Discard invalid argument types
            print("The argument isn't a fraction")
            return None

        try:
            numerator, denominator = cls.separate_numbers(fraction)

            if denominator == 0:  # ZeroDivision Error
                print("Cannot be divided by zero")
                return None

            if abs(numerator) > abs(denominator):
                # Calculate integer part
                if 1 > (numerator / denominator) > 0:  # If trunc(x) = None
                    integer = 1

                else:  # Other cases
                    integer = int(trunc(numerator / denominator))

                # Calculate new numerator
                numerator = abs(numerator) % abs(denominator)

                if numerator != 0:
                    fraction = str(numerator) + "/" + str(abs(denominator))
                else:  # If res = 0 so there is a perfect division
                    return integer

                fraction = cls.simplify(fraction)
                mixed_number = str(integer) + " " + fraction
                return mixed_number

            return fraction

        except TypeError:  # Discard invalid string arguments
            print("The argument isn't valid")

    @classmethod
    def to_fraction(cls, number):
        """Convert a decimal into his fraction.

        Args:
            number (int/float): Number to convert to a fraction

        Returns:
            str: Fraction of the number
        """

        try:
            if isinstance(number, str):  # Case mixed number
                # Separate integer and fraction part
                numbers = number.split(" ")
                numbers[1] = cls.sign_checker(numbers[1])
                numerator, denominator = cls.separate_numbers(numbers[1])

                # Check if is negative or positive
                # Two parts in negative
                if "-" in numbers[0] and "-" in str(numerator):
                    integer = abs(int(numbers[0]))
                    numerator = (integer * denominator + abs(numerator))

                # One part in negative
                elif "-" in numbers[0] or "-" in str(numerator):
                    integer = abs(int(numbers[0]))
                    numerator = (integer * denominator + abs(numerator)) * -1

                else:  # Zero parts in negative
                    integer = int(numbers[0])
                    numerator = integer * denominator + numerator

                fraction = str(numerator) + "/" + str(denominator)
                fraction = cls.simplify(fraction)

            elif isinstance(number, (int, float)):
                # Case int and float
                # Separate integer and decimal
                numbers = str(float(number)).split(".")
                # Count number of decimals
                decimal_amount = len(numbers[1])
                # Calculate numerator
                numerator = round(float(number) * pow(10, decimal_amount), 0)
                numerator = int(numerator)
                # Calculate denominator
                denominator = pow(10, decimal_amount)
                # New fraction
                fraction = str(numerator) + "/" + str(denominator)
                fraction = cls.simplify(fraction)

            else:
                # Discard invalid argument types
                print("The argument isn't valid")
                return None

            return fraction

        except (TypeError, IndexError):  # Discard invalid string arguments
            print("The argument isn't valid")
