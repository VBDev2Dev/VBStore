# Step By Step Guide

## Create Site See [Create site issue](https://github.com/VBDev2Dev/VBStore/pull/3)
1. Create ASP.Net MVC site  ![Create Site 1](images/Create site 1.png)  ![Create Site 2](images/Create site 2.png)
1. Choose bootstrap theme and update bootstrap files with new css files.  I chose [Cyborg from bootswatch](https://bootswatch.com/cyborg/)

## Setup Migrations
1. Enable migrations.  This will let us use code first migrations. Read about them [here]() ![Roles 1](images/Roles 1.png)
1. Add initial migration. ![Roles 2](images/Roles 2.png)
1. Update web config to have database names desired.

## Setup Roles
1. Add default role seeding to create the roles if needed.
1. Run update-database to apply code migrations and get roles in db.![Roles 3](images/Roles 3.png)
1. Add new users to default role.
