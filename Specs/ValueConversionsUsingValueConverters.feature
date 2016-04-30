Feature: Conversions of values using custom value converters
	In order to easier compare values of the most common types
	As a user of SpecFlow Dynamic
	I want SpecFlow Dynamic to translate strings into real types using custom value converters

Scenario: Strings should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Name   |
		| Marcus |
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Age |
		| 39  |
	Then the Age property should be of type string and equal 39

Scenario: Doubles should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Length in meters |
		| 1.96             |
	Then the LengthInMeters property should be of type string and equal 1.96

Scenario: Decimals should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Molecular Weight      |
		| 1000000000.1111991111 |
	Then the MolecularWeight property should be of type string and equal 1000000000.1111991111

Scenario: Dates should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Birth date |
		| 1972-10-09 |
	Then the BirthDate property should be of type string and equal 1972-10-09

Scenario: Bools should be translated to strings when only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Is developer |
		| false        |
	Then the IsDeveloper property should be of type string and equal false

Scenario: A strange double should be translated to string shen only ValueToString converter is used
	When I create a dynamic instance with only ValueToString converter from this table
		| Length in meters |
		| 4.567            |
	Then the LengthInMeters property should be of type string and equal 4.567

Scenario: Strings should fall back to being translated to strings when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Name   |
		| Marcus |
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to decimals when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Age |
		| 39  |
	Then the Age property should be of type decimal and equal 39.00

Scenario: Doubles should be translated to decimals when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Length in meters |
		| 1.96             |
	Then the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Decimals should be translated to decimals when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Molecular Weight      |
		| 1000000000.1111991111 |
	Then the MolecularWeight property should be of type decimal and equal 1000000000.1111991111

Scenario: Dates should fall back to being translated to date times when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Birth date |
		| 1972-10-09 |
	Then the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Bools should fall back to being translated translated to bools when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Is developer |
		| false        |
	Then the IsDeveloper property should be of type bool and equal false

Scenario: A strange double should be translated to decimal when only ValueToDecimal converter is used
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Length in meters |
		| 4.567            |
	Then the LengthInMeters property should be of type decimal and equal 4.567

Scenario: Strings should be translated to strings when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Name   |
		| Marcus |
	Then the Name property should be of type string and equal Marcus

Scenario: Integers should be translated to decimals when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Age |
		| 39  |
	Then the Age property should be of type decimal and equal 39.00

Scenario: Doubles should be translated to decimals when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Length in meters |
		| 1.96             |
	Then the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Decimals should be translated to decimals when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Molecular Weight      |
		| 1000000000.1111991111 |
	Then the MolecularWeight property should be of type decimal and equal 1000000000.1111991111

Scenario: Dates should be translated to strings when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Birth date |
		| 1972-10-09 |
	Then the BirthDate property should be of type string and equal 1972-10-09

Scenario: Bools should be translated to strings when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Is developer |
		| false        |
	Then the IsDeveloper property should be of type string and equal false

Scenario: A strange double should be translated to decimal when ValueToDecimal and ValueToString converters are used
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Length in meters |
		| 4.567            |
	Then the LengthInMeters property should be of type decimal and equal 4.567
