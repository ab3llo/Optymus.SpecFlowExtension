Feature: Environment Configuration
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	

Scenario: Check localhost app config is loaded
	Then correct configuration is loaded
	| Key     | Value     			  |
	| BaseUrl | http://localhost:5000 |