Feature: Create dynamic objects from SpecFlow table using delegates
	In order to write only code that matters
	As a SpecFlow developer
	I want SpecFlow to create dynamic objects from a table row using conversion delegates

Scenario: Create dynamic instance from table with one row using ValueToString delegate
	When I create a dynamic instance with only ValueToString delegate from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToString delegate
	When I create a dynamic instance with only ValueToString delegate from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToString delegate
	When I create a dynamic instance with only ValueToString delegate from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDouble delegate
	When I create a dynamic instance with only ValueToDouble delegate from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDouble delegate
	When I create a dynamic instance with only ValueToDouble delegate from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDouble delegate
	When I create a dynamic instance with only ValueToDouble delegate from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDecimal delegate
	When I create a dynamic instance with only ValueToDecimal delegate from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal delegate
	When I create a dynamic instance with only ValueToDecimal delegate from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal delegate
	When I create a dynamic instance with only ValueToDecimal delegate from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToInt delegate
	When I create a dynamic instance with only ValueToInt delegate from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToInt delegate
	When I create a dynamic instance with only ValueToInt delegate from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToInt delegate
	When I create a dynamic instance with only ValueToInt delegate from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime delegate
	When I create a dynamic instance with only ValueToDateTime delegate from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime delegate
	When I create a dynamic instance with only ValueToDateTime delegate from this table
		| Name   | BirthDate  | 
		| Marcus | 1972-10-09 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime delegate
	When I create a dynamic instance with only ValueToDateTime delegate from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime delegate with custom date format
	When I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 09/10/1972 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime delegate with custom date format
	When I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table
		| Name   | BirthDate  | 
		| Marcus | 09/10/1972 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09


Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime delegate with custom date format
	When I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table
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
	When I create a dynamic instance with delegates ValueToDecimal, ValueToString from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal and ValueToString delegate
	When I create a dynamic instance with delegates ValueToDecimal, ValueToString from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal and ValueToString delegate
	When I create a dynamic instance with delegates ValueToDecimal, ValueToString from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

