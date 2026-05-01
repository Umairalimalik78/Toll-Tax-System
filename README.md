# 🛣️ Toll Tax System

A fully functional **Toll Tax Management System** built as a Windows Forms desktop application using C# and SQL Server. It allows toll operators to register driver and vehicle crossing records, manage travel details, calculate toll charges, and maintain a searchable database of all crossings — all through a clean multi-form GUI backed by a local SQL Server database (`TollTaxDB`).

---

## 📸 Preview

> <img width="995" height="637" alt="image" src="https://github.com/user-attachments/assets/0bbbabd5-ff49-4610-ac2e-7403e26252ca" />
<img width="995" height="637" alt="image" src="https://github.com/user-attachments/assets/f641d286-817c-404d-b10f-dcb1ccc00340" />

---

## ✨ Features

- ➕ **Add Crossing Record** — Register new toll crossings with Driver Name, NIC, Vehicle Type, From City, To City, Travel Date, Toll Tax, and Passenger count
- 🚗 **Vehicle Type Selection** — Choose vehicle type via a ComboBox (Bike, Car, Van, Bus, Truck, etc.)
- 🏙️ **City Route Selection** — Select From City and To City from dropdown menus
- 📅 **Travel Date Picker** — Select the exact date of crossing using a DateTimePicker
- 📋 **Dashboard View** — View all crossing records live in a DataGridView loaded from SQL Server on startup
- 🔍 **Real-Time Search** — Instantly filter records by Driver Name or Driver NIC using `RowFilter`
- 🗑️ **Double-Click to Delete** — Double-click any row to delete a crossing record with a confirmation dialog
- 🔄 **Auto Grid Refresh** — Grid reloads automatically after every add or delete via `LoadDriverData()`
- 🧹 **Reset Form** — Clear all fields (TextBoxes, ComboBoxes, DateTimePicker) with a single button
- ✅ **Parameterized Queries** — All SQL operations use parameterized commands to prevent SQL injection
- ⚠️ **Error Handling** — All database operations wrapped in try/catch with user-friendly error messages
- 🏗️ **Multi-Form Architecture** — Dedicated forms for the Dashboard and the Add Crossing Record flow

---

## 🛠️ Built With

| Technology | Purpose |
|---|---|
| **C# (.NET Framework)** | Core application logic & Windows Forms UI |
| **Windows Forms (WinForms)** | Desktop GUI framework |
| **SQL Server (LocalDB)** | Database for storing toll crossing records |
| **ADO.NET (SqlConnection / SqlCommand / SqlDataAdapter)** | Database connectivity & parameterized queries |
| **Visual Studio** | IDE & project management |

---

## 🗄️ Database Schema

**Database:** `TollTaxDB`
**Table:** `Drivers`

```sql
CREATE TABLE Drivers (
    AID            INT PRIMARY KEY IDENTITY(1,1),
    DriverName     VARCHAR(100),
    DriverNIC      VARCHAR(20),
    CrossingVehicle VARCHAR(50),
    FromCity       VARCHAR(50),
    ToCity         VARCHAR(50),
    TravelDate     DATE,
    TollTAX        INT,
    Passengers     INT
);
```

---

## 📁 Project Structure

```
Toll-Tax-System/
│
├── Form1.cs                              # Dashboard — DataGridView, search & delete logic
├── Form1.Designer.cs                     # Auto-generated UI layout for Form1
├── Form1.resx                            # Resources for Form1
├── Form2.cs                              # Add Crossing form — input fields & save logic
├── Form2.Designer.cs                     # Auto-generated UI layout for Form2
├── Form2.resx                            # Resources for Form2
├── Form3.cs                              # Third form (Login / additional screen)
├── Form3.Designer.cs                     # Auto-generated UI layout for Form3
├── Form3.resx                            # Resources for Form3
├── Program.cs                            # Application entry point
├── SQLQuery2.sql                         # Database & table creation script
├── App.config                            # Application configuration
├── Student Registration Managment.csproj # Project file
├── Student Registration Managment.sln    # Solution file
├── .gitignore                            # Git ignore rules
├── Properties/                           # Assembly & application properties
├── Resources/                            # Embedded resources
└── bin/Debug/                            # Compiled output
```

---

## ⚙️ How It Works

**Form1 — Dashboard:**
- Loads all driver/crossing records from `TollTaxDB.Drivers` into a DataGridView on startup via `LoadDriverData()`
- Real-time search filters rows by `DriverName` or `DriverNIC` using `DataTable.DefaultView.RowFilter`
- Double-clicking any row triggers a delete confirmation, removing the record from both the DB and the grid

**Form2 — Add Crossing Record:**
- Opens via the "Add Record" button on the Dashboard
- Accepts: Driver Name, Driver NIC, Vehicle Type (ComboBox), From City (ComboBox), To City (ComboBox), Travel Date (DateTimePicker), Toll Tax, Passengers
- Saves the record to `TollTaxDB` using a parameterized `INSERT` query
- On success, calls `mainForm.LoadDriverData()` to refresh the grid and closes automatically
- Reset button clears all TextBoxes, ComboBoxes, and resets the DateTimePicker to today

---

## 🚀 Getting Started

### Prerequisites

- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/)
- .NET Framework (Windows Forms support)
- SQL Server LocalDB (included with Visual Studio)

### Run Locally

1. **Clone the repository**

```bash
git clone https://github.com/Umairalimalik78/Toll-Tax-System.git
```

2. **Open the solution in Visual Studio**

```
Open: Student Registration Managment.sln
```

3. **Set up the database**

- Open **SQL Server Object Explorer** in Visual Studio
- Connect to `(localdb)\MSSQLLocalDB`
- Create a new database named `TollTaxDB`
- Run `SQLQuery2.sql` to create the `Drivers` table

4. **Build & Run**

- Press `F5` or click **Start** in Visual Studio
- The Toll Tax dashboard will launch as a Windows desktop app

---

## 👨‍💻 Author

**Umair Ali**

- GitHub: [@Umairalimalik78](https://github.com/Umairalimalik78)

---

<p align="center">Made with ❤️ by Umair Ali</p>
