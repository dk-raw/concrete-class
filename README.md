<div align='center'>
 

# Concrete Class
<i>In order for this to work you will have to have Entity Framework installed on your IDE</i>

</div>

<hr/>

### Build Database:
#### Step 1
Navigate to: ```Visual Studio > Tools > NuGet Pckg Manager > Console```
#### Step 2
Type: ```enable-migrations```
#### Step 3
Type: ```add-migration MyMigration``` where <i>MyMigration</i> is the name
#### Step 4
Type: ```update-database```

<hr/>

### Console Output:
```Type an employee's name``` <br />
then the console waits for a user input and saves that to the Database
after one keypress it prints every entry in the Database.
### Example:
```Type an employee's name``` <br/>
```> John Doe``` <b>user input</b> <br/>
``` John Doe ``` <br/>
```David Evans``` <br/>
```Jackie Chan ``` <br/>
where <i>John Doe</i> is the latest entry and <i>David Evans</i> , <i>Jackie Chan</i> are previous entries in the Database

<hr />

##### Note:
<i>if you haven't noticed already, I made a little big mistake naming the class <b>Employees</b> istead of <b>Employee</b> but anyways, I hope this helps.</i>
