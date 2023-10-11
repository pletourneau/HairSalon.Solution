# _Eau Claire's Salon Stylist/Client Tracker_

#### By _Paul LeTourneau_

#### _An application that allows a Hair Salon owner to keep track of their Stylists and Clients._

## Technologies Used

* C#
* .NET 6
* MySQL
* GitHub
* HTML

## Description

This is a web application that uses a mySQL database to keep track of stylists and clients for a salon owner.

## Setup/Installation Requirements

### Install Tools
Install the tools that are introduced in this series of lessons on [LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).


### Set up and Run Project

1. Clone this repository from GitHub and open project in a code editor. 
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called "HairSalon". 
3. Within the production directory "HairSalon", create a new file called `appsettings.json`. 
4. Within the production directory "HairSalon", create a new file called `.gitignore` and add the following code before saving the file.
```
obj
bin
appsettings.json
``` 
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=paul_letourneau;uid=[user-id];pwd=[password];"
  }
}
```
    * Replace [user-id] with your SQL username
    * Replace [password] with your SQL password 
5. Within the production directory "HairSalon", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
6. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

### Set up the Databases
Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench)

To use the `paul_letourneau.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `paul_letourneau`. 

To import the `paul_letourneau.sql` file into MySQL Workbench:
1. Navigate to the `Administration` tab in MySQL
2. Select `Data Import/Restore`
3. Select the radio button for `Import from Self-Contained File`
4. Navigate to `paul_letourneau.sql` which is located in the top directory of the cloned project by entering in the path, or by selecting the `..` on the far right of the screen and navigating to the path
5. Select `New...` in the `Default Target Schema` line and enter in `paul_letourneau`
6. Click the dropdown list near the bottom of the page and change value to `Dump Structure Only`
7. In the bottom right of the page click `Start Import`
8. Navigate back to the `Schemas` tab and hit the refresh button (which looks like two arrows; one pointing up, and one pointing down). The database will now show!

## Known Bugs

* None found yet

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) _2023_ _Paul LeTourneau_