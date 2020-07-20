"""Operation module from real_fractions package.

Classes:
    OperationFractions: Operation class from real_fractions.
"""

from .core import Fractions

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

        temporal_fraction = "0/1"

        for i in enumerate(0, len(fractions)):
            if i != 0:
                if cls.zero_checker(temporal_fraction, fractions[i]):
                    numerator1, denominator1 = cls.separate_numbers(temporal_fraction)
                    numerator2, denominator2 = cls.separate_numbers(fractions[i])
                    new_denominator = denominator1 * denominator2
                    new_numerator = (
                        numerator1 * denominator2 + numerator2 * denominator1
                    )
                    temporal_fraction = str(new_numerator) + "/" + str(new_denominator)
                    temporal_fraction = cls.simplify(temporal_fraction)
                else:
                    temporal_fraction = "0/1"
            else:
                temporal_fraction = fractions[0]
            i = +1

        if temporal_fraction != "0/1":
            return temporal_fraction

        return 0

    @classmethod
    def substraction(cls, *fractions):
        """Substract 2 or more fractions.

        Returns:
            str: Result from the substraction of the fractions.
        """

        temporal_fraction = "0/1"

        for i in enumerate(0, len(fractions)):
            if i != 0:
                if cls.zero_checker(temporal_fraction, fractions[i]):
                    numerator1, denominator1 = cls.separate_numbers(temporal_fraction)
                    numerator2, denominator2 = cls.separate_numbers(fractions[i])
                    new_denominator = denominator1 * denominator2
                    new_numerator = (
                        numerator1 * denominator2 - numerator2 * denominator1
                    )
                    temporal_fraction = str(new_numerator) + "/" + str(new_denominator)
                    temporal_fraction = cls.simplify(temporal_fraction)
                else:
                    temporal_fraction = "0/1"
            else:
                temporal_fraction = fractions[0]
            i = +1

        if temporal_fraction != "0/1":
            return temporal_fraction

        return 0

    @classmethod
    def multiplication(cls, *fractions):
        """Multiply 2 or more fractions.

        Returns:
            str: Result from the multiplication of the fractions.
        """

        temporal_fraction = "1/1"

        for i in enumerate(0, len(fractions)):
            if i != 0:
                numerator1, denominator1 = cls.separate_numbers(temporal_fraction)
                numerator2, denominator2 = cls.separate_numbers(fractions[i])
                new_denominator = denominator1 * denominator2
                new_numerator = numerator1 * numerator2
                temporal_fraction = str(new_numerator) + "/" + str(new_denominator)
                temporal_fraction = cls.simplify(temporal_fraction)
            else:
                temporal_fraction = fractions[0]

        return temporal_fraction

    @classmethod
    def division(cls, *fractions):
        """Divide 2 or more fractions.

        Returns:
            str: Result from the division of the fractions.
        """

        temporal_fraction = "1/1"

        for i in enumerate(0, len(fractions)):
            if i != 0:
                numerator1, denominator1 = cls.separate_numbers(temporal_fraction)
                numerator2, denominator2 = cls.separate_numbers(fractions[i])
                new_denominator = denominator1 * numerator2
                new_numerator = denominator2 * numerator1
                temporal_fraction = str(new_numerator) + "/" + str(new_denominator)
                temporal_fraction = cls.simplify(temporal_fraction)
            else:
                temporal_fraction = fractions[0]

        return temporal_fraction
