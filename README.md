Jurassic Park PEDAC

P - Create a console application to manage data related to collection of dinosaurs at my zoo - Will track following info about each dinosaur:
Name, Diet Type, When Acquired, Weight, Enclosure Number — (5 properties) - When Console App. Starts it should allow for following functionality:
Add, View, Remove, a dinosaur. Transfer Enclosure Number. Also view summary of all dinosaurs. Quit Application —- (6 option menu)

E -
Add: Name - Dino Name
DietType: (C)arnivore or (H)erbivore
WhenAcquired: Will default current time when Dino was created (date time now)
Weight: Dino’s weight in pounds
EnclosureNumber: # of pen dinosaur lives in

[WhenAcquired] needs to be a non-editable {Date.Time} variable when the entry is made into the application. This will be used for generating the View report that lists the date the dinosaurs were added to the collection. This report is sorted using LINQ SortBy and Then By expressions by date.time stamp.

When [AddingDino] or transferring enclosure, a warning message appears if field is left blank. Ex) “Sorry invalid input”
Action cancelled and return to main menu.

Collections Report - (C)
Prints/displays all dinosaurs and their corresponding properties in current collection
Console.WriteLine($"Dinosaur Name: {dinoName}\nDiet Type: {dietType}\nWeight: {weight}\nEnclosure Number: {enclosureNumber}\nWhen Acquired: {Date.Time}\n")

Transfer (T) - Assign the enclosure number during initial adding of the dinosaur. If the dinosaur is transferred, the enclosure number should and can be updated in the application.

D -
[Class] - Create a class to represent dinosaurs. Contains following properties:
Name,
Diet Type
When Acquired,
Weight - (int parsed)

- [Weight] entry could contain a decimal, so be sure variable type is double. Convert entry to two decimal places - 178.43, 203.00, 457.02, etc
  Enclosure Number

— (5 properties) —

[MethodDescription] aka [Collection]
Add a method Description to your class to print out a description of all dinosaurs to include all the properties. Create an output format of your choosing. Feel free to be creative. **TBD**To be built under the class, but need an output option. Name "Collection"

[Remove] - allow user to search for dinosaur by name, confirm deletion, and remove upon confirmation.

[View] - - **use LINQ OrderBy and ThenBy**
This command will show the all the dinosaurs in the list, ordered by WhenAcquired.
Use {Date.Time} stamp If there aren't any dinosaurs in the park then print out a message that there aren't any.

[Transfer] - Only prompt user with a new Enclosure Number to be edited. Other fields are non-editable and should not be included.

Data Storage - Data will be stored in a List<Dinosaur>.

A -
Create a welcome screen for app. (DisplayGreeting method)
Create a Menu
Prompt user to enter their selection. Convert to Upper

Menu

Collections Management:
(A)dd - New dinosaur to collection
(R)emove dinosaur from collection
(T)ransfer a dinosaurs enclosure

Reports:
(C)collection details of all dinosaurs and their properties
(S)summary of diet types
(V)iew Dinosaurs and date acquired
(Q)uit application

Create Dinosaur Class
-Include the 5 properties: Name, Diet Type, When Acquired, Weight, Enclosure Number

(Keep track of dinosaurs in LIST called DinosaursProperties) - assignment requirement that must feed into the class Dinosaur
Prompt user to enter their selection. Convert to Upper
If the user selects (Q)uit

- Console.WriteLine "Have a roarin' great day at Jurrasic Zoo!"
- Terminate and close application

If user selects (A)dd
Create a class: Dinosaur
[dinoName] - Dino name [dietType] - This will be "carnivore" or "herbivore" [whenAcquired] - {Date.Time entry} - (user cannot edit this. This is autocompleted) [weight] - How heavy the dinosaur is in pounds. (int.parse) [enclosureNumber] - the number of the pen the dinosaur is in

- Console.WriteLine warning to users that all fields must be entered or addition will be cancelled.
  Console.WriteLine / Console.Read prompts with user inputs for the following fields:
- [dinoName] - Dinosaur's name
- [dietType] - Please indicate "carnivore" or "herbivore"
- [whenAcquired] - {Date.Time entry} - (user cannot edit this. This is autocompleted)
- [weight] - How heavy the dinosaur is in pounds. (int.parse)
- [enclosureNumber] - the number of the pen the dinosaur is in
  Add entry to Dinosaurs

If user selects (C)ollection

- TBDAdd a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.
- If user selects (R)emove Identify dinosaur by name If no match, null If match, present confirmation prompt to user. If No, cancel If Yes, remove the record

If the user selects (S)ummary

- Generate a report counting the number of dinosaurs - grouping counts of omnivores and carnivores -Use LINQ expression count
  - Return counts in Console.WriteLine -If there are no dinosaurs in the collection, Console.WriteLine "There are no dinosaurs in our collection."
- Return to menu
  If the user selects (T)ransfer
- Prompt use with Console.Read line to collect dinosaur name to be removed. -Include LINQ "Contains" expression to help return results.
  _ -If no match, Console.WriteLine message "No such dinosaur exists in our collection." and return to menu
  _ If match, Console.WriteLine "Please enter {dinosaur} new enclosure pen" \* Console.Read to collect user input
  If the user selects (V)iew
- Generate a report of all dinosaurs in the collection -Use LINQ OrderBy and ThenBy function to arrange dinosaurs based on {Date.Time} stamp when dinosaur was created -If there are no dinosaurs in the collection, Console.WriteLine "There are no dinosaurs in our collection."
- Return to menu
