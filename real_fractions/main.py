from .convert import ConvertFractions
from .operation import OperationFractions

operation = OperationFractions()
test = operation.root("1/8", -3)
print(test)
