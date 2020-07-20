from setuptools import setup, find_packages

with open("README.md", "r") as fh:
    long_description = fh.read()

setup(
    name="fractions",
    version="1.0.0",
    description="Add all types of functions with fractions",
    long_description="Add functions related to the operation and conversion of fractions in a string format, with specific classes depending on what needs to be done",
    long_description_content_type="text/markdown",
    status="Production",
    license="MIT License",
    copyright="Copyright 2020, LuckJMG",
    author="Lucas Mosquera",
    author_email="lucas.mosquera13@gmail.com",
    maintainer="Lucas Mosquera",
    maintainer_email="lucas.mosquera13@gmail.com",
    credits=["LuckJMG"],
    url="https://github.com/LuckJMG/Fractions",
    packages=find_packages(),
    classifiers=[
        "Programming Language :: Python :: 3",
        "License :: OSI Approved :: MIT License",
        "Operating System :: OS Independent",
    ],
    python_requires=">=3.6",
)
