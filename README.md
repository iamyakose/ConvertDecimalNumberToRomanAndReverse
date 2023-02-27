# Roman numerals

 The basis of the project is to Implement a solution that can convert Roman numerals to decimal value and from decimal value to Roman numerals. The rules for Roman numerals vary, but the rules we work from are described as below.

## Seven letters denote the numbers in the Roman system:

Section I = 1

§ V = 5

§ X = 10

§ L = 50

§ C = 100

§ D = 500

§ M = 1000

#### Rules:

- § If the same Roman numeral is written consecutively, the number is added

  Example: II = 1 + 1 = 2

- § If a smaller Roman numeral is written after a large Roman numeral, the number is added to the large one

  Example: VI = 5 + 1 = 6


-  § If a smaller Roman numeral is written before a larger number, the number is subtracted from the larger one
 Example: IV = 5 – 1 = 4

- § There may only be one smaller Roman numeral in front of a larger Roman numeral

- § Only I, X and C can appear before a larger Roman numeral
  You can only stand in front of V and X
  X can only be in front of L and C
  C can only stand before D and M

- § There may be no more than three identical Roman numerals in succession
V, L and D are never repeated

It is enough to be able to convert numbers less than 3000

Proposal for acceptance test: 1999, 2444, 90
