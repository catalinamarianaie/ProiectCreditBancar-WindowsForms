# Bank Loan Application - Windows Forms + SQLite + Office Interop

This is a desktop application built with C# and Windows Forms that simulates the evaluation process of a bank loan request, featuring database-based authentication, Word document generation, and saving data/statistics to Excel.

---

## 🧩 Features

- Create account and user authentication (saved in **SQLite**)
- View and delete accounts from the admin interface
- Credit score simulation based on income, debt, and age
- Monthly payment calculation and automatic decision (APPROVED / REJECTED / UNDER REVIEW)
- Generate a personalized Word document for the user
- Save loan requests to an Excel file
- Generate a colorful chart in Excel with statistics (approved / rejected / under review)
- Graphical interface with themed background images

---

## 🧰 Technologies Used

- .NET Framework / .NET Windows Forms
- **SQLite** (via `System.Data.SQLite`)
- Microsoft Office Interop (Word & Excel)
- C#
- Git + GitHub

---

## 📦 Database

- The `utilizatori.db` file is automatically generated at first run
- The `Users` table contains: `Id`, `Username`, `Password`, `AccountType`
- All accounts are managed through this local database
- The database can be viewed with [DB Browser for SQLite](https://sqlitebrowser.org/)

---

## 📁 File Structure

- `FormCerere.cs` – form for filling in loan requests
- `FormAdmin.cs` – admin interface with requests, charts, and accounts
- `FormAutentificare.cs` – login and database initialization
- `FormCreareCont.cs` – account creation in SQLite
- `Resources` – background images used on forms
- `CereriCredite.xlsx` – generated file containing all loan requests
- `utilizatori.db` – local database with accounts
