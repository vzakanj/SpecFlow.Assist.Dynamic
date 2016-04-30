Feature: Conversions of values
	In order to easier compare values of the most common types
	As a user of SpecFlow Dynamic
	I want SpecFlow Dynamic to translate strings into the closest ressembling real type


Scenario: Strings should be translated to string
	When I create a dynamic instance from this table
		| Name   |
		| Marcus |
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated from strings
	When I create a dynamic instance from this table
		| Age |
		| 39  |
	Then the Age property should be of type int and equal 39

Scenario: Doubles should be translated from strings
	When I create a dynamic instance from this table
		| Length in meters |
		| 1.96             | 
	Then the LengthInMeters property should be of type double and equal 1.96

Scenario: Decimals should be translated from strings
	When I create a dynamic instance from this table
		| Molecular Weight      |
		| 1000000000.1111991111 |
	Then the MolecularWeight property should be of type decimal and equal 1000000000.1111991111

Scenario: Dates should be translated from strings
	When I create a dynamic instance from this table
		| Birth date |
		| 1972-10-09 | 
	Then the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Bools should be translated from strings
	When I create a dynamic instance from this table
		| Is developer |
		| false        | 
	Then the IsDeveloper property should be of type bool and equal false

Scenario: A strange double should not be translated into a date
	When I create a dynamic instance from this table
		| Length in meters |
		| 4.567            |  
	Then the LengthInMeters property should be of type double and equal 4.567
