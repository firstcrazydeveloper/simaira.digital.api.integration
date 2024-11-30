@TestSuite_Simaira.Digital
@UserInfo
Feature: User Info Page
	The tests verify user aligned CDM Site Locations/ Accounts/ Service Areas/ Devices operations.
	This includes:
	1. Aligned CDM Sites & Account
	2. Service Areas & Devices
	3. Account Info & Details
	4. Location Details
	5. H7Id Connected Accounts
	6. Ecolab3d & ESS User Customer Goal

@UsersCDMSitesAndAccounts
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Users Emails exist in CDM with aligned CDM Sites and Accounts
	Given The users already exist in CDM API
		| Email								|
	Then Get aligned CDM Sites and Accounts of Users from CDM API
	Then Set User Accounts
		| AccountNumber						|
	Then Get Service Areas and Devices for Accounts
	Then Get Account Info
		| AccountNumber						|
	Then Get Location Details
		| Sites								|


@H7IdConnectAccounts
@ESSIntegrationtest
Scenario: Simaira.Digital_API_ h7Id Connected Account Exist exist
	Given The H7Id already exist
		| H7Id				  |
		| a071O000015I1OSQA0  |
	Then Get Connected Accounts for H7Id Info
	Then Set h7Id Connected Accounts
	Then Get Service Areas and Devices for Accounts
	Then Get Account Info
		| AccountNumber						|
	Then Get Account Details Info
		| AccountNumber						|
	Then Get Location Details
		| Sites								|


@Ecola3DUserCustomerGoal
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Ecolab User Customer Goal
	Given The users already exist in CDM API
		| Email								|
		| ecolab3dcorptest1@mailinator.com  |
		| ecolab3dunittest17@mailinator.com |
		| ecolab3dunittest14@mailinator.com |
	Then Get aligned CDM Sites and Accounts of Users from CDM API
	Then Get Customer Goal


@ESSUserCustomerGoal
@ESSIntegrationtest
Scenario: Simaira.Digital_API_ ESS User Customer Goal
	Given The H7Id already exist
		| H7Id				  |
		| a071O000015I1OSQA0  |
	Then Get Connected Accounts for H7Id Info
	Then Set h7Id Connected Accounts
	Then Get Account Details Info
		| AccountNumber						|
	Then Get Customer Goal

@Ecola3DUserBenchMarking
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Ecolab User BenchMarking
	Given The users already exist in CDM API
		| Email								|
		| ecolab3dcorptest1@mailinator.com  |
		| ecolab3dunittest17@mailinator.com |
		| ecolab3dunittest14@mailinator.com |
	Then Get aligned CDM Sites and Accounts of Users from CDM API
	Then Set User Accounts
		| AccountNumber						|
	Given Set Ecolab Features
		| Feature	|
		| DM		|
		| HH		|
		| SS		|
	Then Get Customer BenchMarking

@ESSUserCustomerBenchMarking
@ESSIntegrationtest
Scenario: Simaira.Digital_API_ ESS User BenchMarking
	Given The H7Id already exist
		| H7Id				  |
		| a071O000015I1OSQA0  |
	Then Get Connected Accounts for H7Id Info
	Then Set h7Id Connected Accounts
	Then Get Account Details Info
		| AccountNumber						|
	Given Set Ecolab Features
		| Feature	|
		| DM		|
		| HH		|
		| SS		|
	Then Get Customer BenchMarking