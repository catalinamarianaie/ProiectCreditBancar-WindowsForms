
# Aplicație de Credit Bancar - Windows Forms + SQLite + Office Interop

Aceasta este o aplicație desktop creată cu C# și Windows Forms care simulează procesul de evaluare a unei cereri de credit bancar, cu autentificare bazată pe bază de date, generare documente Word și salvare de date/statistici în Excel.

---

## 🧩 Funcționalități

- Creare cont și autentificare utilizator (cu salvare în **SQLite**)
- Vizualizare și ștergere conturi din interfața admin
- Simulare scor de credit pe baza venitului, datoriei și vârstei
- Calcul rată lunară și decizie automată (APROBAT / RESPINS / ÎN ANALIZĂ)
- Generare document Word personalizat pentru utilizator
- Salvare cereri într-un fișier Excel
- Generare grafic colorat în Excel cu statistici (aprobate / respinse / analiză)
- Interfață grafică cu imagini de fundal tematice

---

## 🧰 Tehnologii utilizate

- .NET Framework / .NET Windows Forms
- **SQLite** (prin `System.Data.SQLite`)
- Microsoft Office Interop (Word & Excel)
- C#
- Git + GitHub

---

## 📦 Bază de date

- Fișierul `utilizatori.db` este generat automat la prima rulare
- Tabela `Utilizatori` conține: `Id`, `Username`, `Parola`, `TipCont`
- Toate conturile sunt gestionate prin această bază de date locală
- Baza de date poate fi vizualizată cu [DB Browser for SQLite](https://sqlitebrowser.org/)

---

## 📁 Structura fișierelor

- `FormCerere.cs` – formular pentru completare cerere
- `FormAdmin.cs` – interfață admin cu cereri, grafice și conturi
- `FormAutentificare.cs` – login și inițializare bază de date
- `FormCreareCont.cs` – creare cont în SQLite
- `Resources` – imagini de fundal folosite pe formulare
- `CereriCredite.xlsx` – fișier generat cu toate cererile
- `utilizatori.db` – baza de date locală cu conturi
