Feature: Create dynamic objects from SpecFlow table using delegates
	In order to write only code that matters
	As a SpecFlow developer
	I want SpecFlow to create dynamic objects from a table row using conversion delegates

Background: 
	Given a table MarcusOneRow
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	And a table MarcusTwoColumns
		| Name   | Age | 
		| Marcus | 39  | 
	And a table Marcus
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |

Scenario: Create dynamic instance from table with one row using ValueToString delegate
	When I create a dynamic instance using ValueToString delegate from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToString delegate
	When I create a dynamic instance using ValueToString delegate from table MarcusTwoColumns
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToString delegate
	When I create a dynamic instance using ValueToString delegate from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDouble delegate
	When I create a dynamic instance using ValueToDouble delegate from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDouble delegate
	When I create a dynamic instance using ValueToDouble delegate from table MarcusTwoColumns
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDouble delegate
	When I create a dynamic instance using ValueToDouble delegate from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDecimal delegate
	When I create a dynamic instance using ValueToDecimal delegate from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal delegate
	When I create a dynamic instance using ValueToDecimal delegate from table MarcusTwoColumns
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal delegate
	When I create a dynamic instance using ValueToDecimal delegate from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToInt delegate
	When I create a dynamic instance using ValueToInt delegate from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToInt delegate
	When I create a dynamic instance using ValueToInt delegate from table MarcusTwoColumns
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToInt delegate
	When I create a dynamic instance using ValueToInt delegate from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime delegate
	When I create a dynamic instance using ValueToDateTime delegate from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime delegate
	When I create a dynamic instance using ValueToDateTime delegate from this table
		| Name   | BirthDate  | 
		| Marcus | 1972-10-09 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime delegate
	When I create a dynamic instance using ValueToDateTime delegate from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime delegate with custom date format
	When I create a dynamic instance using ValueToDateTime delegate using date format dd/MM/yyyy from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 09/10/1972 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime delegate with custom date format
	When I create a dynamic instance using ValueToDateTime delegate using date format dd/MM/yyyy from this table
		| Name   | BirthDate  | 
		| Marcus | 09/10/1972 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime delegate with custom date format
	When I create a dynamic instance using ValueToDateTime delegate using date format dd/MM/yyyy from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 09/10/1972 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDecimal and ValueToString delegate
	When I create a dynamic instance using delegates ValueToDecimal, ValueToString from table MarcusOneRow
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal and ValueToString delegate
	When I create a dynamic instance using delegates ValueToDecimal, ValueToString from table MarcusTwoColumns
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal and ValueToString delegate
	When I create a dynamic instance using delegates ValueToDecimal, ValueToString from table Marcus
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

