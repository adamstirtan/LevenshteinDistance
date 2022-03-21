# Levenshtein Distance in C#

In information theory, linguistics, and computer science, the Levenshtein distance is a string metric for measuring the difference between two sequences. Informally, the Levenshtein distance between two words is the minimum number of single-character edits (insertions, deletions or substitutions) required to change one word into the other. It is named after the Soviet mathematician Vladimir Levenshtein, who considered this distance in 1965.

Levenshtein distance may also be referred to as edit distance, although that term may also denote a larger family of distance metrics known collectively as edit distance.

## Getting Started

This repository consists of a Visual Studio solution with three projects:

1. LevenshteinDistance.Core: The main with the algorithm implementation/class
2. LevenshteinDistance.Blazor: A Blaazor app with a demo autocomplete list of countries
3. LevenshteinDistance.Tests: MSTest project with a few basic tests to run and debug to understand how it works

### Prerequisites

- Visual Studio, Visual Studio Code, etc
- .NET 6

## Use cases

- Spell checking
- Speech recognition
- DNA analysis
- Plagiarism detection

## Algorithm

![image](https://user-images.githubusercontent.com/9989813/159198681-06cf0ad2-f12f-45f8-a67d-91543369ebdb.png)

## Running the tests

`dotnet test`

## Authors

- **Adam Stirtan** - [adamstirtan](https://github.com/adamstirtan)

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/adamstirtan/LevenshteinDistance/blob/master/LICENSE) file for details

## Acknowledgments

- Wikipedia
- Ethan Nam - https://medium.com/@ethannam/understanding-the-levenshtein-distance-equation-for-beginners-c4285a5604f0
