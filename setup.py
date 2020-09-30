from setuptools import setup, find_packages

with open("README.md", "r") as fh:
    long_description = fh.read()

setup(
    name="real-fractions",
    version="1.1.0",
    description="Add all types of functions with fractions",
    long_description=long_description,
    long_description_content_type="text/markdown",
    status="Production",
    license="MIT License",
    copyright="Copyright 2020, LuckJMG",
    author="Lucas Mosquera",
    author_email="lucas.mosquera13@gmail.com",
    maintainer="Lucas Mosquera",
    maintainer_email="lucas.mosquera13@gmail.com",
    credits=["LuckJMG"],
    url="https://github.com/LuckJMG/RealFractions",
    packages=find_packages(exclude=["tests"]),
    classifiers=[
        "Programming Language :: Python :: 3",
        "License :: OSI Approved :: MIT License",
        "Operating System :: OS Independent",
    ],
    python_requires=">=3.6",
)
