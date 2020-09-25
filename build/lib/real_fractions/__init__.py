"""Add all types of functions with fractions.

Add functions related to the operation and conversion of fractions
in a string format, with specific classes depending on what needs
to be done.

ConvertFractions
to_decimal(fraction)                    -- Convert a fraction into his decimal
to_decimal(fraction, decimal_amount)    --
to_mixed_number(fraction)                --
to_fraction(decimal)                    --
to_fraction(mixed_number)                -- Convert a mixed number into his fraction

OperationFractions
addition(*fractions)        -- Add multiple fractions
substraction(*fractions)    -- Substract multiple fractions
multiplication(*fractions)    -- Multiply multiple fractions
division(*fractions)        -- Divide multiple fractions
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
__version__ = "0.9.0"
__status__ = "Production"
__all__ = ["ConvertFractions", "OperationFractions"]
