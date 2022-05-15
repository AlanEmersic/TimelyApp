# `Timely`

Project was created with Angular, ASP.NET Core and PostgreSQL

## `Angular`

### `Steps`

- Install all packages using command: `npm i` or `npm install`

- Run using command: `ng serve -o`

- Open [http://localhost:4200/](http://localhost:4200/) to view it in the browser.


## `ASP.NET Core & PostgreSQL`

### `Steps`

- create database with name  `timely`

- run `schema.sql` script

- configure appsettings.json ConnectionStrings:
  - `"TimelyDbContext"`: "Host=localhost;Port=5432;Database=timely;User Id=postgres;Password=pass;"