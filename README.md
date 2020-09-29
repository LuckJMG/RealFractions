# RealFractions

Python library who adds functions related to the operation and conversion of fractions in a string format, with specific classes depending on what needs to be done.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

Make sure you have Python and that the expected version is available from your command line. You can check this by running:

``` PowerShell
python --version
```

You should get some output like `Python 3.6.3`. If you do not have Python, please install the latest 3.x version from [python.org](https://python.org)

Additionally, you’ll need to make sure you have pip available. You can check this by running:

``` PowerShell
pip --version
```

If you installed Python from source, with an installer from [python.org](https://python.org) you should already have pip. If you’re on Linux and installed using your OS package manager, you may have to install pip separately, see Installing [pip/setuptools/wheel with Linux Package Managers](https://packaging.python.org/guides/installing-using-linux-tools/).

If pip isn’t already installed, then first try to bootstrap it from the standard library:

``` PowerShell
python -m ensurepip --default-pip
```

While pip alone is sufficient to install from pre-built binary archives, up to date copies of the setuptools and wheel projects are useful to ensure you can also install from source archives:

``` PowerShell
python -m pip install --upgrade pip setuptools wheel
```

### Installing

To install the latest version of ImprovedReplace:

``` PowerShell
pip install -U real-fractions
```

And then you can import this library in Python:

``` Python
from real_fractions import convert

fraction = "1/2"
fraction = to_decimal(fraction)

print(string)
# Output: 0.5
```

Or you can check the project in [PyPI](https://pypi.org/project/real-fractions/).

## Running the tests

To run automated module tests you first need to install py.test:

``` PowerShell
pip install -U py.test
```

Then you must to download the source code of the module in his [github repository](https://github.com/LuckJMG/RealFractions), go to the tests folder with PowerShell and run pytest:

``` PowerShell
pytest
```

### Some test examples

These are some examples of the automated test

``` Python
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
```

This test is testing all the general cases of the function `simplify` of the core module.

## Built With

-   [Python](https://www.python.org) - Programming language used
-   [VS Code](https://code.visualstudio.com/) - Code editor used
-   [Trello](https://www.trello.com) - Task manager used

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags).

## Authors

- **Lucas Mosquera** - *Creator and maintainer* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/LuckJMG/RealFractions/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details

## Acknowledgments

This is my second package that I publish as open source, it was a project that I proposed as a challenge to practice programming, I am still a junior programmer but I tried to do my best.
Thanks anyway for getting here, a kiss.
