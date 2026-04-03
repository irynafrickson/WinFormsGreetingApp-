# 🎉 WinForms Greeting App (with MSTest Unit Tests)

A simple Windows Forms application built with .NET that displays a personalized greeting, along with a companion MSTest project to demonstrate clean unit‑testing practices.  
This project is intentionally minimal, focusing on clarity, structure, and testability — ideal for learning, teaching, or showcasing basic .NET desktop development.

---

## 🚀 Features

- Windows Forms UI with a textbox and button  
- Displays a greeting message based on user input  
- Clean separation of UI and logic  
- MSTest project with unit tests for the greeting logic  
- Organized solution structure following .NET best practices  
- `.gitignore` configured to keep the repo clean (no `bin/`, `obj/`, `.vs/`, etc.)


## 📁 Project Structure

```
WinFormsGreetingApp/
│
├── WinFormsTestApp.sln
│
├── WinFormsTestApp/
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Program.cs
│   └── WinFormsTestApp.csproj
│
└── WinFormsUnitTestApp/
    ├── GreetingTests.cs
    └── WinFormsUnitTestApp.csproj
```

## 🧪 Running the Unit Tests

1. Open the solution in Visual Studio  
2. Build the solution  
3. Open **Test Explorer**  
4. Run all tests  

The test project uses **MSTest**, the built‑in testing framework for .NET.

---

## ▶️ Running the Application

1. Open the solution in Visual Studio  
2. Set **WinFormsTestApp** as the startup project  
3. Press **F5** to run  

You’ll see a simple UI where you can enter your name and receive a greeting.

---

## 🛠️ Technologies Used

- **C#**
- **.NET / WinForms**
- **MSTest**
- **Visual Studio**
- **Git & GitHub**

---

## 🌱 Future Improvements (Optional Ideas)

- Add more UI elements (dropdowns, themes, icons)
- Add input validation
- Add more unit tests
- Add a separate class library for business logic
- Add CI (GitHub Actions) to run tests automatically

---

## 📄 License

This project is open‑source and free to use for learning or portfolio purposes.
