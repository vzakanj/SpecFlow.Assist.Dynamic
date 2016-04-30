Feature: Create dynamic objects from SpecFlow table using value converters
	In order to write only code that matters
	As a SpecFlow developer
	I want SpecFlow to create dynamic objects from a table row using specified value converters

Scenario: Create dynamic instance from table with one row using ValueToString converter
	When I create a dynamic instance with only ValueToString converter from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToString converter
	When I create a dynamic instance with only ValueToString converter from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToString converter
	When I create a dynamic instance with only ValueToString converter from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type string and equal 39
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type string and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDouble converter
	When I create a dynamic instance with only ValueToDouble converter from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDouble converter
	When I create a dynamic instance with only ValueToDouble converter from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDouble converter
	When I create a dynamic instance with only ValueToDouble converter from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type double and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDecimal converter
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal converter
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal converter
	When I create a dynamic instance with only ValueToDecimal converter from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToInt converter
	When I create a dynamic instance with only ValueToInt converter from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToInt converter
	When I create a dynamic instance with only ValueToInt converter from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39

Scenario: Create dynamic instance from table with Field and Values using ValueToInt converter
	When I create a dynamic instance with only ValueToInt converter from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime converter
	When I create a dynamic instance with only ValueToDateTime converter from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime converter
	When I create a dynamic instance with only ValueToDateTime converter from this table
		| Name   | BirthDate  | 
		| Marcus | 1972-10-09 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09

Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime converter
	When I create a dynamic instance with only ValueToDateTime converter from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDateTime converter with custom date format
	When I create a dynamic instance with only ValueToDateTime converter using date format dd/MM/yyyy from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 09/10/1972 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDateTime converter with custom date format
	When I create a dynamic instance with only ValueToDateTime converter using date format dd/MM/yyyy from this table
		| Name   | BirthDate  | 
		| Marcus | 09/10/1972 | 
	Then the Name property should be of type string and equal Marcus
		And the BirthDate property should be of type DateTime and equal 1972-10-09


Scenario: Create dynamic instance from table with Field and Values using ValueToDateTime converter with custom date format
	When I create a dynamic instance with only ValueToDateTime converter using date format dd/MM/yyyy from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 09/10/1972 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type int and equal 39
		And the BirthDate property should be of type DateTime and equal 1972-10-09
		And the LengthInMeters property should be of type double and equal 1.96

Scenario: Create dynamic instance from table with one row using ValueToDecimal and ValueToString converters
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96

Scenario: Create dynamic instance from table with one row and 2 columns using ValueToDecimal and ValueToString converters
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Name   | Age | 
		| Marcus | 39  | 
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00

Scenario: Create dynamic instance from table with Field and Values using ValueToDecimal and ValueToString converters
	When I create a dynamic instance with converters ValueToDecimal, ValueToString from this table
		| Field            | Value      |
		| Name             | Marcus     |
		| Age              | 39         |
		| Birth date       | 1972-10-09 |
		| Length in meters | 1.96       |
	Then the Name property should be of type string and equal Marcus
		And the Age property should be of type decimal and equal 39.00
		And the BirthDate property should be of type string and equal 1972-10-09
		And the LengthInMeters property should be of type decimal and equal 1.96
