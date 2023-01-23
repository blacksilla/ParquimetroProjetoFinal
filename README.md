The project is a C# console application that simulates a parking meter system. It has several classes that work together to provide the functionality of the program.

1. "Parquimetro" class :
This is the main class of the program, it contains the Main method which is the entry point of the program. The Main method sets the console output encoding to UTF8 and sets the current date and time. It then calls the parkStatus method from the InterfaceHelper class to check if the parking meter is open or closed based on the current hour and day of the week. The program then initializes three instances of the Zonas class, which represent different parking zones. The Main method also creates a list of occupied parking spots for each zone, which is filled by calling the fillParkingSlots method from the Zonas class. The Main method also contains a while loop that displays a menu for the user to interact with the program. The menu has options for the user to exit the program, access the admin menu, and access the client menu. The admin menu has options to view the zones, view the historical data, view the machines, and go back to the main menu. The client menu is not implemented yet.

2. "Zonas" class :
This class represents a parking zone. It has several properties such as ID, hourly rate, max daily rate, and number of parking spots. It also has several methods such as "fillParkingSlots" which fills the list of occupied parking spots with random numbers. The class also has a constructor which initializes the properties.
3. "Car" class:
This class represents a car that is parked in the parking meter. It has three properties: brand, license plate, and parking time. It also has two static methods: "randomCarBrand" which returns a random brand name from a pre-defined list, and "returnRandomLicense" which generates and returns a random license plate number.

4. "InterfaceHelper" class:
This class contains several methods that are used to display different menus and prompts in the console for the user to interact with the program.
It has a method called "parkStatus" which takes two arguments, an hour and a day of the week and returns a boolean indicating if the parking meter is open or closed based on the schedule (it is open from 9am to 8pm from Monday to Friday and from 9am to 2pm on Saturdays)
It has several methods that display different menus in the console such as "writeStartMenu", "writeAdminMenu", and "writeClientMenu". These methods clear the console, write the menu options, and prompt the user to make a choice.
It also has a method called "returnIndexInput" which reads the user's input, attempts to parse it as an integer.

5. "MathHelper" class :
This class contains a single method called "returnRandomInt". This method takes three arguments: an integer "min", an integer "max", and an integer "multiple".
It creates a new instance of the "Random" class and generates a random integer between the "min" and "max" values using the Next() method of the random class.
Then it multiplies the random integer by "multiple" and returns the result, which is also an integer. This method can be used to generate random numbers that are multiples of a certain value, which can be useful in various situations such as generating random parking spot numbers or generating random times for a car to be parked.

Overall, the program simulates a parking meter system where the user can interact with the program through a menu-based interface in the console. The program has several classes that work together to provide the functionality of the program, such as creating and managing parking zones, simulating parking spots, generating random cars and license plates, displaying menus and prompts for the user to interact with the program, and more.

Note: The project is not complete, there are many functionalities that are not implemented yet, for example, the client menu, the payment system, and the history of parked cars.
