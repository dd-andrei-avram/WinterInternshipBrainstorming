# DDROIDD Winter Internship 2022


During this festive season, all children around the globe are sending their requests to Santa. Due to the pandemic, Santa found some extra time and decided to build a computerized system for tracking the gift requests. Unfortunately he had to take care of his reindeer and couldn't finish the project. Let's help Santa!

Here are the requirements:

1. The classes in the Core folder are incomplete. You will need to add fields/properties and links between the classes.
 We need to uniquely identify each child and keep information like: name, date of birth, address, etc. and if the child was good or bad. Each child can write only one letter. The letter needs to include the date when it was written. Each letter will contain a list of items - each item will have a unique identifier, name, etc. 
 There is a method in the Program class named Question1. In this method please build a sample data structure by instantiating the classes you previously created and display it on the console. Expected outcome: 3 Child objects each with one Letter containing 2 Items
Create a class diagram for your implementation



2. Santa decided to standardize the letter format this year. You can see an example in the letter-template.txt
Please create 3 new letter files using the provided format.
Read the newly created letter files and create an object structure based on the information in the files. Expected outcome: 3 Child objects each with one letter containing the provided items
Display the children names on the console
*Use the method Question2 from the Program class*


3. Using the data structure from Question 1, please generate letter files following the letter template but taking into account the information stored on each child. Hint: replace the tags with the actual information in the data structure (e.g. FULL_NAME with the name in the Child object)
*Use the method Question3 from the Program class*

4. Based on the letter files created or generated before, Santa needs to build a report for the Toy Factory. 
The report needs to highlight home many of each toy the elves need to build. Report format: Toy Name - Quantity
The report needs to be ordered decending by quantity
*Use the method Question4 from the Program class*

5. Can you apply Singleton Pattern in the current implementation? Please insert a comment explaining your choice 
*Use the method Question5 from the Program class*

6. Let's help Santa with his travel itinerary. We need to make sure that Santa visits each city only once. 
Expected outcome: list with all addresses, grouped by city
*Use the method Question6 from the Program class*
