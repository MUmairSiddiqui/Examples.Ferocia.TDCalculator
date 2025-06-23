# Examples.Ferocia.TDCalculator
Example colsole app to calculate compounding interest amount in total.

## Overview
The Domain layer contains models and enums and service contracts. The Services layer contains the implementation detail for the calculator service. DI is used to inject calculator service where needed.

## Getting Started
### Requirements & Setup
- Visual Studio 2022 or VC Code
- .NET 9
- Restore dependencies build and run the app

## Assumptions
Information from the below links are used to calculate the compounding amount.
- For all the unit test cases
https://www.bendigobank.com.au/calculators/deposit-and-savings/
- Formula
https://moneysmart.gov.au/saving/compound-interest
https://www.calculatorsoup.com/calculators/financial/compound-interest-calculator.php
- Currently this only provided the total compounded amount after a fixed term deposit for yearly/quartely/monthly terms with a fixed interest rate on initial deposit.

## Tests
Unit tests are provided. Run them with NUnit 3 test adapter for Visual Studio 2022
