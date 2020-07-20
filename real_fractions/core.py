"""Core module from real_fractions package.

Classes:
    Fractions: Base real_fraction class.
"""


class Fractions:
    """Base class from real_fractions.

    Methods:
        separate_numbers(fraction):
            Separate fraction into numerator and denominator.
        sign_checker(fraction): Check sign of maximum fraction.
        simplify(fraction): Simplify fraction to his minimum expresion.
        zero_checker(fraction1, fraction2):
            Check if in an addition of two fractions returns zero.
    """

    @classmethod
    def separate_numbers(cls, fraction):
        """Separate fraction into numerator and denominator.

        Args:
            fraction (str): Fraction to separate numbers

        Returns:

            int: Numerator of the fraction
            int: Denominator of the fraction
        """

        if not isinstance(fraction, str): # Discard invalid argument types
            print("The argument isn't a fraction")
            return None

        try:
            numbers = fraction.split("/")  # Separate numerator and denominator
            numerator = int(numbers[0])
            denominator = int(numbers[1])
            return numerator, denominator

        except ValueError:  # Discard invalid string arguments
            print("The argument isn't a fraction")

    @classmethod
    def sign_checker(cls, fraction):
        """Check sign of maximum fraction.

        Args:
            fraction (str): Fraction to check his sign

        Returns:
            str: Real fraction sign
        """

        if not isinstance(fraction, str):  # Discard invalid argument types
            print("The argument isn't a fraction")
            return None

        try:
            numerator, denominator = cls.separate_numbers(fraction)

            if numerator > 0 > denominator:  # Check if its negative
                fraction = str(-(numerator)) + "/" + str(abs(denominator))

            elif numerator < 0 and denominator < 0:  # Check if its positive
                fraction = str(abs(numerator)) + "/" + str(abs(denominator))

            elif denominator == 0:  # ZeroDivision Error
                print("Can't be divided by zero!")
                return None

            else:
                fraction = str(numerator) + "/" + str(denominator)

            return fraction

        except TypeError: # Discard invalid string arguments
            print("The argument isn't a fraction")

    @classmethod
    def simplify(cls, fraction):
        """Simplify fraction to his minimum expresion.

        Args:
            fraction (str): Fraction to simplify

        Returns:
            str: Simplified fraction
        """


        if not isinstance(fraction, str):  # Discard invalid argument types
            print("The argument isn't a fraction")
            return None

        try:
            numerator, denominator = cls.separate_numbers(fraction)
            res = 0
            maximum = abs(max(numerator, denominator))
            minimum = abs(min(numerator, denominator))

            while minimum != 0:  # Calculate M.C.D
                res = minimum
                minimum = maximum % minimum
                maximum = res

            numerator = str(int(numerator / maximum))
            denominator = str(int(denominator / maximum))
            fraction = numerator + "/" + denominator
            fraction = cls.sign_checker(fraction)
            return fraction

        except TypeError:  # Discard invalid string argument
            print("The argument isn't a fraction")

    @classmethod
    def zero_checker(cls, fraction1, fraction2):
        """Check if in an addition of two fractions returns zero.

        Args:
            fraction1 (str): First fraction in the addition
            fraction2 (str): Second fraction in the addition

        Returns:
            bool: If false the addition of the fractions returns zero, if is
            true the addition don't return zero
        """

        # Discard invalid arguments type
        if not isinstance(fraction1, str):  # First argument
            print("The first argument isn't a fraction")
            return

        elif not isinstance(fraction2, str):  # Second argument
            print("The second argument isn't a fraction")
            return None

        # Check the sign of the fractions
        if (
                "-" in fraction1
                and "-" not in fraction2
                and fraction1.replace("-", "") == fraction2
        ):  # First case in which the sum gives zero
            is_not_zero = False

        elif (
                "-" not in fraction1
                and "-" in fraction2
                and fraction1 == fraction2.replace("-", "")
        ):  # Second case in which the sum gives zero
            is_not_zero = False

        elif (
                cls.simplify(fraction1) is None
                or cls.simplify(fraction2) is None
        ):  # Invalid arguments
            return None

        else:  # Other cases when the addition doesn't return zero
            is_not_zero = True

        return is_not_zero
