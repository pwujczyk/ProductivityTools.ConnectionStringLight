<!--Category:C#,PowerShell--> 
 <p align="right">
        <a href="https://www.nuget.org/packages/ProductivityTools.ConnectionStringLight/"><img   src="Images/Header/Nuget_border_40px.png" /></a>
        <a href="http://productivitytools.tech/connectionstringlightpt/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
        <a href="https://github.com/pwujczyk/ProductivityTools.ConnectionStringLight"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="http://productivitytools.tech/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>

# Connection string light

Library generates connection string from params.

<!--more-->

It exposes two methods

- GetSqlDataSourceConnectionString - creates connection string to server

```c#
var x=ConnectionStringLight.GetSqlDataSourceConnectionString(".");
Assert.AreEqual(x, "Data Source=.;Integrated Security=True");
```
- GetSqlServerConnectionString - creates connection string to database on the server

```c#
var y = ConnectionStringLight.GetSqlServerConnectionString(".", "dbName");
Assert.AreEqual(y, "Data Source=.;Initial Catalog=dbName;Integrated Security=True");
```


![Img](Images/Image.png)


