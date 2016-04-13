Feature: Custom value conversion
	In order to easier compare values of types
	As a user of SpecFlow Dynamic
	I want to specify custom logic for converting strings into types

Scenario: Strings should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Name   |
		| Marcus |
	Then the Name property should be of type String and equal Marcus

Scenario: Integers should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Age |
		| 39  |
	Then the Age property should be of type String and equal 39

Scenario: Doubles should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Length in meters |
		| 1.96             |
	Then the LengthInMeters property should be of type String and equal 1.96

Scenario: Decimals should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Molecular Weight      |
		| 1000000000.1111991111 |
	Then the MolecularWeight property should be of type String and equal 1000000000.1111991111

Scenario: Dates should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Birth date |
		| 1972-10-09 | 
	Then the BirthDate property should be of type String and equal 1972-10-09

Scenario: Bools should be translated to strings with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Is developer |
		| false        | 
	Then the IsDeveloper property should be of type String and equal false

Scenario: A strange double should be translated to string with ValueToString converter
	When I create a dynamic instance with custom ValueToString converter from this table
		| Length in meters |
		| 4.567            |
	Then the LengthInMeters property should be of type String and equal 4.567






	