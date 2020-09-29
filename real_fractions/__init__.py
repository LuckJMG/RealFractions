"""Add all types of functions with fractions.

Add functions related to the operation and conversion of fractions
in a string format, with specific classes depending on what needs
to be done.

Fractions():
    separate_numbers(fraction):
        Separate fraction into numerator and denominator.
    sign_checker(fraction): Check sign of maximum fraction.
    simplify(fraction): Simplify fraction to his minimum expresion.
    add_zero_checker(fraction1, fraction2):
        Check if in an addition of two fractions returns zero.
    sub_zero_checker(fraction1, fraction2):
        Check if in a substraction of two fractions returns zero.

ConvertFractions():
    to_decimal(fraction, number_decimal):
        Convert a fraction into his decimal with an specific amount of
        decimals.
    to_mixed_number(fraction): Convert a fraction into his mixed number.
    to_fraction(number): Convert a decimal into his fraction.

OperationFractions():
    addition(*fractions): Add 2 or more fractions.
    substraction(*fractions): Substract 2 or more fractions.
    multiplication(*fractions): Multiply 2 or more fractions.
    division(*fractions): Divide 2 or more fractions.
"""

from .core import Fractions
from .convert import ConvertFractions
from .operation import OperationFractions

__tittle__ = "real fractions"
__url__ = "https://github.com/LuckJMG/RealFractions"
__author__ = "LuckJMG"
__email__ = "lucas.mosquera13@gmail.com"
__license__ = "MIT license"
__copyright__ = "Copyright 2020, LuckJMG"
__version__ = "1.0.2"
__status__ = "Production"
__all__ = ["ConvertFractions", "OperationFractions"]
