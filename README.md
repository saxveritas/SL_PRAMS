# Squadron Level Purchase Request And Management System (SL PRAMS)

SL PRAMS (pronounced 'slow' PRAMS) is a self-contained application that allows Squadron Level (SL) personnel to submit purchase requests.  

This system leverages a database for accounting and management for historical usage in Squadron planning for fiscal year budget execution.

## CSC425 Module 4 STATUS

### This project is in an initial alpha release.
##### Final tweaks to the UI have been completed and primary functionality has been adequately tested
##### Local network database has been successfully configured and tested.
##### There are no errors in the code nor bugs on user actions.

The system is currently configured to only work on my laptop so full functionality by others would require the VM files which are rather large.
alternatively, i've created some videos showing the application in action for review that covers the majority of the applications use cases.

A local email server is established and functionally works on the system. 
This is thanks to a combination of hmail and autosql.  
This works via a scheduled job that uses a SQL query to determine if the table for purchase requests has new additions and if so gathers up those inputs and emails them to the test user.  
In prodution this test user would be a distribution group that contains the AOs.  
Hmail was chosen because it is free and allows for funtionality testing of the system in a closed network.


## Getting Started

Build the self-contained application and deploy to end users.

Database configuration must be accomplished before the program can successfully execute.

# VIDEOS


##### Example of exceptional user handling

[![](http://img.youtube.com/vi/PFx9jiwqoT4/0.jpg)](http://www.youtube.com/watch?v=PFx9jiwqoT4 "")

##### Example of some errant user handling

[![](http://img.youtube.com/vi/BVBZZ6l5b6k/0.jpg)](http://www.youtube.com/watch?v=BVBZZ6l5b6k "")

##### Brief overview of the core C# mechanisms

[![](http://img.youtube.com/vi/hlA1XqXnlb8/0.jpg)](http://www.youtube.com/watch?v=hlA1XqXnlb8 "")

##### Database overview

[![](http://img.youtube.com/vi/5uzttjHhV_c/0.jpg)](http://www.youtube.com/watch?v=5uzttjHhV_c "")

##### AutoSQL configuration

![Auto S Q L1](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/autoSQL1.PNG)
![Auto S Q L2](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/autoSQL2.PNG)
![Auto S Q L3](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/autoSQL3.PNG)
![Auto S Q L4](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/autoSQL4.PNG)

##### Scheduled Job

![Scheduled Task 1](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/scheduled_task_1.PNG)

##### Hmail validation

![Hmail Server1](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/hmail_server1.PNG)
![Mail Success](https://github.com/saxveritas/SL_PRAMS/blob/master/SL_PRAMS/mail_success.PNG)

##### Overview
[![](http://img.youtube.com/vi/tM3t5HgfL18/0.jpg)](http://www.youtube.com/watch?v=tM3t5HgfL18 "")

### Prerequisites

For Debugging & code review:
Visual Studio 2017 or other capable IDE

For execution:
A windows 7 or newer operating system
Access to a configured SL PRAMS database


### Installing

Build the application in your IDE and deploy to end users.  

The application must be hard-coded to reference the targeted database in this alpha build.

## Code tests

No tests currently exist in this alpha.
unit testing is intended for late beta builds



## Deployment

Provide end users with the application


## Contributing

Contact Alexander Carsner (alexander.mcarsner@my.trident.edu) if interested in contributing.

## Versioning

Version 0.1.2

## Authors

* **Alexander M. Carsner**

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* My wonderful Wife for being my rock while I finish school. I love you Sweetheart!
* My Daughter and Son for bringing me joy when the sludge of work gets me down!
* My dog for always being happy to see me!
* My mentors and leaders who've helped make me who I am today.
* My Mother in Law for showing me what grace and wisdom look like.
