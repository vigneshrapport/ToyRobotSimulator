# 🧸 Toy Robot Simulator

A simple console application that simulates a toy robot moving on a square table.  
The robot can be placed, moved, rotated, and report its position and direction.  

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later

### Build and Run
```bash
# Clone repository
git clone https://github.com/yourusername/ToyRobotSimulator.git
cd ToyRobotSimulator

# Build
dotnet build

# Run
dotnet run --project ToyRobotSimulator
```

---

## 🎮 Usage

When you run the simulator, you can enter commands in the console:

- `PLACE X,Y,F`  
  - `X` and `Y` are integers (the robot’s position on the table).  
  - `F` is the facing direction: `NORTH`, `SOUTH`, `EAST`, `WEST`.  
- `MOVE` – Move forward one unit in the current facing direction.  
- `LEFT` – Rotate the robot left 90 degrees.  
- `RIGHT` – Rotate the robot right 90 degrees.  
- `REPORT` – Output the robot’s current position and direction.  

### Example
```
PLACE 0,0,NORTH
MOVE
REPORT
```

Output:
```
Output: 0,1,NORTH
```

---

## 📂 Project Structure

```text
ToyRobotSimulator.sln
  ├── ToyRobotSimulator      
  │   ├── Program.cs
  │   ├── Core/
  │   │   ├── Simulator.cs
  │   │   ├── Robot.cs
  │   │   └── Table.cs
  │   └── Common/
  │       └── Enum/
  │           ├── Direction.cs
  │           └── Command.cs
  ├── ToyRobotSimulator.Tests/     
  │   └── SimulatorTests.cs 
  ├── README.md 
  ├── .gitignore 
  └── LICENSE (optional)
```

---

## 🧪 Running Tests
```bash
dotnet test
```

---

## 📜 License
This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
