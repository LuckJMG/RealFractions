"""Operation module from real_fractions package.

Classes:
    OperationFractions: Operation class from real_fractions.
"""

from .core import Fractions
from .convert import ConvertFractions

class OperationFractions(Fractions):
    """Operation class from real_fractions.

    Methods:
        addition(*fractions): Add 2 or more fractions.
        substraction(*fractions): Substract 2 or more fractions.
        multiplication(*fractions): Multiply 2 or more fractions.
        division(*fractions): Divide 2 or more fractions.
    """

    @classmethod
    def addition(cls, *fractions):
        """Add 2 or more fractions.

        Returns:
            str: Result from the addition of the fractions.
        """

        # Discard invalid arguments
        for index, fraction in enumerate(fractions):
            if not isinstance(fraction, str):  # Invalid argument types
                print("The argument {0} isn't a fraction".format(index))
                return None

            if cls.simplify(fraction) is None:  # Non fraction arguments
                print("The argument {0} isn't a fraction".format(index))
                return None

        tmp_fraction = "0/1"  # Neutral element

        try:
            for index, fraction in enumerate(fractions):
                if index != 0:
                    if cls.add_zero_checker(tmp_fraction, fraction):
                        # Separate numbers
                        numerator1, denominator1 = cls.separate_numbers(
                            tmp_fraction
                        )
                        numerator2, denominator2 = cls.separate_numbers(
                            fraction
                        )

                        # Calculate new fraction
                        new_denominator = str(denominator1 * denominator2)
                        new_numerator = str(
                            numerator1 * denominator2
                            + numerator2 * denominator1
                        )

                        # Make new fraction
                        tmp_fraction = new_numerator + "/" + new_denominator
                        tmp_fraction = cls.simplify(tmp_fraction)
                        numbers = cls.separate_numbers(tmp_fraction)
                        numerator = numbers[0]
                        denominator = numbers[1]

                        # Variations
                        if denominator == 1:
                            tmp_fraction = numerator

                        elif numerator == denominator:
                            tmp_fraction = 1

                    else: tmp_fraction = "0/1"  # The addition is zero

                else: tmp_fraction = fractions[0] # Start Point

            if tmp_fraction == "0/1":
                tmp_fraction = 0

            return tmp_fraction

        except ValueError:
            print("One of the arguments isn't a fraction")


    @classmethod
    def substraction(cls, *fractions):
        """Substract 2 or more fractions.

        Returns:
            str: Result from the substraction of the fractions.
        """

        # Discard invalid arguments
        for index, fraction in enumerate(fractions):
            if not isinstance(fraction, str):  # Invalid argument types
                print("The argument {0} isn't a fraction".format(index))
                return None

            if cls.simplify(fraction) is None:  # Non fraction arguments
                print("The argument {0} isn't a fraction".format(index))
                return None

        tmp_fraction = "0/1"  # Neutral element

        try:
            for index, fraction in enumerate(fractions):
                if index != 0:
                    if cls.sub_zero_checker(tmp_fraction, fraction):
                        # Separate numbers
                        numerator1, denominator1 = cls.separate_numbers(
                            tmp_fraction
                        )
                        numerator2, denominator2 = cls.separate_numbers(
                            fraction
                        )

                        # Calculate new fraction
                        new_denominator = str(denominator1 * denominator2)
                        new_numerator = str(
                            numerator1 * denominator2
                            - numerator2 * denominator1
                        )

                        # Make new fraction
                        tmp_fraction = new_numerator + "/" + new_denominator
                        tmp_fraction = cls.simplify(tmp_fraction)
                        numbers = cls.separate_numbers(tmp_fraction)
                        numerator = numbers[0]
                        denominator = numbers[1]

                        # Variations
                        if denominator == 1:
                            tmp_fraction = numerator

                        elif numerator == denominator:
                            tmp_fraction = 1

                    else: tmp_fraction = "0/1"  # The addition is zero

                else: tmp_fraction = fractions[0]  # Start point

            if tmp_fraction == "0/1":
                tmp_fraction = 0

            return tmp_fraction

        except ValueError:
            print("One of the arguments isn't a fraction")

    @classmethod
    def multiplication(cls, *fractions):
        """Multiply 2 or more fractions.

        Returns:
            str: Result from the multiplication of the fractions.
        """

        # Discard invalid arguments
        for index, fraction in enumerate(fractions):
            if not isinstance(fraction, str) and fraction != 0:
                # Invalid argument types
                print("The argument {0} isn't a fraction".format(index))
                return None

            if cls.simplify(fraction) is None:  # Non fraction arguments
                print("The argument {0} isn't a fraction".format(index))
                return None

        tmp_fraction = "1/1"  # Neutral element

        for index, fraction in enumerate(fractions):

            if fraction == 0 or tmp_fraction == 0:  # 0 * n = 0
                return 0

            if index != 0:
                # Multiplication
                numerator1, denominator1 = cls.separate_numbers(tmp_fraction)
                numerator2, denominator2 = cls.separate_numbers(fraction)
                new_denominator = denominator1 * denominator2
                new_numerator = numerator1 * numerator2

                # New fraction
                tmp_fraction = str(new_numerator) + "/" + str(new_denominator)
                tmp_fraction = cls.simplify(tmp_fraction)

            else: tmp_fraction = fractions[0]  # Start point

        return tmp_fraction

    @classmethod
    def division(cls, *fractions):
        """Divide 2 or more fractions.

        Returns:
            str: Result from the division of the fractions.
        """

        # Discard invalid arguments
        for index, fraction in enumerate(fractions):
            if not isinstance(fraction, str):  # Invalid argument types
                print("The argument {0} isn't a fraction".format(index))
                return None

            if cls.simplify(fraction) is None:  # Non fraction arguments
                print("The argument {0} isn't a fraction".format(index))
                return None

        tmp_fraction = "1/1"  # Neutral element

        for index, fraction in enumerate(fractions):
            if index != 0:
                # Division
                numerator1, denominator1 = cls.separate_numbers(tmp_fraction)
                numerator2, denominator2 = cls.separate_numbers(fraction)
                new_denominator = denominator1 * numerator2
                new_numerator = denominator2 * numerator1

                # New fraction
                tmp_fraction = str(new_numerator) + "/" + str(new_denominator)
                tmp_fraction = cls.simplify(tmp_fraction)

            else: tmp_fraction = fractions[0]  # Start point

        return tmp_fraction

    @classmethod
    def exponential(cls, fraction, exponent):
        """Raise the fraction to the indicated exponent

        Returns:
            str: Result from the exponent of the fraction.
        """

        if not isinstance(fraction, str):  # Invalid first argument
            print("The first argument isn't a fraction")
            return None

        elif not isinstance(exponent, (int, float)):  # Invalid second argument
            print("The second argument isn't a number")
            return None

        if cls.simplify(fraction) is None:  # Non fraction arguments
            print("The first argument isn't a fraction")
            return None

        convert = ConvertFractions()

        # Exponent
        numerator, denominator = cls.separate_numbers(fraction)
        numerator = numerator ** exponent
        numerator = convert.to_fraction(numerator)
        denominator = denominator ** exponent
        denominator = convert.to_fraction(denominator)

        # New fraction
        fraction = cls.division(numerator, denominator)

        return fraction
