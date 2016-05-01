Feature: Conversions of values using custom value converters
	In order to easier compare values of the most common types
	As a user of SpecFlow Dynamic
	I want SpecFlow Dynamic to translate strings into real types using custom value converters

Background: 
	Given a table Name
		| Name   |
		| Marcus |
	And a table Age
		| Age |
		| 39  |
	And a table LengthInMeters
		| Length in meters |
		| 1.96             |
	And a table StrangeLengthInMeters
		| Length in meters |
		| 4.567            |
	And a table MolecularWeight
		| Molecular Weight      |
		| 1000000000.1111991111 |
	And a table BirthDate
		| Birth date |
		| 1972-10-09 |
	And a table IsDeveloper
		| Is developer |
		| false        |

Scenario: Strings should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table Name
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table Age
	Then the Age property should be of type string and equal 39

Scenario: Doubles should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table LengthInMeters
	Then the LengthInMeters property should be of type string and equal 1.96

Scenario: Decimals should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table MolecularWeight
	Then the MolecularWeight property should be of type string and equal 1000000000.1111991111

Scenario: Dates should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table BirthDate
	Then the BirthDate property should be of type string and equal 1972-10-09

Scenario: Bools should be translated to strings using ValueToString converter
	When I create a dynamic instance using ValueToString converter from table IsDeveloper
	Then the IsDeveloper property should be of type string and equal false

Scenario: A strange double should be translated to string shen ValueToString converter
	When I create a dynamic instance using ValueToString converter from table StrangeLengthInMeters
	Then the LengthInMeters property should be of type string and equal 4.567

Scenario: Strings should fall back to being translated to strings using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table Name
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to decimals using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table Age
	Then the Age property should be of type decimal and equal 39.00

Scenario: Doubles should be translated to decimals using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table LengthInMeters
	Then the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Decimals should be translated to decimals using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table MolecularWeight
	Then the MolecularWeight property should be of type decimal and equal 1000000000.1111991111

Scenario: Dates should fall back to being translated to date times using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table BirthDate
	Then the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Bools should fall back to being translated translated to bools using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table IsDeveloper
	Then the IsDeveloper property should be of type bool and equal false

Scenario: A strange double should be translated to decimal using ValueToDecimal converter
	When I create a dynamic instance using ValueToDecimal converter from table StrangeLengthInMeters
	Then the LengthInMeters property should be of type decimal and equal 4.567

Scenario: Strings should be translated to strings when using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table Name
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to decimals using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table Age
	Then the Age property should be of type decimal and equal 39.00

Scenario: Doubles should be translated to decimals using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table LengthInMeters
	Then the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Decimals should be translated to decimals using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table MolecularWeight
	Then the MolecularWeight property should be of type decimal and equal 1000000000.1111991111

Scenario: Dates should be translated to strings using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table BirthDate
	Then the BirthDate property should be of type string and equal 1972-10-09

Scenario: Bools should be translated to strings using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table IsDeveloper
	Then the IsDeveloper property should be of type string and equal false

Scenario: A strange double should be translated to decimal using ValueToDecimal and ValueToString converters
	When I create a dynamic instance using converters ValueToDecimal, ValueToString from table StrangeLengthInMeters
	Then the LengthInMeters property should be of type decimal and equal 4.567

Scenario: Dates should be translated to DateTime using ValueToDateTime converter is used with custom date format
	When I create a dynamic instance using ValueToDateTime converter with date format dd/MM/yyyy from this table
		| Birth date |
		| 09/10/1972 |
	Then the BirthDate property should be of type DateTime and equal 1972-10-09

