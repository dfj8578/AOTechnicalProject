Feature: AOHomePageFeature
	

@mytag
Scenario: Search for Washing Machines
	Given When i Navigate to AO homepage
    And i enter the Search Keyword in the Search Text Box
    | Keyword  |
    | Washing Machines |
	And I should Click on Search Button
   Then i should select a Brand Name "Hotpoint" to navigate to Lister page
   And i Filter the product by its "Wash Load of Large"
   And i Verify the results are successfully filtered based on your selection criteria
   